using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicacao_Kolping.Services;
using Aplicacao_Kolping.Models;
using Aplicacao_Kolping.Services.Exceptions;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;
using Aplicacao_Kolping.Data;

namespace Aplicacao_Kolping.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AlunoService _AlunoService;
        private readonly ModalidadesService _ModalidadesService;
        private readonly IMapper _mapper;

        public AlunosController(AlunoService alunoService, ModalidadesService modalidadesServices, IMapper mapper)
        {
            _AlunoService = alunoService;
            _ModalidadesService = modalidadesServices;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _AlunoService.FindAllAsync();
            return View(list);
        }

        public async Task <IActionResult> NovoAluno()
        {
            var modalidades = await _ModalidadesService.FindAllAsync();
            ViewBag.Modalidades = new MultiSelectList(modalidades, "ID", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(AlunosFormViewModel aluno)
        {
            await _AlunoService.Insert(aluno);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Deletar(int? ID)
        {
            if(ID == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não informado" });
            }
            var obj = await _AlunoService.FindByIdAsync(ID.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletar(int ID)
        {
            await _AlunoService.RemoveAsync(ID);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detalhes(int? ID)
        {
            if (ID == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não informado" });
            }
            var obj = await _AlunoService.FindByIdAsync(ID.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não informado"});
            }
            var obj = await _AlunoService.FindByIdAsync(id.Value);
                if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }
            List<Modalidades> modalidades = await _ModalidadesService.FindAllAsync();
            AlunosFormViewModel viewModel = _mapper.Map<AlunosFormViewModel>(obj);
            ViewBag.Modalidades = new SelectList(modalidades, "ID", "Name");
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar (AlunosFormViewModel aluno)
        {
            try
            {
                await _AlunoService.UpdateAsync(aluno);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            
        }
        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }


        public async Task<IActionResult> Pagamento(int ID)
        {
            var obj = await _AlunoService.FindByIdAsync(ID);
            await _AlunoService.AdicionaPagamentoAsync(obj);
            return View(obj);
        }

        public async Task<IActionResult> DeletaPagamento(int id)
        {
            int retorno = _AlunoService.PesquisaPagamento(id);
            await _AlunoService.DeletaPagamentoAsync(id);
            var obj = await _AlunoService.FindByIdAsync(retorno);
            return View(obj);
        }
    }
}

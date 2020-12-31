using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicacao_Kolping.Services;
using Aplicacao_Kolping.Models;
using Aplicacao_Kolping.Services.Exceptions;
using System.Diagnostics;

namespace Aplicacao_Kolping.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AlunoService _AlunoService;
        private readonly ModalidadesService _ModalidadesService;

        public AlunosController(AlunoService alunoService, ModalidadesService modalidadesServices)
        {
            _AlunoService = alunoService;
            _ModalidadesService = modalidadesServices;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _AlunoService.FindAllAsync();
            return View(list);
        }

        public async Task <IActionResult> NovoAluno()
        {
            var modalidades = await _ModalidadesService.FindAllAsync();
            var viewModel = new AlunosFormViewModel { Modalidades = modalidades };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(Alunos aluno)
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
            AlunosFormViewModel viewModel = new AlunosFormViewModel { Aluno = obj, Modalidades = modalidades };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar (int id, Alunos aluno)
        {
            if(id != aluno.ID)
            {
                return RedirectToAction(nameof(Error), new { message = "Ids não correspondem" });
            }
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
    }
}

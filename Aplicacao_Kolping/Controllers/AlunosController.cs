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

        public IActionResult Index()
        {
            var list = _AlunoService.FindAll();
            return View(list);
        }

        public IActionResult NovoAluno()
        {
            var modalidades = _ModalidadesService.FindAll();
            var viewModel = new AlunosFormViewModel { Modalidades = modalidades };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Alunos aluno)
        {
            _AlunoService.Insert(aluno);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int? ID)
        {
            if(ID == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não informado" });
            }
            var obj = _AlunoService.FindById(ID.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }
            return View(obj);
        }
        public IActionResult Detalhes(int? ID)
        {
            if (ID == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não informado" });
            }
            var obj = _AlunoService.FindById(ID.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }
            return View(obj);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não informado"});
            }
            var obj = _AlunoService.FindById(id.Value);
                if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }
            List<Modalidades> modalidades = _ModalidadesService.FindAll();
            AlunosFormViewModel viewModel = new AlunosFormViewModel { Aluno = obj, Modalidades = modalidades };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar (int id, Alunos aluno)
        {
            if(id != aluno.ID)
            {
                return RedirectToAction(nameof(Error), new { message = "Ids não correspondem" });
            }
            try
            {
                _AlunoService.Update(aluno);
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

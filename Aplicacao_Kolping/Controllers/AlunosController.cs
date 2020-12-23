using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicacao_Kolping.Services;
using Aplicacao_Kolping.Models;

namespace Aplicacao_Kolping.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AlunoService _AlunoService;

        public AlunosController(AlunoService alunoService)
        {
            _AlunoService = alunoService;
        }

        public IActionResult Index()
        {
            var list = _AlunoService.FindAll();
            return View(list);
        }

        public IActionResult NovoAluno()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Alunos aluno)
        {
            _AlunoService.Insert(aluno);
            return RedirectToAction(nameof(Index));
        }
    }
}

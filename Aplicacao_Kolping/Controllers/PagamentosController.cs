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
    public class PagamentosController : Controller
    {
        private readonly AlunoService _AlunoService;
        private readonly ModalidadesService _ModalidadesService;
        private readonly PagamentoService _PagamentoService;

        public PagamentosController(AlunoService alunoService, ModalidadesService modalidadesServices, PagamentoService pagamentoService)
        {
            _AlunoService = alunoService;
            _ModalidadesService = modalidadesServices;
            _PagamentoService = pagamentoService;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

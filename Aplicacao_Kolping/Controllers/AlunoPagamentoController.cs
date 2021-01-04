using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicacao_Kolping.Services;
using Aplicacao_Kolping.Data;
using Aplicacao_Kolping.Models;

namespace Aplicacao_Kolping.Controllers
{
   
    public class AlunoPagamentoController : Controller
    {
        private readonly AlunoPagamentoService _alunoPagamentoService;
        

        public AlunoPagamentoController(AlunoPagamentoService alunoPagamentoService)
        {
            _alunoPagamentoService = alunoPagamentoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SimpleSearch( DateTime? minDate, DateTime? maxDate)
        {
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}

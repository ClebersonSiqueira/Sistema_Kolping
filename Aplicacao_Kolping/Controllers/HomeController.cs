using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicacao_Kolping.Models;

namespace Aplicacao_Kolping.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Kolping São Lucas";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Em casos de erros, favor entrar em contato pelo whatsapp no numero";
            ViewData["ContatoTelefone"] = "011 9 5950 0263";
            ViewData["ContatoNome"] = "Cleberson Siqueira";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

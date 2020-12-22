using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicacao_Kolping.Models;

namespace Aplicacao_Kolping.Controllers
{
    public class ModalidadesController : Controller
    {
        public IActionResult Index()
        {
            List<Modalidades> list = new List<Modalidades>();
            list.Add(new Modalidades { ID = 1, Name = "Karate Cobra Kai", Preco = 30.0 });
            list.Add(new Modalidades { ID = 2, Name = "Hapikdo", Preco = 40.0 });
            return View(list);
        }
    }
}

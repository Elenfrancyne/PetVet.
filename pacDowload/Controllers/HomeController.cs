using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aula3UC05.Models;

namespace aula3UC05.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger){
            _logger = logger;
        }

        public IActionResult Index(){
            return View();
        }
        public IActionResult Servicos(){
            return View();
        }
        public IActionResult Agendamento(){
            return View();
        }
        [HttpPost]
        public IActionResult Agendamento(ItemAgenda item){
            Agenda.Incluir (item);
            return RedirectToAction("Listagem");
        }
        public IActionResult Listagem (){
            List<ItemAgenda> lista = Agenda.Listar();
            return View (lista);
        }
        public IActionResult Privacy(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

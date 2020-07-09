using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AulaAspnet.Models;

namespace AulaAspnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Teste = "Teste ViewBag SENAI ";
            ViewBag.Teste1 = "Nesta atividade, crie o mesmo exemplo dado em aula e faça alguma modificação considerável no css e traduza os textos em html da página de Privacidade. Printe o resultado e envie junto com o link do repositóri";
            ViewBag.TesteInt = "Aula 35";
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

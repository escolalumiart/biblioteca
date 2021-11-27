using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EscolaLumiart.Models;

namespace EscolaLumiart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Beneficios()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "APASP - Associação Paulista dos Servidores Públicos.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "APASP - Associação Paulista dos Servidores Públicos.";

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

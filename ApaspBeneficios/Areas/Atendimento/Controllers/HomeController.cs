using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApaspBeneficios.Areas.Atendimento.Controllers
{
    [Area("Atendimento")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
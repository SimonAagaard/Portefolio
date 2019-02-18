using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portefolio.Models;

namespace Portefolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Om projektet";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Kontaktside";

            return View();
        }
        public IActionResult Log()
        {
            ViewData["Message"] = "Projektlog";

            return View();
        }
        public IActionResult Plan()
        {
            ViewData["Message"] = "Læringsplan";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

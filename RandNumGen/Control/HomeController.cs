using Microsoft.AspNetCore.Mvc;
using RandNumGen.Model;

namespace RandNumGen.Control
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Generator generator = new Generator();
            ViewBag.Cislo = generator.vratCislo();
            return View();
        }
    }
}

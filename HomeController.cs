using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VizeFinalWebApplication.Models;

namespace VizeFinalWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(VizeFinal vizefinal)
        {
            var vn = vizefinal.VizeNot;
            var fn = vizefinal.FinalNot;
            var ortalama = (vn * 30) / 100 + (fn * 70) / 100;
            var message = string.Empty;
            if (ortalama >= 50 && fn>=50)
            {
                message = ortalama + " ile geçtiniz.";
            }
            else 
            {
                message = ortalama + " ile kaldınız.";

            }

            ViewBag.Message = message;
            return View("vizefinal");
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
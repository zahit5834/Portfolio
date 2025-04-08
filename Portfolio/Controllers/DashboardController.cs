using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Grafik";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "Grafik";
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

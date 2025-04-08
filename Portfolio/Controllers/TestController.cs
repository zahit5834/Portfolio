using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Güncelle";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Güncelle";
            var values = am.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About p)
        {
            am.TUpdate(p);
            return RedirectToAction("Index", "Default");
        }
    }
}

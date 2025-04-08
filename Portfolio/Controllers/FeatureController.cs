using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager fm = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Güncelle";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Güncelle";
            var values = fm.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature p)
        {
            fm.TUpdate(p);
            return RedirectToAction("Index","Default");
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager exm = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Listele";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Listele";
            var values = exm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Ekle";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            exm.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = exm.TGetByID(id);
            exm.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Güncelle";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Güncelle";
            var value = exm.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            exm.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}

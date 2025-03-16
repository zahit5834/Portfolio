using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {
        SkillManager sm = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Listele";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Listele";
            var values = sm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1= "Ekle";
            ViewBag.v2= "Yetenekler";
            ViewBag.v3= "Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            sm.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var value = sm.TGetByID(id);
            sm.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Güncelle";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Güncelle";
            var value = sm.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            sm.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}

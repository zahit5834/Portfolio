using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager sm = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Listele";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Listele";
            var values = sm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Ekle";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service p)
        {
            sm.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var value = sm.TGetByID(id);
            sm.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Güncelle";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Güncelle";
            var value = sm.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditService(Service p)
        {
            sm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}

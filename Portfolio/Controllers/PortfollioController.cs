using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class PortfollioController : Controller
    {
        PortfollioManager  pm = new PortfollioManager(new EfPortfollioDal());
        PortfollioValidator pv = new PortfollioValidator();
        public IActionResult Index()
        {
            ViewBag.v1 = "Listele";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Listele";
            var values = pm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfollio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfollio(Portfollio p)
        {
            ViewBag.v1 = "Ekle";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Ekle";

            
            ValidationResult results = pv.Validate(p);
            if (results.IsValid)
            {
                pm.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            } 
            return View();
        }
        public IActionResult DeletePortfollio(int id)
        {
            var value = pm.TGetByID(id);
            pm.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfollio(int id)
        {
            ViewBag.v1 = "Güncelle";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Güncelle";
            var value = pm.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditPortfollio(Portfollio p)
        {
            ValidationResult results = pv.Validate(p);
            if (results.IsValid)
            {
                pm.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}

﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Portfolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity?.Name == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;
            // Wheather Api

            string api = "7f4f9f009fa04d71bd4830b7278dd595";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            // İstatistikler

            Context c = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.Skills.Count();

            return View();
        }
    }
}
/*
 * https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=7f4f9f009fa04d71bd4830b7278dd595
 */
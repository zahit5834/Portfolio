﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager em = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = em.TGetList();
            return View(values);
        }
    }
}

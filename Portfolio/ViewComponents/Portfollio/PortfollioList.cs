using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Portfollio
{
    public class PortfollioList : ViewComponent
    {
        PortfollioManager pm = new PortfollioManager(new EfPortfollioDal());
        public IViewComponentResult Invoke()
        {
            var values = pm.TGetList();
            return View(values);
        }
    }
}
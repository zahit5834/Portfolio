using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementManager am = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = am.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}

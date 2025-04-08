using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager am= new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = am.TGetList();
            return View(values);
        }
        public IActionResult AnnouncementDetails(int id)
        {
            var values = am.TGetByID(id);
            return View(values);
        }
    }
}

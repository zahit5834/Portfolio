using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}

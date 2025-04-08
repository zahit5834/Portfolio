using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Dashboard
{
    public class Last5Project : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}

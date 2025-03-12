using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace Portfolio.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager fm = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = fm.TGetList();
            return View(values);
        }
    }
}

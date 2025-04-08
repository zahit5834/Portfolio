using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Dashboard
{
    public class TodoListPanel : ViewComponent
    {
        TodoListManager tdm = new TodoListManager(new EfTodoListDal());
        public IViewComponentResult Invoke()
        {
            var values = tdm.TGetList();
            return View(values);
        }
    }
}

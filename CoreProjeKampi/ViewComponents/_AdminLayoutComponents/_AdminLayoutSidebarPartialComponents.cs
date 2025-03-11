using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._AdminLayoutComponents
{
    public class _AdminLayoutSidebarPartialComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

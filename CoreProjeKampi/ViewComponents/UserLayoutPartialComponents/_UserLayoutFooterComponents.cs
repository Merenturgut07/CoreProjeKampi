using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents.UserLayoutPartialComponents
{
    public class _UserLayoutFooterComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

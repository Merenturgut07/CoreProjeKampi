using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents.UserLayoutPartialComponents
{
    public class _UserLayoutNavbarComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

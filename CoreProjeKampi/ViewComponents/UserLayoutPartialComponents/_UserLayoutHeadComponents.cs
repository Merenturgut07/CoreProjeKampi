using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents.UserLayoutPartialComponents
{
    public class _UserLayoutHeadComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents.UserLayoutPartialComponents
{
    public class _UserLayoutSignInRegisterComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

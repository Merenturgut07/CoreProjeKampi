using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._WriterLayoutComponents
{
    public class _WriterLayoutHeadComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

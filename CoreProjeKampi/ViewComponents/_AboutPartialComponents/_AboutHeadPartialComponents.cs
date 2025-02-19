using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._AboutPartialComponents
{
    public class _AboutHeadPartialComponents:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutHeadPartialComponents(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_aboutService.TGetListAll();
            return View(values);
        }
    }
}

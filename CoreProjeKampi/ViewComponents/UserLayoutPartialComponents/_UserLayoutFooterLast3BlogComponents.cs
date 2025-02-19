using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents.UserLayoutPartialComponents
{
    public class _UserLayoutFooterLast3BlogComponents:ViewComponent
    {
        private readonly IBlogService _blogService;

        public _UserLayoutFooterLast3BlogComponents(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_blogService.TGetListAll().OrderByDescending(x=>x.BlogId).Take(3).ToList();
            return View(values);
        }
    }
}

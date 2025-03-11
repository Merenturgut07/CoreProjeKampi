using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._WriterDashboardComponents
{
    public class _WriterDashboardBlogListComponents:ViewComponent
    {
        private readonly IBlogService _blogService;

        public _WriterDashboardBlogListComponents(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogService.GetBlogListWithCategory();
            return View(values);
        }
    }
}

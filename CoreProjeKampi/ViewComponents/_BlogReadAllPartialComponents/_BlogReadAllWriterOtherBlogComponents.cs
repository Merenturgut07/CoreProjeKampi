using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._BlogReadAllPartialComponents
{
    public class _BlogReadAllWriterOtherBlogComponents:ViewComponent
    {
        private readonly IBlogService _blogService;

        public _BlogReadAllWriterOtherBlogComponents(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogService.GetBlogListByWriter(1);
            return View(values);
        }
    }
}

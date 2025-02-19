using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._BlogReadAllPartialComponents
{
    public class _BlogReadAllBlogComponents:ViewComponent
    {
        private readonly IBlogService _blogService;

        public _BlogReadAllBlogComponents(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _blogService.TGetById(id);
            return View(values);
        }
    }
}

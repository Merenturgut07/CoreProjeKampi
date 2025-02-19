using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._BlogReadAllPartialComponents
{
    public class _BlogReadAllCommentListByBlogComponents:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _BlogReadAllCommentListByBlogComponents(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.GetListAll(id);
            return View(values);

        }
    }
}

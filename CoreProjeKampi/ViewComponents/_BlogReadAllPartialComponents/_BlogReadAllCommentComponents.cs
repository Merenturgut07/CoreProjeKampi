using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._BlogReadAllPartialComponents
{
    public class _BlogReadAllCommentComponents:ViewComponent
    {
        //private readonly ICommentService _commentService;

        //public _BlogReadAllCommentComponents(ICommentService commentService)
        //{
        //    _commentService = commentService;
        //}

        public IViewComponentResult Invoke()
        {
            //var values = _commentService.GetListAll(id);
            return View();

        }
    }
}

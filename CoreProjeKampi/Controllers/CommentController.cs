using BussinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogId = 2;
            _commentService.TInsert(comment);
            return RedirectToAction("Index","Blog");
        }

    }
}

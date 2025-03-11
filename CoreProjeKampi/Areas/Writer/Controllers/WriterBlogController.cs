using BussinessLayer.Abstract;
using BussinessLayer.Concrate;
using BussinessLayer.ValidationRules;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreProjeKampi.Areas.Writer.Controllers
{

    [Area("Writer")]
    [Route("Writer/[controller]/[action]/{id?}")]
    [AllowAnonymous]
    public class WriterBlogController : Controller
    {
        Context c = new Context();
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private readonly IBlogService _blogService;

        public WriterBlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();
            var values = _blogService.GetBlogListByWriter(writerId);
            return View(values);
        }

        public IActionResult BlogDelete(int id)
        {
            _blogService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalues = (from x in cm.TGetListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();

            BlogValidator validationRules = new BlogValidator();
            ValidationResult result = validationRules.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterId = writerId;
                _blogService.TInsert(blog);
                return RedirectToAction("Index", "WriterBlog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }


        [HttpGet]
        public IActionResult BlogUpdate(int id)
        {
            var values = _blogService.TGetById(id);

            List<SelectListItem> categoryvalues = (from x in cm.TGetListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View(values);
        }

        [HttpPost]
        public IActionResult BlogUpdate(Blog blog)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();
            blog.WriterId = writerId;
            blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            blog.BlogStatus = true;
            _blogService.TUpdate(blog);
            return RedirectToAction("Index");
        }
    }
}

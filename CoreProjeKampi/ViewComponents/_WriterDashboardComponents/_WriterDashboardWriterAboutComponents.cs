using BussinessLayer.Abstract;
using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._WriterDashboardComponents
{
    public class _WriterDashboardWriterAboutComponents:ViewComponent
    {
        Context c = new Context();
        private readonly IWriterService _writerService;

        public _WriterDashboardWriterAboutComponents(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IViewComponentResult Invoke()
        {
            var username=User.Identity.Name;
            ViewBag.veri=username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId=c.writers.Where(x=>x.WriterMail==usermail).Select(y=>y.WriterId).FirstOrDefault();
            var values = _writerService.GetWriterById(writerId);
            return View(values);
        }
    }
}

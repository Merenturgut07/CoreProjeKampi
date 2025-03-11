using BussinessLayer.Abstract;
using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._WriterLayoutComponents
{
    public class _WriterLayoutNavbarMessageComponents : ViewComponent
    {
        Context c=new Context();
        private readonly IMessage2Service _message2Service;

        public _WriterLayoutNavbarMessageComponents(IMessage2Service message2Service)
        {
            _message2Service = message2Service;
        }

        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();
            var values = _message2Service.GetInboxListByWriter(writerId);
            return View(values);
        }
    }
}

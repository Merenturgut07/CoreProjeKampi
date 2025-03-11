using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._WriterDashboardComponents
{
    public class _WriterDashboardStatisticsComponents : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            ViewBag.veri = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerid = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();

            ViewBag.v1 = c.blogs.Count().ToString();
            ViewBag.v2 = c.blogs.Where(x => x.WriterId == writerid).Count().ToString();
            ViewBag.v3 = c.categories.Count().ToString();
            return View();
        }
    }
}

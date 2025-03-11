using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.Areas.Admin.ViewComponents._AdminStatistikComponents
{
    public class _AdminStatistic4PartialComponents : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.admins.Where(x => x.AdminId == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = c.admins.Where(x => x.AdminId == 1).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.v3 = c.admins.Where(x => x.AdminId == 1).Select(y => y.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}

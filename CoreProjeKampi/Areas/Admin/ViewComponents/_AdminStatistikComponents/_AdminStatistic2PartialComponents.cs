using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.Areas.Admin.ViewComponents._AdminStatistikComponents
{
    public class _AdminStatistic2PartialComponents:ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=c.blogs.OrderByDescending(x=>x.BlogId).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}

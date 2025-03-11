using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CoreProjeKampi.Areas.Admin.ViewComponents._AdminStatistikComponents
{
    public class _AdminStatisticPartialComponents:ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.blogs.Count().ToString();
            ViewBag.v2 = c.contacts.Count().ToString();
            ViewBag.v3 = c.comments.Count().ToString();

            string api = "79dbc22f9cfe41e1db0958e0eef87f8e";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=%C4%B0stanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}

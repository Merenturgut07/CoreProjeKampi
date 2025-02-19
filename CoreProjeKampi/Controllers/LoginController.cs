using BussinessLayer.Abstract;
using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreProjeKampi.Controllers
{

    public class LoginController : Controller
    {

        [AllowAnonymous]

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context c = new Context();
            var values = c.writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (values != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.WriterMail)
                };

                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }

        }
    }
}
//Context c = new Context();
//var value = c.writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
//if (value != null)
//{
//    HttpContext.Session.SetString("username", writer.WriterMail);
//    return RedirectToAction("Index", "Blog");
//}
//else
//{
//    return View();
//}
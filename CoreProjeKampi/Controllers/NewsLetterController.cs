using BussinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.Controllers
{
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {
        private readonly INewsLetterService _newsLetterService;

        public NewsLetterController(INewsLetterService newsLetterService)
        {
            _newsLetterService = newsLetterService;
        }


        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            _newsLetterService.TInsert(p);
            return PartialView();
        }
    }
}

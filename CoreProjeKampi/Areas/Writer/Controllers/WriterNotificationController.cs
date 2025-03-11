using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]/{id?}")]
    [AllowAnonymous]
    public class WriterNotificationController : Controller
    {
        private readonly INotificationService _notificationService;

        public WriterNotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllNotification()
        {
            var values = _notificationService.TGetListAll();
            return View(values);
        }
    }
}

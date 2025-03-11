using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._WriterLayoutComponents
{
    public class _WriterLayoutNotificationComponents:ViewComponent
    {
        private readonly INotificationService _notificationService;

        public _WriterLayoutNotificationComponents(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _notificationService.TGetListAll();
            return View(values);
        }
    }
}

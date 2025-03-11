using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.Areas.Writer.Controllers
{
    public class WriterDashboardController : Controller
    {
        [Area("Writer")]
        [Route("Writer/[controller]/[action]/{id?}")]
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
    }
}

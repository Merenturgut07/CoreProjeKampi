using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.Areas.Writer.Controllers
{
    [Area("Writer")]
    //[Route("Writer/[controller]/[action]/{id?}")]
    public class WriterProfileController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}

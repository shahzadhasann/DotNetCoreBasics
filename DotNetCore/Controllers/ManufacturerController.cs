using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class ManufacturerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

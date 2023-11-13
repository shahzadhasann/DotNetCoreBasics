using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CovidVisual.Controllers
{
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

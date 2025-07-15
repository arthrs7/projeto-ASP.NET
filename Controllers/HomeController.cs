using Microsoft.AspNetCore.Mvc;

namespace meu_app_aspnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
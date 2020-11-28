using Microsoft.AspNetCore.Mvc;

namespace CustomTemplateTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["WelcomeMessage"] = _localizer["WelcomeMessage"];
            ViewData["Description"] = _localizer["Description"];
            return View();
        }
    }
}

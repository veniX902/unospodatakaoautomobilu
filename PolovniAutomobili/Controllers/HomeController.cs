using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using PolovniAutomobili.Models;
using System.Diagnostics;

namespace PolovniAutomobili.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IStringLocalizer<SharedResource> localizer;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<SharedResource> localizer)
        {
            this.localizer = localizer;
        }

       

        public IActionResult Index()
        {
            string firstNameText = this.localizer["Engine"].Value;
            return View();
        }

        public IActionResult SetCulture(string culture, string sourceUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return Redirect(sourceUrl);
        }


        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string carName = "DefaultName")
        {

            Attendance.AddAttendant(carName);
            TempData["carName"] = carName;
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

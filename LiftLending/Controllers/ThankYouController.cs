using LiftLending.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LiftLending.Controllers
{
    public class ThankYouController : Controller
    {
        private readonly ILogger<ThankYouController> _logger;

        public ThankYouController(ILogger<ThankYouController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Displays the Thank You page with the client's name if available.
        /// </summary>
        /// <returns>An IActionResult that renders the Thank You view.</returns>
        [HttpGet]
        public IActionResult Index()
        {
            // display of name on page
            var firstName = TempData["FirstName"] as string;
            ViewBag.FirstName = firstName?.ToUpper();
            if (ViewBag.FirstName == null)
            {
                ViewBag.FirstName = "CLIENT";
            }

            return View();
        }

        /// <summary>
        /// Displays the error page with the details of the current request.
        /// </summary>
        /// <returns>An IActionResult that renders the error view with the request details.</returns>
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogError("{HttpContextTraceIdentifier}", Activity.Current?.Id ?? HttpContext.TraceIdentifier);
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

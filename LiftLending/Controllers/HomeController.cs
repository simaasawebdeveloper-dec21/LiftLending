using LiftLending.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LiftLending.Models;
using Microsoft.EntityFrameworkCore;

namespace LiftLending.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NextSlide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HandleSelection([FromBody] string selection)
        {
            // Process the selection (e.g., save to database)
            return Json(new { success = true, message = "Selection received: " + selection });
        }
            [HttpPost]
            public IActionResult SaveData(string name, string contact)
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contact))
                {
                    return BadRequest("Invalid data.");
                }

                // Save data to the database (example using Entity Framework Core)
               
                    var userData = new UserData { Name = name, Contact = contact };
                    _context.UserData.Add(userData);
                    _context.SaveChanges();
             
                // Redirect to a new page with the user's name
                return RedirectToAction("Welcome", new { userName = name });
            }

            public IActionResult Welcome(string userName)
            {
                // Pass the user's name to the view
                ViewBag.UserName = userName;
                return View();
            }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

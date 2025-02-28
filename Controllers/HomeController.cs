using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using my_mvc_app.Models; // Add this line if AccountViewModel is in the Models namespace

namespace my_mvc_app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }

    
}
using GreeterAndRandomNumberGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreeterAndRandomNumberGame.Controllers
{
    public class GreetingController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(new GreetingViewModel());
        }

        [HttpPost]
        public IActionResult Index(GreetingViewModel model)
        {
            return View(model);
        }
    }
}
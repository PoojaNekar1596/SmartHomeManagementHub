using Microsoft.AspNetCore.Mvc;
using SmartHomeManagementHub.Web.Models;

namespace SmartHomeManagementHub.Web.Controllers
{
    public class DailyChoresController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DailyChores dailyChores)
        {
            if (!ModelState.IsValid)
            {
                return View(dailyChores);
            }

            return View(dailyChores);
        }
    }
}

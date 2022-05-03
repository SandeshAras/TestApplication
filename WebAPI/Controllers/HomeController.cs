using Microsoft.AspNetCore.Mvc;
using TestApplication.Models;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Index(Details detail)
        {
            return View();
        }
    }
}

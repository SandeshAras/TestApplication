using Microsoft.AspNetCore.Mvc;
using TestApplication.Models;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Index([FromBody]Details detail)
        {
            return StatusCode(StatusCodes.Status201Created, detail);
        }
    }
}

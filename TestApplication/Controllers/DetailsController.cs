using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class DetailsController : Controller
    {
        HttpClient client;
        Uri baseaddress;
        IConfiguration _configuration;
        public DetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
            baseaddress = new Uri(_configuration["ApiAddress"]);
            client = new HttpClient();
            client.BaseAddress = baseaddress;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Details detail)
        {
            string data = JsonSerializer.Serialize(detail);
            StringContent content = new StringContent(data, Encoding.UTF8,"application/json");
            var response = client.PostAsync(client.BaseAddress+"/Home",content).Result;
            return View(response);
        }
    }
}

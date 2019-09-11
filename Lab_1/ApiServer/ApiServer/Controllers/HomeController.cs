using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
             return File("html/hack.txt", "text/html");
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    public class HackController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return File("html/index.html", "text/html");
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsume.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

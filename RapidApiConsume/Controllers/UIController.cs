using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsume.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

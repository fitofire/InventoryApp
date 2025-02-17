using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

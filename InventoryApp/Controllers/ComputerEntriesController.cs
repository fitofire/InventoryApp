using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class ComputerEntriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

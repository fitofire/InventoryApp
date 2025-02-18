using InventoryApp.Data;
using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class ComputerEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ComputerEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<ComputerEntry> computerEntries = _db.ComputerEntries.ToList();
            return View(computerEntries);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

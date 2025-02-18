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

        [HttpPost]
        public IActionResult Create(ComputerEntry obj)
        {
            _db.ComputerEntries.Add(obj);  // Adds the new computer to the database
            _db.SaveChanges();    // saves the changes to the database
            return RedirectToAction("Index");  
        }
    }
}

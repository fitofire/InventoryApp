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
        public IActionResult Create(ComputerEntry computerEntry)
        {
            if (computerEntry != null && computerEntry.SerialName.Length < 5)
            {
                ModelState.AddModelError("SerialName", "Serial Name must be at least 5 characters long.");
            }
            if (ModelState.IsValid)
            {
                _db.ComputerEntries.Add(computerEntry);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(computerEntry);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            ComputerEntry? computerEntry = _db.ComputerEntries.Find(id);

            if (computerEntry == null)
            {
                return NotFound();
            }
            return View(computerEntry);
        }
    }
}

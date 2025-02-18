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
            if (obj != null && obj.SerialName.Length < 5)
            {
                ModelState.AddModelError("SerialName", "Serial Name must be at least 5 characters long.");
            }
            if (ModelState.IsValid)
            {
                _db.ComputerEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
}

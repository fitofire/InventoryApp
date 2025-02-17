using InventoryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace InventoryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<ComputerEntry> ComputerEntries { get; set; }
    }
}

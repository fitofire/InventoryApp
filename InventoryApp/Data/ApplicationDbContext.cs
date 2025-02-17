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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ComputerEntry>().HasData(
                    new ComputerEntry
                    {
                        Id = 1,
                        AssetTag = "ELXL-RJBFPV2",
                        SerialName = "RJBFPV2",
                        Manufacturer = "Dell",
                        Model = "5490",
                        PurchaseDate = new DateTime(2020,2,13),
                        WarrantyExp = new DateTime(2024,9,13),
                        Location = "Tech Room",
                        CurrentUser = "IT",
                        Status = "Decommissioned",
                        LastUpdated = new DateTime(2024,10,26)
                    },
                    new ComputerEntry
                    {
                        Id = 2,
                        AssetTag = "ELXL-DFSFPV2",
                        SerialName = "DFSFPV2",
                        Manufacturer = "Dell",
                        Model = "5490",
                        PurchaseDate = new DateTime(2020,2,13),
                        WarrantyExp = new DateTime(2024,9,13),
                        Location = "Tech Room",
                        CurrentUser = "IT",
                        Status = "Decommissioned",
                        LastUpdated = new DateTime(2024,10,26)
                    },
                    new ComputerEntry
                    {
                        Id = 3,
                        AssetTag = "ELXL-RKLFPV2",
                        SerialName = "DFSFPV2",
                        Manufacturer = "Dell",
                        Model = "5490",
                        PurchaseDate = new DateTime(2020,2,13),
                        WarrantyExp = new DateTime(2024,9,13),
                        Location = "Tech Room",
                        CurrentUser = "IT",
                        Status = "Decommissioned",
                        LastUpdated = new DateTime(2024,10,26)
                    }
                );

        }
    }
}

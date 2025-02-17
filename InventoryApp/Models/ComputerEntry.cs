using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public class ComputerEntry
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string AssetTag { get; set; } = string.Empty;

        [Required,StringLength(50)]
        public string SerialName { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Manufacturer { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Model { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? WarrantyExp { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }

        [StringLength(100)]
        public string? CurrentUser { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } = "Active";

        [DataType(DataType.DateTime)]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

    }
}

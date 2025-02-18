using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public class ComputerEntry
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter an Asset Tag")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Asset Tag must be between 5 and 15 characters.")]
        public string AssetTag { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an Serial Number")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Serial must be between 5 and 15 characters.")]
        public string SerialName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Manufacturer")]
        [StringLength(50)]
        public string Manufacturer { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Model")]
        [StringLength(50)]
        public string Model { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? WarrantyExp { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }

        [StringLength(100)]
        public string? CurrentUser { get; set; }

        [Required(ErrorMessage = "Please enter a status")]
        [StringLength(50)]
        public string Status { get; set; } = "Active";

        [DataType(DataType.DateTime)]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        // Add a read-only property named Slug
        public string Slug => (SerialName?.Length > 8 ? SerialName.Substring(0, 8) : SerialName)?.Replace(' ', '-').ToLower()
            + "-" + (Manufacturer?.Length > 5 ? Manufacturer.Substring(0, 5) : Manufacturer)?.Replace(' ', '-').ToLower();

    }
}

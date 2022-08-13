using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Item
    {
        public int itemID { get; set; }
        [Required]
        [StringLength(100)]
        public string itemName { get; set; } = default!;
        [Required]
        public string itemDescription { get; set; } = default!;
        [Required]
        [DataType(DataType.Currency)]
        public double price { get; set; }
        public Listing listingHost { get; set; } = default!;
        [Required]
        public int quantity { get; set; }

    }
}
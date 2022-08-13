using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Listing
    {
        public int listingID { get; set; }
        [Required]
        [StringLength(50)]
        public string listingName { get; set; } = default!;
        [Required]
        public User listingAuthor { get; set; } = default!;
        [Required]
        public List<Item> listingItems { get; set; } = default!;
        public List<Report>? listingReports { get; set; } = default!;
    }
}

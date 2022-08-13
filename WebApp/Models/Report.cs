using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Report
    {
        public int reportID { get; set; }
        [Required]
        public User reportSentBy { get; set; } = default!;
        [DataType(DataType.DateTime)]
        public DateTime reportDate { get; set; } = DateTime.Now;
        [Required]
        public string reportDetails { get; set; } = default!;
    }
}
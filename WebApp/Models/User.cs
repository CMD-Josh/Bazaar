using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class User
    {
        public int userID { get; set; }
        [Required]
        [StringLength(30)]
        public string userName { get; set; } = default!;
        [DataType(DataType.DateTime)]
        public DateTime creationDate { get; set; } = DateTime.Now;
        public List<User>? contacts { get; set; } = default!;
        public string? image { get; set; }
        [Required]
        public Account accountID { get; set; } = default!;
        public int reputation { get; set; } = 0;
    }
}
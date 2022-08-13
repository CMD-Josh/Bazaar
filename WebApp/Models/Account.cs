using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Account
    {
        public int accountID { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }
        [Required]
        public string role { get; set; }
    }
}

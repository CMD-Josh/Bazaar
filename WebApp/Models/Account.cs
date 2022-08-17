using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Account
    {
        public enum Role{
            User, Admin
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Type { get; set; }
    }
}

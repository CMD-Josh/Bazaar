using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int Reputation { get; set; }
        public string Avatar { get; set; }

        [ForeignKey("AccountId")]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
        public virtual List<Listing> Listings { get; set; }
        public virtual List<Report> Reports { get; set; }
        public virtual List<User>? Contacts { get; set; }
    }
}

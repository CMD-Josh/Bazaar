namespace WebApp.Models
{
    public class Listing
    {
        public enum ListingType
        {
            Auction, Continuous
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ListingType Type { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;

        public virtual User Author { get; set; }
        public virtual List<Item> Items { get; set; }
        public virtual List<Report>? Reports { get; set; }

    }
}

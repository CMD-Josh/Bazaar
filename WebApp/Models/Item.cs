namespace WebApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemDesc { get; set; }
        public double Price { get; set; }

        public virtual Listing Listing { get; set; }
    }
}

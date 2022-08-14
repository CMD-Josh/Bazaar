namespace WebApp.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public string ReportDetails { get; set; }

        public virtual User? UserReported { get; set; }
        public virtual Listing? ListingReported { get; set; }
    }
}

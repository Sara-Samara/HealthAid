namespace HealthAidAPI.Models
{
    public class PublicAlert
    {
        public int AlertId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Region { get; set; }
        public string AlertType { get; set; }
        public DateTime DatePosted { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}

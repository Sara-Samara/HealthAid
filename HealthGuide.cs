namespace HealthAidAPI.Models
{
    public class HealthGuide
    {
        public int GuideId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public string Language { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}

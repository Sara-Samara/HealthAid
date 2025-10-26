namespace HealthAidAPI.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public string TargetType { get; set; }
        public int TargetId { get; set; }
        public int Value { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

    }
}

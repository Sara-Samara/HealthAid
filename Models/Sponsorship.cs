namespace HealthAidAPI.Models
{
    public class Sponsorship
    {
        public int SponsorshipId { get; set; }
        public string GoalDescription { get; set; }
        public decimal GoalAmount { get; set; }
        public decimal AmountRaised { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public int? PatientId { get; set; }
        public Patient Patient { get; set; }

      // public ICollection<Donation> Donations { get; set; }
    }
}

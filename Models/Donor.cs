namespace HealthAidAPI.Models
{
    public class Donor
    {

        public int DonorId { get; set; }
        public string Organization { get; set; }
        public decimal TotalDonated { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        //public ICollection<Donation> Donations { get; set; }
    }
}

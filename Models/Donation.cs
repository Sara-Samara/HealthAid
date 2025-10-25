namespace HealthAidAPI.Models
{
    public class Donation
    {

        public int DonationId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateDonated { get; set; }
        public string PaymentMethod { get; set; }

        public int? SponsorshipId { get; set; }
        public Sponsorship Sponsorship { get; set; }

        public int? DonorId { get; set; }
        //public Donor Donor { get; set; }

        //public ICollection<Transaction> Transactions { get; set; }
    }
}

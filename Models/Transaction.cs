namespace HealthAidAPI.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }


        public int? ConsultationId { get; set; }
        public Consultation Consultation { get; set; }


        public int? DonationId { get; set; }
        //public Donation Donation { get; set; }


        public int? RequestId { get; set; }
        //public MedicineRequest MedicineRequest { get; set; }


        public int? UserId { get; set; }
        public User User { get; set; }
    }
}

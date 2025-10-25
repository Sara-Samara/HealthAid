namespace HealthAidAPI.Models
{
    public class MedicineRequest
    {
        public int MedicineRequestId { get; set; }
        public string MedicineName { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }


        public int? PatientId { get; set; }
        public Patient Patient { get; set; }


        public Transaction Transaction { get; set; }
    }
}

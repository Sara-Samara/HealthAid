namespace HealthAidAPI.Models
{
    public class MentalSupportSession
    {
        public int SessionId { get; set; }
        public string SessionType { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public int? PatientId { get; set; }
        public Patient Patient { get; set; }

        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}

namespace HealthAidAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string MedicalHistory { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string BloodType { get; set; }


        // FK to User (1:1)
        public int? UserId { get; set; }
        public User User { get; set; }


        // optional link to NGO
        public int? NgosId { get; set; }
        //public NGO NGO { get; set; }


        // Navigation
        //public ICollection<Consultation> Consultations { get; set; }
        //public ICollection<Appointment> Appointments { get; set; }
        //public ICollection<MedicineRequest> MedicineRequests { get; set; }
        //public ICollection<Sponsorship> Sponsorships { get; set; }
        //public ICollection<MentalSupportSession> MentalSupportSessions { get; set; }
    }
}

namespace HealthAidAPI.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Specialization { get; set; }
        public int YearsExperience { get; set; }
        public string Bio { get; set; }
        public string LicenseNumber { get; set; }
        public string AvailableHours { get; set; }


        // FK to User (1:1)
        public int UserId { get; set; }
        public User User { get; set; }


        // Navigation
        //public ICollection<Consultation> Consultations { get; set; }
        //public ICollection<MentalSupportSession> MentalSupportSessions { get; set; }
        //public ICollection<Appointment> Appointments { get; set; }
    }
}

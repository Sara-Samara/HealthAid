namespace HealthAidAPI.Models
{
    public class Consultation
    {
        public int ConsultationId { get; set; }
        public DateTime? ConsDate { get; set; }
        public string Diagnosis { get; set; }
        public string Status { get; set; }
        public string Mode { get; set; }
        public string Note { get; set; }


        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }


        public int? PatientId { get; set; }
        public Patient Patient { get; set; }


        public int? AppointmentId { get; set; }
        public Appointment Appointment { get; set; }


        //public ICollection<Prescription> Prescriptions { get; set; }
        //public ICollection<Transaction> Transactions { get; set; }
    }
}

namespace HealthAidAPI.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public string MedicineName { get; set; }
        public string Dosages { get; set; }
        public string Duration { get; set; }


        public int ConsultationId { get; set; }
        public Consultation Consultation { get; set; }
    }
}

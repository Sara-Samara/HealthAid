namespace HealthAidAPI.Models
{
    public class NGO
    {
        public int NgosId { get; set; }
        public string OrganizationName { get; set; }
        public string AreaOfWork { get; set; }
        public string VerifiedStatus { get; set; }
        public string ContactedPerson { get; set; }

       // public ICollection<NgoMession> NgoMessions { get; set; }
       // public ICollection<Equipment> Equipments { get; set; }
       // public ICollection<Patient> Patients { get; set; }
    }
}

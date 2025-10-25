namespace HealthAidAPI.Models
{
    public class NgoMession
    {
        public int MessionId { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Location { get; set; }

        public int? NgosId { get; set; }
        //public NGO NGO { get; set; }
    }
}

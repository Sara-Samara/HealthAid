namespace HealthAidAPI.Models
{
    public class Equipment
    {

        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string CurrentLocation { get; set; }
        public string AvailableStatus { get; set; }

        public int? NgosId { get; set; }
        public NGO NGO { get; set; }

    }
}

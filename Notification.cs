namespace HealthAidAPI.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }

        public int? SenderId { get; set; }
        public User Sender { get; set; }

        public int? ReceiverId { get; set; }
        public User Receiver { get; set; }
    }
}

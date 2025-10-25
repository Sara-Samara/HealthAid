using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Numerics;

namespace HealthAidAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation
        public Doctor Doctor { get; set; }
        //public Patient Patient { get; set; }
        //public Donor Donor { get; set; }
        //public ICollection<Transaction> Transactions { get; set; }
        //public ICollection<HealthGuide> HealthGuides { get; set; }
        //public ICollection<Notification> SentNotifications { get; set; }
        //public ICollection<Notification> ReceivedNotifications { get; set; }
        //public ICollection<Message> SentMessages { get; set; }
        //public ICollection<Message> ReceivedMessages { get; set; }
        //public ICollection<Rating> Ratings { get; set; }
    }
}

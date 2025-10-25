using HealthAidAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthAidAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<MedicineRequest> MedicineRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server = localhost ;" +
                "Database=HealthAidDB ;" +
                "TrustServerCertificate=True;" +
                "Trusted_connection=True");
        }
    }
}

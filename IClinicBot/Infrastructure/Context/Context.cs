using IClinicBot.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IClinicBot");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<MedicalExam> MedicalExam { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Scheduling> Scheduling { get; set; }
    }
}
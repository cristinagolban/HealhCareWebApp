using HealthCare.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCare.Api
{
    public class HealthCareContext : DbContext
    {
        private const string dbConnectionString = @"Server=.\SQLEXPRESS;Database=HealthCare;Trusted_Connection=True;";

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(dbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}

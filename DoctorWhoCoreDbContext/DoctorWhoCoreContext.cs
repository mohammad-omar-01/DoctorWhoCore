using DoctorWho.Db.Models;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreContext : DbContext
    {
        DbSet<Enemy> Enemies { get; set; }
        DbSet <Author> Authors { get; set; }
        DbSet<Episode> Episodes { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<Companion> Companions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "Server=localhost;Database=DoctorWhoCore;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
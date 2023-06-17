using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        DbSet<Enemy> Enemies { get; set; }
        DbSet <Author> Authors { get; set; }
        DbSet<Episode> Episodes { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<Companion> Companions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("ConnectionString");
        }


    }
}
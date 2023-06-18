using DoctorWho.Db.Models;
using DoctorWhoCoreDbContext.Seed_;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreContext : DbContext
    {
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet <Author> Authors { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Companion> Companions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "Server=localhost;Database=DoctorWhoCore;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enemy>(entity =>
            {
                entity.Property(e => e.EnemyDescription)
                    .HasMaxLength(int.MaxValue);
            });
            modelBuilder.Entity<Episode>(entity =>
            {
                entity.Property(e => e.Notes)
                    .HasMaxLength(int.MaxValue);
            });
            modelBuilder.Entity<Author>().HasData(Data.Authors);
            modelBuilder.Entity<Doctor>().HasData(Data.Doctors);
            
            modelBuilder.Entity<Enemy>().HasData(Data.Enemies);

            modelBuilder.Entity<Companion>().HasData(Data.Companions);
            modelBuilder.Entity<Episode>().HasData(Data.Episodes);



        }


    }
}
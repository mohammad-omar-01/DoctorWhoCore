using DoctorWho.Db.Models;
using DoctorWhoCoreDbContext.Seed_;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreContext : DbContext
    {
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet <Author> Authors { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<EpisodeSummary> EpisodeSummaries { get; set; }

        [DbFunction("fnCompanion", "DoctorWho.Db")]
        public static string GetCompanion(int episodeId)
        {
            throw new NotImplementedException();
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "Server=localhost;Database=DoctorWhoCore;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString).LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name},LogLevel.Information );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodeSummary>().ToView("viewEpisodes");

            modelBuilder.Entity<EpisodeSummary>().HasNoKey();

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
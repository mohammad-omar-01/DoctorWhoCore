using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWhoCoreDbContext.Migrations
{
    public partial class ProecdureCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE inseartAuthors @Name nvarchar(30)
                AS
                INSERT INTO dbo.tblAuthor (AuthorName) VALUES (@Name)
               ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE inseartEnemy @Name nvarchar(30), @Description text
                AS
                INSERT INTO dbo.tblEnemy (EnemyName, Description) VALUES (@Name, @Description);
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE inseartDoctor @Number int, @Name nvarchar(30), @Date date, @Start date, @End Date
                AS
                INSERT INTO dbo.tblDoctor (DoctorNumber, DoctorName, BirthDate, FirstEpisodeDate, LastEpisodeDate) 
                VALUES (@Number, @Name, @Date, @Start, @End);
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE inseartCompanion @Name nvarchar(30), @WhoPlayed nvarchar(45)
                AS
                INSERT INTO dbo.tblCompanion (CompanionName, WhoPlayed) VALUES (@Name, @WhoPlayed);
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE AddEpisode @SeriesNum int, @EpisodeNum int, @EpisodeType nvarchar(35), @Title nvarchar(35), 
                                           @DateReleased date, @AuthorId int, @DoctorId int
                AS
                INSERT INTO dbo.tblEpisode (SeriesNumber, EpisodeNumber, EpisodeType, Title, EpisodeDate, AuthorId, DoctorId)
                VALUES (@SeriesNum, @EpisodeNum, @EpisodeType, @Title, @DateReleased, @AuthorId, @DoctorId);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DROP PROCEDURE AddEpisode;
            ");

            migrationBuilder.Sql(@"
                DROP PROCEDURE inseartCompanion;
            ");

            migrationBuilder.Sql(@"
                DROP PROCEDURE inseartDoctor;
            ");

            migrationBuilder.Sql(@"
                DROP PROCEDURE inseartEnemy;
            ");

            migrationBuilder.Sql(@"
                DROP PROCEDURE inseartAuthors;
            ");
        }
    }
}

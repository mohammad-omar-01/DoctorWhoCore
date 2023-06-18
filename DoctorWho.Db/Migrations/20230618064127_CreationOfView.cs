using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoCoreDbContext.Migrations
{
    /// <inheritdoc />
    public partial class CreationOfView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW  [dbo].[viewEpisodes] AS 
	                SELECT A.AuthorName ,D.DoctorName, E.Title , dbo.fnEnemies(EpisodeId) AS EnemyNames , 
                    dbo.fnCompanion(EpisodeId) AS CompainonNames

	                FROM Episodes E left outer JOIN Authors A ON 
	                    E.AuthorId=a.AuthorId 
	                left outer JOIN Doctors D ON 
	                    E.DoctorID= D.DoctorId;
                 GO
             ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[viewEpisodes]");

        }
    }
}

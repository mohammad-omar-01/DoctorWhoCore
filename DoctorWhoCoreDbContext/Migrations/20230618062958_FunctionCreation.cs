using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWhoCoreDbContext.Migrations
{
    /// <inheritdoc />
    public partial class FunctionCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE FUNCTION [dbo].[fnCompanion] (@episodeId int)
                RETURNS VARCHAR(max) AS
                BEGIN
                    DECLARE @resultSet VARCHAR(MAX) = ' ';
                    SELECT @resultSet = CONCAT(C.CompanionName, ' , ', @resultSet)
                    FROM Companions C
                    INNER JOIN CompanionEpisode EC ON C.CompanionId = EC.CompanionsCompanionId
                    WHERE EC.EpisodesEpisodeId = @episodeId;
                    SET @resultSet = TRIM(', ' FROM @resultSet);
                    RETURN @resultSet;
                END
            ");

            migrationBuilder.Sql(@"
                CREATE FUNCTION [dbo].[fnCompanions] (@episodeId INT)
                RETURNS TABLE AS RETURN
                SELECT DISTINCT C.CompanionName
                FROM CompanionEpisode EC
                INNER JOIN Companions C ON EC.CompanionsCompanionId = C.CompanionId
                WHERE EC.EpisodesEpisodeId = @episodeId;
            ");

            migrationBuilder.Sql(@"
                CREATE FUNCTION [dbo].[fnEnemies] (@episodeId int)
                RETURNS VARCHAR(max) AS
                BEGIN
                    DECLARE @resultSet VARCHAR(MAX) = ' ';
                    SELECT @resultSet = CONCAT(E.EnemyName, ' , ', @resultSet)
                    FROM Enemies E
                    INNER JOIN EnemyEpisode EE ON E.EnemyId = EE.EnemiesEnemyId
                    WHERE EE.EpisodesEpisodeId = @episodeId;
                    SET @resultSet = TRIM(', ' FROM @resultSet);
                    RETURN @resultSet;
                END
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DROP FUNCTION [dbo].[fnCompanion];
            ");

            migrationBuilder.Sql(@"
                DROP FUNCTION [dbo].[fnCompanions];
            ");

            migrationBuilder.Sql(@"
                DROP FUNCTION [dbo].[fnEnemies];
            ");
        }
    }
}

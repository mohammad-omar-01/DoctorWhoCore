using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWhoCoreDbContext.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Episodes",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "EnemyDescription",
                table: "Enemies",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, " Anthony Coburn" },
                    { 2, "Sydney Newman" },
                    { 3, "David Whitaker" },
                    { 4, "John Lucarotti" },
                    { 5, "Terry Nation" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Susan Foreman", "Carole Ann Ford" },
                    { 2, "Ian Chesterton", "William Russell" },
                    { 3, "Steven Taylor", "Peter Purves" },
                    { 4, "Sara Kingdom", "Jean Marsh" },
                    { 5, "Anneke Wills", "Polly" },
                    { 6, "Clara Oswald", "Jenna Coleman" },
                    { 7, "Bill Potts", "Pearl Mackie" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1908, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "William Hartnell", 1, new DateTime(1963, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1913, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jon Pertwee", 3, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1954, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Davison", 5, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1968, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Jayston", 7, new DateTime(1986, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1962, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sylvester McCoy", 9, new DateTime(1987, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "EnemyDescription", "EnemyName" },
                values: new object[,]
                {
                    { 1, "The Daleks are a fictional extraterrestrial race of extremely xenophobic mutants principally portrayed in the British science fiction television programme Doctor Who.", "Dalek" },
                    { 2, "Cybermens are emotionless robots from another world that constantly change their design.", "Cybermen" },
                    { 3, "He is the Doctor's Moriarty: a renegade Time Lord who may be the hero's intellectual equal, but who is also his moral opposite.", "The Master" },
                    { 4, "Davros is a character from the long-running British science fiction television series Doctor Who.", "Davros" },
                    { 5, "The Sontarans are a fictional race of extraterrestrial humanoids principally portrayed in the British science fiction television programme Doctor Who.", "Sontarans" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Regular", "Introduction of the First Doctor", 1, "An Unearthly Child" },
                    { 2, 2, 1, new DateTime(1963, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Regular", "First appearance of the Daleks", 1, "The Daleks" },
                    { 3, 3, 1, new DateTime(1964, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Regular", "Bottle episode set entirely inside the TARDIS", 1, "The Edge of Destruction" },
                    { 4, 4, 1, new DateTime(1964, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Regular", "Historical adventure in the time of Marco Polo", 1, "Marco Polo" },
                    { 5, 5, 1, new DateTime(1964, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Regular", "Adventure involving a quest for the Keys of Marinus", 1, "The Keys of Marinus" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Episodes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 2147483647);

            migrationBuilder.AlterColumn<string>(
                name: "EnemyDescription",
                table: "Enemies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 2147483647);
        }
    }
}

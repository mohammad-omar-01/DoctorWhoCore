﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWhoCoreDbContext.Migrations
{
    [DbContext(typeof(DoctorWhoCoreContext))]
    partial class DoctorWhoCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = " Anthony Coburn"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Sydney Newman"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "David Whitaker"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "John Lucarotti"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Terry Nation"
                        });
                });

            modelBuilder.Entity("CompanionEpisode", b =>
                {
                    b.Property<int>("CompanionsCompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodesEpisodeId")
                        .HasColumnType("int");

                    b.HasKey("CompanionsCompanionId", "EpisodesEpisodeId");

                    b.HasIndex("EpisodesEpisodeId");

                    b.ToTable("CompanionEpisode");
                });

            modelBuilder.Entity("Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1908, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "William Hartnell",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(1963, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1966, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1913, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Jon Pertwee",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1974, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1954, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Peter Davison",
                            DoctorNumber = 5,
                            FirstEpisodeDate = new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1984, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1968, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Michael Jayston",
                            DoctorNumber = 7,
                            FirstEpisodeDate = new DateTime(1986, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1986, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1962, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Sylvester McCoy",
                            DoctorNumber = 9,
                            FirstEpisodeDate = new DateTime(1987, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1989, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"));

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Susan Foreman",
                            WhoPlayed = "Carole Ann Ford"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Ian Chesterton",
                            WhoPlayed = "William Russell"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Steven Taylor",
                            WhoPlayed = "Peter Purves"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Sara Kingdom",
                            WhoPlayed = "Jean Marsh"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Anneke Wills",
                            WhoPlayed = "Polly"
                        },
                        new
                        {
                            CompanionId = 6,
                            CompanionName = "Clara Oswald",
                            WhoPlayed = "Jenna Coleman"
                        },
                        new
                        {
                            CompanionId = 7,
                            CompanionName = "Bill Potts",
                            WhoPlayed = "Pearl Mackie"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"));

                    b.Property<string>("EnemyDescription")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            EnemyDescription = "The Daleks are a fictional extraterrestrial race of extremely xenophobic mutants principally portrayed in the British science fiction television programme Doctor Who.",
                            EnemyName = "Dalek"
                        },
                        new
                        {
                            EnemyId = 2,
                            EnemyDescription = "Cybermens are emotionless robots from another world that constantly change their design.",
                            EnemyName = "Cybermen"
                        },
                        new
                        {
                            EnemyId = 3,
                            EnemyDescription = "He is the Doctor's Moriarty: a renegade Time Lord who may be the hero's intellectual equal, but who is also his moral opposite.",
                            EnemyName = "The Master"
                        },
                        new
                        {
                            EnemyId = 4,
                            EnemyDescription = "Davros is a character from the long-running British science fiction television series Doctor Who.",
                            EnemyName = "Davros"
                        },
                        new
                        {
                            EnemyId = 5,
                            EnemyDescription = "The Sontarans are a fictional race of extraterrestrial humanoids principally portrayed in the British science fiction television programme Doctor Who.",
                            EnemyName = "Sontarans"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Regular",
                            Notes = "Introduction of the First Doctor",
                            SeriesNumber = 1,
                            Title = "An Unearthly Child"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Regular",
                            Notes = "First appearance of the Daleks",
                            SeriesNumber = 1,
                            Title = "The Daleks"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1964, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "Regular",
                            Notes = "Bottle episode set entirely inside the TARDIS",
                            SeriesNumber = 1,
                            Title = "The Edge of Destruction"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 4,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1964, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 4,
                            EpisodeType = "Regular",
                            Notes = "Historical adventure in the time of Marco Polo",
                            SeriesNumber = 1,
                            Title = "Marco Polo"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1964, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 5,
                            EpisodeType = "Regular",
                            Notes = "Adventure involving a quest for the Keys of Marinus",
                            SeriesNumber = 1,
                            Title = "The Keys of Marinus"
                        });
                });

            modelBuilder.Entity("EnemyEpisode", b =>
                {
                    b.Property<int>("EnemiesEnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodesEpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EnemiesEnemyId", "EpisodesEpisodeId");

                    b.HasIndex("EpisodesEpisodeId");

                    b.ToTable("EnemyEpisode");
                });

            modelBuilder.Entity("CompanionEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Companion", null)
                        .WithMany()
                        .HasForeignKey("CompanionsCompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", null)
                        .WithMany()
                        .HasForeignKey("EpisodesEpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.HasOne("Author", null)
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Doctor", null)
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnemyEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Enemy", null)
                        .WithMany()
                        .HasForeignKey("EnemiesEnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", null)
                        .WithMany()
                        .HasForeignKey("EpisodesEpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("Doctor", b =>
                {
                    b.Navigation("Episodes");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoDbContext))]
    partial class DoctorWhoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWho.Domain.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Chris Chibnall"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Gareth Roberts"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Helen Raynor"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "James Moran"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "James Strong"
                        });
                });

            modelBuilder.Entity("DoctorWho.Domain.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"));

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "River Song",
                            WhoPlayed = "Alex Kingston"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Rory Williams",
                            WhoPlayed = "Arthur Darvill"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Wilfred Mott",
                            WhoPlayed = "Bernard Cribbins"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Rose Tyler",
                            WhoPlayed = "Billie Piper"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "James Strong",
                            WhoPlayed = "Bruno Langley"
                        });
                });

            modelBuilder.Entity("DoctorWho.Domain.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<DateTime>("BirthDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("NULL");

                    b.Property<DateTime>("LastEpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("NULL");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1964, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Christopher Eccleston",
                            DoctorNumber = 9,
                            FirstEpisodeDate = new DateTime(2005, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2005, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1943, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Colin Baker",
                            DoctorNumber = 6,
                            FirstEpisodeDate = new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1986, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1971, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "David Tennant",
                            DoctorNumber = 10,
                            FirstEpisodeDate = new DateTime(2005, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1930, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Jon Pertwee",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(1970, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1974, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Matt Smith",
                            DoctorNumber = 11,
                            FirstEpisodeDate = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Domain.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "Murderous mannequins",
                            EnemyName = "The Autons"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "The last living human being",
                            EnemyName = "Lady Cassandra"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "An alien species comprised of gas",
                            EnemyName = "The Gelth"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "A baby-faced alien family",
                            EnemyName = "The Slitheen"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "Armoured aliens",
                            EnemyName = "Daleks"
                        });
                });

            modelBuilder.Entity("DoctorWho.Domain.Episode", b =>
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("NULL");

                    b.Property<int>("EpisodeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("0");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("NULL");

                    b.Property<int>("SeriesNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            EpisodeDate = new DateTime(2005, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Normal episode",
                            Notes = "",
                            SeriesNumber = 1,
                            Title = "Rose"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2005, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Normal episode",
                            Notes = "",
                            SeriesNumber = 1,
                            Title = "The End of the World"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2005, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "Normal episode",
                            Notes = "",
                            SeriesNumber = 1,
                            Title = "The Unquiet Dead"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2005, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 4,
                            EpisodeType = "Normal episode",
                            Notes = "",
                            SeriesNumber = 1,
                            Title = "Aliens of London (Part 1)"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2005, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 5,
                            EpisodeType = "Normal episode",
                            Notes = "",
                            SeriesNumber = 1,
                            Title = "World War Three (Part 2)"
                        });
                });

            modelBuilder.Entity("DoctorWho.Domain.EpisodeCompanion", b =>
                {
                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeCompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            EpisodeCompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            CompanionId = 2,
                            EpisodeCompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            CompanionId = 3,
                            EpisodeCompanionId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            CompanionId = 4,
                            EpisodeCompanionId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            CompanionId = 5,
                            EpisodeCompanionId = 4,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Domain.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"));

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Domain.Episode", b =>
                {
                    b.HasOne("DoctorWho.Domain.Author", null)
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Domain.Doctor", null)
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Domain.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Domain.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Domain.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Domain.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Domain.Enemy", "Enemy")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Domain.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Domain.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Domain.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.Domain.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Domain.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWho.Domain.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using s20511Kolos1.Models;

namespace s20511Kolos1.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("s20511Kolos1.Models.Championship", b =>
                {
                    b.Property<int>("IdChampionship")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OfficialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("IdChampionship");

                    b.ToTable("Championships");

                    b.HasData(
                        new
                        {
                            IdChampionship = 1,
                            OfficialName = "Champions League",
                            Year = 2015
                        },
                        new
                        {
                            IdChampionship = 2,
                            OfficialName = "Europe League",
                            Year = 2017
                        },
                        new
                        {
                            IdChampionship = 3,
                            OfficialName = "Super League",
                            Year = 2020
                        });
                });

            modelBuilder.Entity("s20511Kolos1.Models.Championship_Team", b =>
                {
                    b.Property<int>("IdChampionshipTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdChampionship")
                        .HasColumnType("int");

                    b.Property<int>("IdTeam")
                        .HasColumnType("int");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.HasKey("IdChampionshipTeam");

                    b.HasIndex("IdChampionship");

                    b.HasIndex("IdTeam");

                    b.ToTable("Championship_Teams");

                    b.HasData(
                        new
                        {
                            IdChampionshipTeam = 1,
                            IdChampionship = 1,
                            IdTeam = 2,
                            Score = 2f
                        },
                        new
                        {
                            IdChampionshipTeam = 2,
                            IdChampionship = 3,
                            IdTeam = 1,
                            Score = 2.2f
                        },
                        new
                        {
                            IdChampionshipTeam = 3,
                            IdChampionship = 2,
                            IdTeam = 3,
                            Score = 3.1f
                        });
                });

            modelBuilder.Entity("s20511Kolos1.Models.Player", b =>
                {
                    b.Property<int>("IdPlayer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdPlayer");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            IdPlayer = 1,
                            DateOfBirth = new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Wayne",
                            LastName = "Rooney"
                        },
                        new
                        {
                            IdPlayer = 2,
                            DateOfBirth = new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Cristiano",
                            LastName = "Ronaldo"
                        },
                        new
                        {
                            IdPlayer = 3,
                            DateOfBirth = new DateTime(1991, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Messi",
                            LastName = "Lionel"
                        });
                });

            modelBuilder.Entity("s20511Kolos1.Models.Player_Team", b =>
                {
                    b.Property<int>("IdPlayerTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("IdPlayer")
                        .HasColumnType("int");

                    b.Property<int>("IdTeam")
                        .HasColumnType("int");

                    b.Property<int>("NumOnShirt")
                        .HasColumnType("int");

                    b.HasKey("IdPlayerTeam");

                    b.HasIndex("IdPlayer");

                    b.HasIndex("IdTeam");

                    b.ToTable("Player_Teams");

                    b.HasData(
                        new
                        {
                            IdPlayerTeam = 1,
                            Comment = "qwertyui",
                            IdPlayer = 2,
                            IdTeam = 3,
                            NumOnShirt = 9
                        },
                        new
                        {
                            IdPlayerTeam = 2,
                            Comment = "kalsjdhfg",
                            IdPlayer = 1,
                            IdTeam = 2,
                            NumOnShirt = 7
                        },
                        new
                        {
                            IdPlayerTeam = 3,
                            Comment = "oqiwueyrt",
                            IdPlayer = 3,
                            IdTeam = 1,
                            NumOnShirt = 10
                        });
                });

            modelBuilder.Entity("s20511Kolos1.Models.Team", b =>
                {
                    b.Property<int>("IdTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxAge")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdTeam");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            IdTeam = 1,
                            MaxAge = 45,
                            TeamName = "Barcelona"
                        },
                        new
                        {
                            IdTeam = 2,
                            MaxAge = 34,
                            TeamName = "Chelsea"
                        },
                        new
                        {
                            IdTeam = 3,
                            MaxAge = 36,
                            TeamName = "Liverpool"
                        });
                });

            modelBuilder.Entity("s20511Kolos1.Models.Championship_Team", b =>
                {
                    b.HasOne("s20511Kolos1.Models.Championship", "Championship")
                        .WithMany()
                        .HasForeignKey("IdChampionship")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("s20511Kolos1.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("IdTeam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Championship");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("s20511Kolos1.Models.Player_Team", b =>
                {
                    b.HasOne("s20511Kolos1.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("IdPlayer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("s20511Kolos1.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("IdTeam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}

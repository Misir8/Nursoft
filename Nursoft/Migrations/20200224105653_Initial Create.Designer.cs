﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nursoft.DAL;

namespace Nursoft.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200224105653_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nursoft.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "motherboard-1.jpg",
                            Subtitle = "Just send valuable laptop, PC, MAC, Mobile,<br>Gaming Device or Smartphone and we'll take care of it.",
                            Title = "Fast & Quick Fix"
                        },
                        new
                        {
                            Id = 2,
                            Image = "motherboard-3.jpg",
                            Title = "Any Kind of Upgrades"
                        },
                        new
                        {
                            Id = 3,
                            Image = "data-recovery.jpg",
                            Subtitle = "You Lose - We'll Find",
                            Title = "Data Recovery"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlantShop.Data;

#nullable disable

namespace PlantShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240207173604_Seed Category Table")]
    partial class SeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlantShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Alocasia"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Caladium"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Calathea"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Epipremnum"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Ficus"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Hoya"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Monstera"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Philodendron"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Succulents"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

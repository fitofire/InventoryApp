﻿// <auto-generated />
using System;
using InventoryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250218200958_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InventoryApp.Models.ComputerEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AssetTag")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CurrentUser")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerialName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("WarrantyExp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ComputerEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssetTag = "ELXL-RJBFPV2",
                            CurrentUser = "IT",
                            LastUpdated = new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Tech Room",
                            Manufacturer = "Dell",
                            Model = "5490",
                            PurchaseDate = new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SerialName = "RJBFPV2",
                            Status = "Decommissioned",
                            WarrantyExp = new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AssetTag = "ELXL-DFSFPV2",
                            CurrentUser = "IT",
                            LastUpdated = new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Tech Room",
                            Manufacturer = "Dell",
                            Model = "5490",
                            PurchaseDate = new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SerialName = "DFSFPV2",
                            Status = "Decommissioned",
                            WarrantyExp = new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AssetTag = "ELXL-RKLFPV2",
                            CurrentUser = "IT",
                            LastUpdated = new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Tech Room",
                            Manufacturer = "Dell",
                            Model = "5490",
                            PurchaseDate = new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SerialName = "DFSFPV2",
                            Status = "Decommissioned",
                            WarrantyExp = new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

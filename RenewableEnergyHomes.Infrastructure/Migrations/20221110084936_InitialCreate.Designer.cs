﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RenewableEnergyHomes.Infrastructure.DbContexts;

#nullable disable

namespace RenewableEnergyHomes.Infrastructure.Migrations
{
    [DbContext(typeof(PropertyDataContext))]
    [Migration("20221110084936_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RenewableEnergyHomes.Infrastructure.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("EpcRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine1 = "Bowmont Close",
                            AddressLine2 = "Cheadle Hulme",
                            County = "Greater Manchester",
                            DateCreated = new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1615),
                            EpcRating = "A94",
                            HouseNumber = "4",
                            Postcode = "SK8 5RX",
                            Town = "Cheadle"
                        },
                        new
                        {
                            Id = 2,
                            AddressLine1 = "Bowmont Close",
                            AddressLine2 = "Cheadle Hulme",
                            County = "Greater Manchester",
                            DateCreated = new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1669),
                            EpcRating = "C71",
                            HouseNumber = "11",
                            Postcode = "SK8 5RX",
                            Town = "Cheadle"
                        },
                        new
                        {
                            Id = 3,
                            AddressLine1 = "Bowmont Close",
                            AddressLine2 = "Cheadle Hulme",
                            County = "Greater Manchester",
                            DateCreated = new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1672),
                            EpcRating = "B83",
                            HouseNumber = "35",
                            Postcode = "SK8 5RX",
                            Town = "Cheadle"
                        },
                        new
                        {
                            Id = 4,
                            AddressLine1 = "Bowmont Close",
                            AddressLine2 = "Cheadle Hulme",
                            County = "Greater Manchester",
                            DateCreated = new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1675),
                            EpcRating = "B90",
                            HouseNumber = "63",
                            Postcode = "SK8 5RX",
                            Town = "Cheadle"
                        },
                        new
                        {
                            Id = 5,
                            AddressLine1 = "Fields New Road",
                            AddressLine2 = "Chadderton",
                            County = "Greater Manchester",
                            DateCreated = new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1677),
                            EpcRating = "E45",
                            HouseNumber = "18",
                            Postcode = "OL9 8BP",
                            Town = "Oldham"
                        },
                        new
                        {
                            Id = 6,
                            AddressLine1 = "Fields New Road",
                            AddressLine2 = "Chadderton",
                            County = "Greater Manchester",
                            DateCreated = new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1680),
                            EpcRating = "B88",
                            HouseNumber = "19",
                            Postcode = "OL9 8BP",
                            Town = "Oldham"
                        },
                        new
                        {
                            Id = 7,
                            AddressLine1 = "Winstree Road",
                            AddressLine2 = "Stanway",
                            County = "Essex",
                            DateCreated = new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1682),
                            EpcRating = "C75",
                            HouseNumber = "166",
                            Postcode = "CO3 0QF",
                            Town = "Colchester"
                        });
                });

            modelBuilder.Entity("RenewableEnergyHomes.Infrastructure.Entities.PropertyFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "SPRI",
                            Label = "Solar panel roof installation"
                        },
                        new
                        {
                            Id = 2,
                            Code = "WTG",
                            Label = "Wind turbine generator"
                        },
                        new
                        {
                            Id = 3,
                            Code = "EVCP",
                            Label = "EV charging point"
                        },
                        new
                        {
                            Id = 4,
                            Code = "BSU",
                            Label = "Battery storage unit"
                        });
                });

            modelBuilder.Entity("RenewableEnergyHomes.Infrastructure.Entities.PropertySale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateOfSale")
                        .HasColumnType("datetime2");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<long?>("SaleAmount")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertySales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfSale = new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 1,
                            SaleAmount = 400000L
                        },
                        new
                        {
                            Id = 2,
                            DateOfSale = new DateTime(2015, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 1,
                            SaleAmount = 300000L
                        },
                        new
                        {
                            Id = 3,
                            DateOfSale = new DateTime(2008, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 1,
                            SaleAmount = 200000L
                        },
                        new
                        {
                            Id = 4,
                            DateOfSale = new DateTime(2011, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 2,
                            SaleAmount = 150000L
                        },
                        new
                        {
                            Id = 5,
                            DateOfSale = new DateTime(2013, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 2,
                            SaleAmount = 200000L
                        },
                        new
                        {
                            Id = 6,
                            DateOfSale = new DateTime(2014, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 2,
                            SaleAmount = 250000L
                        },
                        new
                        {
                            Id = 7,
                            DateOfSale = new DateTime(2017, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 2,
                            SaleAmount = 300000L
                        },
                        new
                        {
                            Id = 8,
                            DateOfSale = new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 2,
                            SaleAmount = 350000L
                        },
                        new
                        {
                            Id = 9,
                            DateOfSale = new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 3,
                            SaleAmount = 790000L
                        },
                        new
                        {
                            Id = 10,
                            DateOfSale = new DateTime(2001, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 3,
                            SaleAmount = 540000L
                        },
                        new
                        {
                            Id = 11,
                            DateOfSale = new DateTime(2018, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 4,
                            SaleAmount = 550000L
                        },
                        new
                        {
                            Id = 12,
                            DateOfSale = new DateTime(2018, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 4,
                            SaleAmount = 440000L
                        },
                        new
                        {
                            Id = 13,
                            DateOfSale = new DateTime(2017, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 5,
                            SaleAmount = 660000L
                        },
                        new
                        {
                            Id = 14,
                            DateOfSale = new DateTime(2015, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 5,
                            SaleAmount = 440000L
                        },
                        new
                        {
                            Id = 15,
                            DateOfSale = new DateTime(2016, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 6,
                            SaleAmount = 770000L
                        },
                        new
                        {
                            Id = 16,
                            DateOfSale = new DateTime(2014, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyId = 6,
                            SaleAmount = 550000L
                        });
                });

            modelBuilder.Entity("RenewableEnergyHomes.Infrastructure.Entities.PropertySale", b =>
                {
                    b.HasOne("RenewableEnergyHomes.Infrastructure.Entities.Property", "Property")
                        .WithMany("PropertySales")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("RenewableEnergyHomes.Infrastructure.Entities.Property", b =>
                {
                    b.Navigation("PropertySales");
                });
#pragma warning restore 612, 618
        }
    }
}

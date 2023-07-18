using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RenewableEnergyHomes.Infrastructure.Entities;

namespace RenewableEnergyHomes.Infrastructure.DbContexts
{
    public class PropertyDataContext : DbContext
    {
        //private readonly string _connectionString;

        //public PropertyDataContext(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyFeature> PropertyFeatures { get; set; }

        public DbSet<PropertySale> PropertySales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=DESKTOP-0QHJ9TC;Initial Catalog=PropertyDataEF;User ID=ServiceUser;Password=Password1;Persist Security Info=False;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyFeature>().HasData(
                new PropertyFeature { Id = 1, Code = "SPRI", Label = "Solar panel roof installation" },
                new PropertyFeature { Id = 2, Code = "WTG", Label = "Wind turbine generator" },
                new PropertyFeature { Id = 3, Code = "EVCP", Label = "EV charging point" },
                new PropertyFeature { Id = 4, Code = "BSU", Label = "Battery storage unit" });


            modelBuilder.Entity<Property>().HasData(
              new Property { Id = 1, DateCreated = DateTime.Now, Postcode = "SK8 5RX", HouseNumber = "4", AddressLine1 = "Bowmont Close", AddressLine2 = "Cheadle Hulme", Town = "Cheadle", County = "Greater Manchester", EpcRating = "A94" },
              new Property { Id = 2, DateCreated = DateTime.Now, Postcode = "SK8 5RX", HouseNumber = "11", AddressLine1 = "Bowmont Close", AddressLine2 = "Cheadle Hulme", Town = "Cheadle", County = "Greater Manchester", EpcRating = "C71" },
              new Property { Id = 3, DateCreated = DateTime.Now, Postcode = "SK8 5RX", HouseNumber = "35", AddressLine1 = "Bowmont Close", AddressLine2 = "Cheadle Hulme", Town = "Cheadle", County = "Greater Manchester", EpcRating = "B83" },
              new Property { Id = 4, DateCreated = DateTime.Now, Postcode = "SK8 5RX", HouseNumber = "63", AddressLine1 = "Bowmont Close", AddressLine2 = "Cheadle Hulme", Town = "Cheadle", County = "Greater Manchester", EpcRating = "B90" },
              new Property { Id = 5, DateCreated = DateTime.Now, Postcode = "OL9 8BP", HouseNumber = "18", AddressLine1 = "Fields New Road", AddressLine2 = "Chadderton", Town = "Oldham", County = "Greater Manchester", EpcRating = "E45" },
              new Property { Id = 6, DateCreated = DateTime.Now, Postcode = "OL9 8BP", HouseNumber = "19", AddressLine1 = "Fields New Road", AddressLine2 = "Chadderton", Town = "Oldham", County = "Greater Manchester", EpcRating = "B88" },
              new Property { Id = 7, DateCreated = DateTime.Now, Postcode = "CO3 0QF", HouseNumber = "166", AddressLine1 = "Winstree Road", AddressLine2 = "Stanway", Town = "Colchester", County = "Essex", EpcRating = "C75" });

            modelBuilder.Entity<PropertySale>().HasData(
              new PropertySale { Id = 1, PropertyId = 1, DateOfSale = new DateTime(2020, 12, 17), SaleAmount = 400000 },
              new PropertySale { Id = 2, PropertyId = 1, DateOfSale = new DateTime(2015, 02, 17), SaleAmount = 300000 },
              new PropertySale { Id = 3, PropertyId = 1, DateOfSale = new DateTime(2008, 01, 17), SaleAmount = 200000 },
              new PropertySale { Id = 4, PropertyId = 2, DateOfSale = new DateTime(2011, 05, 17), SaleAmount = 150000 },
              new PropertySale { Id = 5, PropertyId = 2, DateOfSale = new DateTime(2013, 01, 17), SaleAmount = 200000 },
              new PropertySale { Id = 6, PropertyId = 2, DateOfSale = new DateTime(2014, 09, 17), SaleAmount = 250000 },
              new PropertySale { Id = 7, PropertyId = 2, DateOfSale = new DateTime(2017, 08, 17), SaleAmount = 300000 },
              new PropertySale { Id = 8, PropertyId = 2, DateOfSale = new DateTime(2020, 02, 17), SaleAmount = 350000 },
              new PropertySale { Id = 9, PropertyId = 3, DateOfSale = new DateTime(2021, 10, 17), SaleAmount = 790000 },
              new PropertySale { Id = 10, PropertyId = 3, DateOfSale = new DateTime(2001, 10, 17), SaleAmount = 540000 },
              new PropertySale { Id = 11, PropertyId = 4, DateOfSale = new DateTime(2018, 12, 17), SaleAmount = 550000 },
              new PropertySale { Id = 12, PropertyId = 4, DateOfSale = new DateTime(2018, 01, 17), SaleAmount = 440000 },
              new PropertySale { Id = 13, PropertyId = 5, DateOfSale = new DateTime(2017, 02, 17), SaleAmount = 660000 },
              new PropertySale { Id = 14, PropertyId = 5, DateOfSale = new DateTime(2015, 04, 17), SaleAmount = 440000 },
              new PropertySale { Id = 15, PropertyId = 6, DateOfSale = new DateTime(2016, 03, 17), SaleAmount = 770000 },
              new PropertySale { Id = 16, PropertyId = 6, DateOfSale = new DateTime(2014, 05, 17), SaleAmount = 550000 });
        }
    }
}

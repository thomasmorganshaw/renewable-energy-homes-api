using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RenewableEnergyHomes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpcRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertySales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    DateOfSale = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SaleAmount = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertySales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertySales_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "County", "DateCreated", "EpcRating", "HouseName", "HouseNumber", "Postcode", "Town" },
                values: new object[,]
                {
                    { 1, "Bowmont Close", "Cheadle Hulme", null, "Greater Manchester", new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1615), "A94", null, "4", "SK8 5RX", "Cheadle" },
                    { 2, "Bowmont Close", "Cheadle Hulme", null, "Greater Manchester", new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1669), "C71", null, "11", "SK8 5RX", "Cheadle" },
                    { 3, "Bowmont Close", "Cheadle Hulme", null, "Greater Manchester", new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1672), "B83", null, "35", "SK8 5RX", "Cheadle" },
                    { 4, "Bowmont Close", "Cheadle Hulme", null, "Greater Manchester", new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1675), "B90", null, "63", "SK8 5RX", "Cheadle" },
                    { 5, "Fields New Road", "Chadderton", null, "Greater Manchester", new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1677), "E45", null, "18", "OL9 8BP", "Oldham" },
                    { 6, "Fields New Road", "Chadderton", null, "Greater Manchester", new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1680), "B88", null, "19", "OL9 8BP", "Oldham" },
                    { 7, "Winstree Road", "Stanway", null, "Essex", new DateTime(2022, 11, 10, 8, 49, 36, 394, DateTimeKind.Local).AddTicks(1682), "C75", null, "166", "CO3 0QF", "Colchester" }
                });

            migrationBuilder.InsertData(
                table: "PropertyFeatures",
                columns: new[] { "Id", "Code", "Label" },
                values: new object[,]
                {
                    { 1, "SPRI", "Solar panel roof installation" },
                    { 2, "WTG", "Wind turbine generator" },
                    { 3, "EVCP", "EV charging point" },
                    { 4, "BSU", "Battery storage unit" }
                });

            migrationBuilder.InsertData(
                table: "PropertySales",
                columns: new[] { "Id", "DateOfSale", "PropertyId", "SaleAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 400000L },
                    { 2, new DateTime(2015, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 300000L },
                    { 3, new DateTime(2008, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 200000L },
                    { 4, new DateTime(2011, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 150000L },
                    { 5, new DateTime(2013, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 200000L },
                    { 6, new DateTime(2014, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 250000L },
                    { 7, new DateTime(2017, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 300000L },
                    { 8, new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 350000L },
                    { 9, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 790000L },
                    { 10, new DateTime(2001, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 540000L },
                    { 11, new DateTime(2018, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 550000L },
                    { 12, new DateTime(2018, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 440000L },
                    { 13, new DateTime(2017, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 660000L },
                    { 14, new DateTime(2015, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 440000L },
                    { 15, new DateTime(2016, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 770000L },
                    { 16, new DateTime(2014, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 550000L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertySales_PropertyId",
                table: "PropertySales",
                column: "PropertyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyFeatures");

            migrationBuilder.DropTable(
                name: "PropertySales");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}

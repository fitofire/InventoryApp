using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComputerEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetTag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SerialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarrantyExp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CurrentUser = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ComputerEntries",
                columns: new[] { "Id", "AssetTag", "CurrentUser", "LastUpdated", "Location", "Manufacturer", "Model", "PurchaseDate", "SerialName", "Status", "WarrantyExp" },
                values: new object[,]
                {
                    { 1, "ELXL-RJBFPV2", "IT", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tech Room", "Dell", "5490", new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "RJBFPV2", "Decommissioned", new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "ELXL-DFSFPV2", "IT", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tech Room", "Dell", "5490", new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "DFSFPV2", "Decommissioned", new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "ELXL-RKLFPV2", "IT", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tech Room", "Dell", "5490", new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "DFSFPV2", "Decommissioned", new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputerEntries");
        }
    }
}

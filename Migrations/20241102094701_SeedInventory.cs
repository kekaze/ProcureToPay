using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcureToPay.Migrations
{
    /// <inheritdoc />
    public partial class SeedInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CompanyId", "LatestPrice", "MaterialId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 350000.00m, 1, 3m },
                    { 2, 1, 90000.00m, 2, 5m },
                    { 3, 1, 20000.00m, 3, 10m },
                    { 4, 2, 20000.00m, 3, 6m },
                    { 5, 2, 32000.00m, 5, 1m },
                    { 6, 2, 1300400.00m, 4, 3m },
                    { 7, 3, 350000.00m, 1, 4m },
                    { 8, 3, 20000.00m, 3, 7m },
                    { 9, 3, 1300400.00m, 4, 2m },
                    { 10, 3, 32000.00m, 5, 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

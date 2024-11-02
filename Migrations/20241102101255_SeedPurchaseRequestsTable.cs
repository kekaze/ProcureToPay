using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcureToPay.Migrations
{
    /// <inheritdoc />
    public partial class SeedPurchaseRequestsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PurchaseRequests",
                columns: new[] { "Id", "PurchaseId", "Purpose", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 435000001, "For repair and maintenance of Engine 1", "For approval", "Normal" },
                    { 2, 435000002, "For repair and maintenance of Engine 2", "For approval", "Urgent" },
                    { 3, 435000003, "For repair and maintenance of Engine 3", "For approval", "Urgent" },
                    { 4, 435000004, "For 4000RH PMS of Air Compressor X", "For approval", "Normal" },
                    { 5, 435000005, "For annual maintenance of T/C for Engine 10", "For approval", "Normal" },
                    { 6, 435000006, "For 62000RH PMS of Engine 7", "For approval", "Normal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

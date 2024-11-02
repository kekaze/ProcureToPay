using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcureToPay.Migrations
{
    /// <inheritdoc />
    public partial class SeedMaterials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Brand", "Category", "Dimensions", "MaterialCode", "MaterialName" },
                values: new object[,]
                {
                    { 1, "Brand X", "Spare Parts", "Dimension XXX", 100001, "Cylinder Head 244 001" },
                    { 2, "Brand Y", "Spare Parts", "Dimension YYY", 100002, "Fuel Injector 125 987" },
                    { 3, "Q8", "Chemicals", "208 Liters", 200001, "Q8 Mahler G5 SAE 40" },
                    { 4, "Brand A", "Spare Parts", "Dimension AAA", 100003, "Turbocharger 876 543" },
                    { 5, "Shell", "Chemicals", "20 Liters", 200002, "Shell Corena S4 R" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

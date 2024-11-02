using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcureToPay.Migrations
{
    /// <inheritdoc />
    public partial class SeedPurchaseRequestMaterialsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Quantity",
                table: "PurchaseRequestMaterials",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "PurchaseRequestMaterials",
                columns: new[] { "MaterialId", "PurchaseRequestId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1f },
                    { 1, 2, 1f },
                    { 1, 3, 1f },
                    { 2, 1, 2f },
                    { 2, 3, 4f },
                    { 2, 6, 18f },
                    { 3, 3, 3f },
                    { 3, 6, 1f },
                    { 4, 5, 1f },
                    { 5, 4, 2f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "PurchaseRequestMaterials",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}

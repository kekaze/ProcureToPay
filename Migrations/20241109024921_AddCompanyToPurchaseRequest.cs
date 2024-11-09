using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcureToPay.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyToPurchaseRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "PurchaseRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CompanyId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CompanyId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CompanyId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRequests_CompanyId",
                table: "PurchaseRequests",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseRequests_Companies_CompanyId",
                table: "PurchaseRequests",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequests_Companies_CompanyId",
                table: "PurchaseRequests");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseRequests_CompanyId",
                table: "PurchaseRequests");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "PurchaseRequests");
        }
    }
}

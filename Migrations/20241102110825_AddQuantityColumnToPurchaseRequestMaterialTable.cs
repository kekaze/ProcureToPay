using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcureToPay.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantityColumnToPurchaseRequestMaterialTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequestMaterials_Materials_MaterialsId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequestMaterials_PurchaseRequests_PurchaseRequestsId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseRequestMaterials",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseRequestMaterials_PurchaseRequestsId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropColumn(
                name: "MaterialsId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.RenameColumn(
                name: "PurchaseRequestsId",
                table: "PurchaseRequestMaterials",
                newName: "PurchaseRequestId");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "PurchaseRequestMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Quantity",
                table: "PurchaseRequestMaterials",
                type: "float",
                precision: 5,
                scale: 2,
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseRequestMaterials",
                table: "PurchaseRequestMaterials",
                columns: new[] { "MaterialId", "PurchaseRequestId" });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRequestMaterials_PurchaseRequestId",
                table: "PurchaseRequestMaterials",
                column: "PurchaseRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseRequestMaterials_Materials_MaterialId",
                table: "PurchaseRequestMaterials",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseRequestMaterials_PurchaseRequests_PurchaseRequestId",
                table: "PurchaseRequestMaterials",
                column: "PurchaseRequestId",
                principalTable: "PurchaseRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequestMaterials_Materials_MaterialId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequestMaterials_PurchaseRequests_PurchaseRequestId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseRequestMaterials",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseRequestMaterials_PurchaseRequestId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.RenameColumn(
                name: "PurchaseRequestId",
                table: "PurchaseRequestMaterials",
                newName: "MaterialsId");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseRequestsId",
                table: "PurchaseRequestMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseRequestMaterials",
                table: "PurchaseRequestMaterials",
                columns: new[] { "MaterialsId", "PurchaseRequestsId" });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRequestMaterials_PurchaseRequestsId",
                table: "PurchaseRequestMaterials",
                column: "PurchaseRequestsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseRequestMaterials_Materials_MaterialsId",
                table: "PurchaseRequestMaterials",
                column: "MaterialsId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseRequestMaterials_PurchaseRequests_PurchaseRequestsId",
                table: "PurchaseRequestMaterials",
                column: "PurchaseRequestsId",
                principalTable: "PurchaseRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

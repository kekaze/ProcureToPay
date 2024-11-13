using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProcureToPay.Migrations
{
    /// <inheritdoc />
    public partial class ModifyInventorySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Materials_MaterialId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequestMaterials_Materials_MaterialId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequestMaterials_PurchaseRequests_PurchaseRequestId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseRequests",
                table: "PurchaseRequests");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseRequests_PurchaseId",
                table: "PurchaseRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_MaterialCode",
                table: "Materials");

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

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PurchaseRequests");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "PurchaseRequests");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "PurchaseRequests",
                type: "int",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseRequests",
                table: "PurchaseRequests",
                column: "PurchaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "MaterialCode");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaterialId",
                value: 100001);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "MaterialId",
                value: 100002);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "MaterialId",
                value: 200001);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4,
                column: "MaterialId",
                value: 200001);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5,
                column: "MaterialId",
                value: 200002);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 6,
                column: "MaterialId",
                value: 100003);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 7,
                column: "MaterialId",
                value: 100001);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 8,
                column: "MaterialId",
                value: 200001);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 9,
                column: "MaterialId",
                value: 100003);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 10,
                column: "MaterialId",
                value: 200002);

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialCode", "Brand", "Category", "Dimensions", "MaterialName" },
                values: new object[,]
                {
                    { 100001, "Brand X", "Spare Parts", "Dimension XXX", "Cylinder Head 244 001" },
                    { 100002, "Brand Y", "Spare Parts", "Dimension YYY", "Fuel Injector 125 987" },
                    { 100003, "Brand A", "Spare Parts", "Dimension AAA", "Turbocharger 876 543" },
                    { 200001, "Q8", "Chemicals", "208 Liters", "Q8 Mahler G5 SAE 40" },
                    { 200002, "Shell", "Chemicals", "20 Liters", "Shell Corena S4 R" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseRequests",
                columns: new[] { "PurchaseId", "CompanyId", "Purpose", "Status", "Type" },
                values: new object[,]
                {
                    { 435000001, 1, "For repair and maintenance of Engine 1", "For approval", "Normal" },
                    { 435000002, 2, "For repair and maintenance of Engine 2", "For approval", "Urgent" },
                    { 435000003, 3, "For repair and maintenance of Engine 3", "For approval", "Urgent" },
                    { 435000004, 1, "For 4000RH PMS of Air Compressor X", "For approval", "Normal" },
                    { 435000005, 1, "For annual maintenance of T/C for Engine 10", "For approval", "Normal" },
                    { 435000006, 2, "For 62000RH PMS of Engine 7", "For approval", "Normal" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseRequestMaterials",
                columns: new[] { "MaterialId", "PurchaseRequestId", "Quantity" },
                values: new object[,]
                {
                    { 100001, 435000001, 1f },
                    { 100001, 435000002, 1f },
                    { 100001, 435000003, 1f },
                    { 100002, 435000001, 2f },
                    { 100002, 435000003, 4f },
                    { 100002, 435000006, 18f },
                    { 100003, 435000005, 1f },
                    { 200001, 435000003, 3f },
                    { 200001, 435000006, 1f },
                    { 200002, 435000004, 2f }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Materials_MaterialId",
                table: "Inventories",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseRequestMaterials_Materials_MaterialId",
                table: "PurchaseRequestMaterials",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseRequestMaterials_PurchaseRequests_PurchaseRequestId",
                table: "PurchaseRequestMaterials",
                column: "PurchaseRequestId",
                principalTable: "PurchaseRequests",
                principalColumn: "PurchaseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Materials_MaterialId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequestMaterials_Materials_MaterialId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseRequestMaterials_PurchaseRequests_PurchaseRequestId",
                table: "PurchaseRequestMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseRequests",
                table: "PurchaseRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 100001, 435000001 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 100001, 435000002 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 100001, 435000003 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 100002, 435000001 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 100002, 435000003 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 100002, 435000006 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 100003, 435000005 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 200001, 435000003 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 200001, 435000006 });

            migrationBuilder.DeleteData(
                table: "PurchaseRequestMaterials",
                keyColumns: new[] { "MaterialId", "PurchaseRequestId" },
                keyValues: new object[] { 200002, 435000004 });

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialCode",
                keyValue: 100001);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialCode",
                keyValue: 100002);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialCode",
                keyValue: 100003);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialCode",
                keyValue: 200001);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialCode",
                keyValue: 200002);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "PurchaseId",
                keyValue: 435000001);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "PurchaseId",
                keyValue: 435000002);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "PurchaseId",
                keyValue: 435000003);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "PurchaseId",
                keyValue: 435000004);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "PurchaseId",
                keyValue: 435000005);

            migrationBuilder.DeleteData(
                table: "PurchaseRequests",
                keyColumn: "PurchaseId",
                keyValue: 435000006);

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "PurchaseRequests");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "PurchaseRequests",
                type: "int",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PurchaseRequests",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseRequests",
                table: "PurchaseRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaterialId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "MaterialId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "MaterialId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4,
                column: "MaterialId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5,
                column: "MaterialId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 6,
                column: "MaterialId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 7,
                column: "MaterialId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 8,
                column: "MaterialId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 9,
                column: "MaterialId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 10,
                column: "MaterialId",
                value: 5);

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

            migrationBuilder.InsertData(
                table: "PurchaseRequests",
                columns: new[] { "Id", "CompanyId", "PurchaseId", "Purpose", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 1, 435000001, "For repair and maintenance of Engine 1", "For approval", "Normal" },
                    { 2, 2, 435000002, "For repair and maintenance of Engine 2", "For approval", "Urgent" },
                    { 3, 3, 435000003, "For repair and maintenance of Engine 3", "For approval", "Urgent" },
                    { 4, 1, 435000004, "For 4000RH PMS of Air Compressor X", "For approval", "Normal" },
                    { 5, 1, 435000005, "For annual maintenance of T/C for Engine 10", "For approval", "Normal" },
                    { 6, 2, 435000006, "For 62000RH PMS of Engine 7", "For approval", "Normal" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRequests_PurchaseId",
                table: "PurchaseRequests",
                column: "PurchaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialCode",
                table: "Materials",
                column: "MaterialCode",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Materials_MaterialId",
                table: "Inventories",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}

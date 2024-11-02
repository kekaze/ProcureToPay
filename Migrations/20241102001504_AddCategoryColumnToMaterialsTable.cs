using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcureToPay.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryColumnToMaterialsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Materials");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class ChangecategorytblcolNamewithfluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "tbl_Category");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_Category",
                newName: "CategoryName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Category",
                table: "tbl_Category",
                column: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Category",
                table: "tbl_Category");

            migrationBuilder.RenameTable(
                name: "tbl_Category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Category_Id");
        }
    }
}

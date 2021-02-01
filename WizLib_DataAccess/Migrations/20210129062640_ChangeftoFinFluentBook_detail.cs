using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class ChangeftoFinFluentBook_detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_fluent_BookDetails",
                table: "fluent_BookDetails");

            migrationBuilder.RenameTable(
                name: "fluent_BookDetails",
                newName: "Fluent_BookDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookDetails",
                table: "Fluent_BookDetails",
                column: "BookDetail_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookDetails",
                table: "Fluent_BookDetails");

            migrationBuilder.RenameTable(
                name: "Fluent_BookDetails",
                newName: "fluent_BookDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fluent_BookDetails",
                table: "fluent_BookDetails",
                column: "BookDetail_Id");
        }
    }
}

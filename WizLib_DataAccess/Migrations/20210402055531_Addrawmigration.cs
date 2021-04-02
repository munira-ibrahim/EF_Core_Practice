using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class Addrawmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into tbl_Category values('cat 1')");
            migrationBuilder.Sql("Insert into tbl_Category values('cat 2')");
            migrationBuilder.Sql("Insert into tbl_Category values('cat 3')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

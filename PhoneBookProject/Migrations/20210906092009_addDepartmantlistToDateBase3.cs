using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookProject.Migrations
{
    public partial class addDepartmantlistToDateBase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Departmant",
                table: "DataPhonelist",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departmant",
                table: "DataPhonelist");
        }
    }
}

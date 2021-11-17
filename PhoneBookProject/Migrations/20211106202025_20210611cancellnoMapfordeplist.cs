using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookProject.Migrations
{
    public partial class _20210611cancellnoMapfordeplist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ListOfDepartmant",
                table: "DataPhonelist",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListOfDepartmant",
                table: "DataPhonelist");
        }
    }
}

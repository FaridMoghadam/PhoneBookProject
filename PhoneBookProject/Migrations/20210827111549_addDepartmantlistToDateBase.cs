using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookProject.Migrations
{
    public partial class addDepartmantlistToDateBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataPhonelist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Lname = table.Column<string>(type: "nvarchar(120)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Departmant = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Division = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CellPhone = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPhonelist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depatmantlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depatmantlist", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataPhonelist");

            migrationBuilder.DropTable(
                name: "Depatmantlist");
        }
    }
}

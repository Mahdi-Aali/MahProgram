using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MahProgram.Web.Migrations
{
    public partial class Add_Employee_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Skill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitHubLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LinkedinLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    InstagramLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TelegramLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MahProgram.Web.Migrations
{
    public partial class Add_ContactUsAnswere_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUsAnsweres",
                columns: table => new
                {
                    ContactUsAnswereId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUsId = table.Column<int>(type: "int", nullable: false),
                    ResponseMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsAnsweres", x => x.ContactUsAnswereId);
                    table.ForeignKey(
                        name: "FK_ContactUsAnsweres_ContactUs_ContactUsId",
                        column: x => x.ContactUsId,
                        principalTable: "ContactUs",
                        principalColumn: "ContactUsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactUsAnsweres_ContactUsId",
                table: "ContactUsAnsweres",
                column: "ContactUsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUsAnsweres");
        }
    }
}

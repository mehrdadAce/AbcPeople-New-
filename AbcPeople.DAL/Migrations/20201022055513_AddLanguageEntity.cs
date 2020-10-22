using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddLanguageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotherLanguage",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "MotherLanguageId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Acronym = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MotherLanguageId",
                table: "Employees",
                column: "MotherLanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Language_MotherLanguageId",
                table: "Employees",
                column: "MotherLanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Language_MotherLanguageId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MotherLanguageId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MotherLanguageId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "MotherLanguage",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

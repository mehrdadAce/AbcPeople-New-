using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddSeniorityLevelEntityWithRelationToEmployeeTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeniorityLevelId",
                table: "EmployeeTitles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SeniorityLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Level = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorityLevels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTitles_SeniorityLevelId",
                table: "EmployeeTitles",
                column: "SeniorityLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTitles_SeniorityLevels_SeniorityLevelId",
                table: "EmployeeTitles",
                column: "SeniorityLevelId",
                principalTable: "SeniorityLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTitles_SeniorityLevels_SeniorityLevelId",
                table: "EmployeeTitles");

            migrationBuilder.DropTable(
                name: "SeniorityLevels");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTitles_SeniorityLevelId",
                table: "EmployeeTitles");

            migrationBuilder.DropColumn(
                name: "SeniorityLevelId",
                table: "EmployeeTitles");
        }
    }
}

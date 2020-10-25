using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddFkPksCompetencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KnowledgeLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Level = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgeLevels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCompetencies_KnowledgeLevelId",
                table: "EmployeeCompetencies",
                column: "KnowledgeLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCompetencies_KnowledgeLevels_KnowledgeLevelId",
                table: "EmployeeCompetencies",
                column: "KnowledgeLevelId",
                principalTable: "KnowledgeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCompetencies_KnowledgeLevels_KnowledgeLevelId",
                table: "EmployeeCompetencies");

            migrationBuilder.DropTable(
                name: "KnowledgeLevels");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeCompetencies_KnowledgeLevelId",
                table: "EmployeeCompetencies");
        }
    }
}

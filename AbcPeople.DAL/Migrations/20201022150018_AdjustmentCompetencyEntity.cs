using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AdjustmentCompetencyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FamilySituation",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "FamilySituationId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Competencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CompetencyCategoryId = table.Column<int>(nullable: false),
                    EmployeeCompetencyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competencies_EmployeeCompetencies_EmployeeCompetencyId",
                        column: x => x.EmployeeCompetencyId,
                        principalTable: "EmployeeCompetencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageSkills_EmployeeId",
                table: "LanguageSkills",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FamilySituationId",
                table: "Employees",
                column: "FamilySituationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCompetencies_EmployeeId",
                table: "EmployeeCompetencies",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Competencies_EmployeeCompetencyId",
                table: "Competencies",
                column: "EmployeeCompetencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCompetencies_Employees_EmployeeId",
                table: "EmployeeCompetencies",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_FamilySituations_FamilySituationId",
                table: "Employees",
                column: "FamilySituationId",
                principalTable: "FamilySituations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageSkills_Employees_EmployeeId",
                table: "LanguageSkills",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCompetencies_Employees_EmployeeId",
                table: "EmployeeCompetencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_FamilySituations_FamilySituationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageSkills_Employees_EmployeeId",
                table: "LanguageSkills");

            migrationBuilder.DropTable(
                name: "Competencies");

            migrationBuilder.DropIndex(
                name: "IX_LanguageSkills_EmployeeId",
                table: "LanguageSkills");

            migrationBuilder.DropIndex(
                name: "IX_Employees_FamilySituationId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeCompetencies_EmployeeId",
                table: "EmployeeCompetencies");

            migrationBuilder.DropColumn(
                name: "FamilySituationId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "FamilySituation",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

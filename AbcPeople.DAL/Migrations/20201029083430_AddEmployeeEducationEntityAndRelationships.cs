using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddEmployeeEducationEntityAndRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducations_EducationId",
                table: "EmployeeEducations",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducations_EmployeeId",
                table: "EmployeeEducations",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEducations_Educations_EducationId",
                table: "EmployeeEducations",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEducations_Employees_EmployeeId",
                table: "EmployeeEducations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEducations_Educations_EducationId",
                table: "EmployeeEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEducations_Employees_EmployeeId",
                table: "EmployeeEducations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeEducations_EducationId",
                table: "EmployeeEducations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeEducations_EmployeeId",
                table: "EmployeeEducations");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class LinkingEntitiesExamAndEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmployeeExams_EmployeeId",
                table: "EmployeeExams",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeExams_ExamId",
                table: "EmployeeExams",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeExams_Employees_EmployeeId",
                table: "EmployeeExams",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeExams_Exams_ExamId",
                table: "EmployeeExams",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeExams_Employees_EmployeeId",
                table: "EmployeeExams");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeExams_Exams_ExamId",
                table: "EmployeeExams");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeExams_EmployeeId",
                table: "EmployeeExams");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeExams_ExamId",
                table: "EmployeeExams");
        }
    }
}

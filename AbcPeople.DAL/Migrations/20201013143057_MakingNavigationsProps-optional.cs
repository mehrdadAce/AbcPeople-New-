using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class MakingNavigationsPropsoptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Employees_EmployeeId",
                table: "WorkExperiences");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "WorkExperiences",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Employees_EmployeeId",
                table: "WorkExperiences",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Employees_EmployeeId",
                table: "WorkExperiences");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "WorkExperiences",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Employees_EmployeeId",
                table: "WorkExperiences",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

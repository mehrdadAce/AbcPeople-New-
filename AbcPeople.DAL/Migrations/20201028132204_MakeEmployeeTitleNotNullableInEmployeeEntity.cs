using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class MakeEmployeeTitleNotNullableInEmployeeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeTitles_EmployeeTitleId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeTitleId",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeTitles_EmployeeTitleId",
                table: "Employees",
                column: "EmployeeTitleId",
                principalTable: "EmployeeTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeTitles_EmployeeTitleId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeTitleId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeTitles_EmployeeTitleId",
                table: "Employees",
                column: "EmployeeTitleId",
                principalTable: "EmployeeTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

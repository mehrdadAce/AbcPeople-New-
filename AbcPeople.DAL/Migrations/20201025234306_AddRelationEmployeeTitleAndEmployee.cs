using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddRelationEmployeeTitleAndEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeTitleId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTitleId",
                table: "Employees",
                column: "EmployeeTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeTitles_EmployeeTitleId",
                table: "Employees",
                column: "EmployeeTitleId",
                principalTable: "EmployeeTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeTitles_EmployeeTitleId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeTitleId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeTitleId",
                table: "Employees");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddNavPropNationality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalityId",
                table: "Employees",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                table: "Employees",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_NationalityId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

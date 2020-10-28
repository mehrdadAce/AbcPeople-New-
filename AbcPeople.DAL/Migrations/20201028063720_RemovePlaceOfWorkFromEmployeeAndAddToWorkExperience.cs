using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class RemovePlaceOfWorkFromEmployeeAndAddToWorkExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Addresses_PlaceOfWorkAddressId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PlaceOfWorkAddressId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PlaceOfWorkAddressId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "PlaceOfWorkAddressId",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_PlaceOfWorkAddressId",
                table: "WorkExperiences",
                column: "PlaceOfWorkAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Addresses_PlaceOfWorkAddressId",
                table: "WorkExperiences",
                column: "PlaceOfWorkAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Addresses_PlaceOfWorkAddressId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_PlaceOfWorkAddressId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "PlaceOfWorkAddressId",
                table: "WorkExperiences");

            migrationBuilder.AddColumn<int>(
                name: "PlaceOfWorkAddressId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PlaceOfWorkAddressId",
                table: "Employees",
                column: "PlaceOfWorkAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Addresses_PlaceOfWorkAddressId",
                table: "Employees",
                column: "PlaceOfWorkAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

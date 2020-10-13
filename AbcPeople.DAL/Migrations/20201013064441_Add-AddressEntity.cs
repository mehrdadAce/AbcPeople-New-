using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddAddressEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeAddressId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaceOfWorkAddressId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    StreetName = table.Column<string>(nullable: false),
                    HouseNumber = table.Column<string>(nullable: false),
                    Postcode = table.Column<string>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_HomeAddressId",
                table: "Employees",
                column: "HomeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PlaceOfWorkAddressId",
                table: "Employees",
                column: "PlaceOfWorkAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Addresses_HomeAddressId",
                table: "Employees",
                column: "HomeAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Addresses_PlaceOfWorkAddressId",
                table: "Employees",
                column: "PlaceOfWorkAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Addresses_HomeAddressId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Addresses_PlaceOfWorkAddressId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Employees_HomeAddressId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PlaceOfWorkAddressId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HomeAddressId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PlaceOfWorkAddressId",
                table: "Employees");
        }
    }
}

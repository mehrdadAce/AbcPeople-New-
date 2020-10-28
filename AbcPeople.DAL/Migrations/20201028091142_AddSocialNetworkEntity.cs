using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddSocialNetworkEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_FamilySituations_FamilySituationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Addresses_HomeAddressId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "NationalityId",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HomeAddressId",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FamilySituationId",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SocialNetworkId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SocialNetworks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LinkedIn = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Blog = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialNetworks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SocialNetworkId",
                table: "Employees",
                column: "SocialNetworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_FamilySituations_FamilySituationId",
                table: "Employees",
                column: "FamilySituationId",
                principalTable: "FamilySituations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Addresses_HomeAddressId",
                table: "Employees",
                column: "HomeAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                table: "Employees",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SocialNetworks_SocialNetworkId",
                table: "Employees",
                column: "SocialNetworkId",
                principalTable: "SocialNetworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_FamilySituations_FamilySituationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Addresses_HomeAddressId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SocialNetworks_SocialNetworkId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "SocialNetworks");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SocialNetworkId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SocialNetworkId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "NationalityId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HomeAddressId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FamilySituationId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_FamilySituations_FamilySituationId",
                table: "Employees",
                column: "FamilySituationId",
                principalTable: "FamilySituations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Addresses_HomeAddressId",
                table: "Employees",
                column: "HomeAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                table: "Employees",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

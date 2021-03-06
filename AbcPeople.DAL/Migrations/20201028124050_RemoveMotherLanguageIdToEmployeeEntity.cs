﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class RemoveMotherLanguageIdToEmployeeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Languages_MotherLanguageId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MotherLanguageId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MotherLanguageId",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MotherLanguageId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MotherLanguageId",
                table: "Employees",
                column: "MotherLanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Languages_MotherLanguageId",
                table: "Employees",
                column: "MotherLanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

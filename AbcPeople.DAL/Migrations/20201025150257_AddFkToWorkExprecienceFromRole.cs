using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddFkToWorkExprecienceFromRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_RoleId",
                table: "WorkExperiences",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Roles_RoleId",
                table: "WorkExperiences",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Roles_RoleId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_RoleId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "WorkExperiences");
        }
    }
}

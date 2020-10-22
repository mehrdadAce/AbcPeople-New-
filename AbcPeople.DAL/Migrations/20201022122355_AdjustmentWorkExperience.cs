using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AdjustmentWorkExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "WorkExperiences",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "WorkExperiences");
        }
    }
}

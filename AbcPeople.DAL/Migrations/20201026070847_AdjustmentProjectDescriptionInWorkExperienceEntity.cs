using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AdjustmentProjectDescriptionInWorkExperienceEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectDescription",
                table: "WorkExperiences");

            migrationBuilder.AddColumn<string>(
                name: "ProjectDescriptionEn",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectDescriptionNl",
                table: "WorkExperiences",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectDescriptionEn",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "ProjectDescriptionNl",
                table: "WorkExperiences");

            migrationBuilder.AddColumn<string>(
                name: "ProjectDescription",
                table: "WorkExperiences",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

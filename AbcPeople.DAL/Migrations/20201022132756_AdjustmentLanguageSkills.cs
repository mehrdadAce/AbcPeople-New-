using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AdjustmentLanguageSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageSkill",
                table: "LanguageSkill");

            migrationBuilder.RenameTable(
                name: "LanguageSkill",
                newName: "LanguageSkills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageSkills",
                table: "LanguageSkills",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageSkills",
                table: "LanguageSkills");

            migrationBuilder.RenameTable(
                name: "LanguageSkills",
                newName: "LanguageSkill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageSkill",
                table: "LanguageSkill",
                column: "Id");
        }
    }
}

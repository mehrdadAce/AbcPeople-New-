using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddFkPkToLanguageSkillsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "LanguageSkills",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LanguageSkills_LanguageId",
                table: "LanguageSkills",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageSkills_Languages_LanguageId",
                table: "LanguageSkills",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LanguageSkills_Languages_LanguageId",
                table: "LanguageSkills");

            migrationBuilder.DropIndex(
                name: "IX_LanguageSkills_LanguageId",
                table: "LanguageSkills");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "LanguageSkills");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class ChangeTitleToNameInExamEntityAndCertificateEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Certificates");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Exams",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Certificates",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Certificates");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

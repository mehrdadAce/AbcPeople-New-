using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddShortDescriptionNlENAndHobbysToEmployeeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescriptionEN",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescriptionNL",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescriptionEN",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ShortDescriptionNL",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

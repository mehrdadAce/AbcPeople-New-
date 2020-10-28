using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class MakingPlaceOfWorkExperienceNotNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Addresses_PlaceOfWorkAddressId",
                table: "WorkExperiences");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceOfWorkAddressId",
                table: "WorkExperiences",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Addresses_PlaceOfWorkAddressId",
                table: "WorkExperiences",
                column: "PlaceOfWorkAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Addresses_PlaceOfWorkAddressId",
                table: "WorkExperiences");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceOfWorkAddressId",
                table: "WorkExperiences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Addresses_PlaceOfWorkAddressId",
                table: "WorkExperiences",
                column: "PlaceOfWorkAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

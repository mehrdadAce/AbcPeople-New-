using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbcPeople.DAL.Migrations
{
    public partial class AddExamEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCertificate_Certificate_CertificateId",
                table: "EmployeeCertificate");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCertificate_Employees_EmployeeId",
                table: "EmployeeCertificate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeCertificate",
                table: "EmployeeCertificate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificate",
                table: "Certificate");

            migrationBuilder.RenameTable(
                name: "EmployeeCertificate",
                newName: "EmployeeCertificates");

            migrationBuilder.RenameTable(
                name: "Certificate",
                newName: "Certificates");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeCertificate_EmployeeId",
                table: "EmployeeCertificates",
                newName: "IX_EmployeeCertificates_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeCertificate_CertificateId",
                table: "EmployeeCertificates",
                newName: "IX_EmployeeCertificates_CertificateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeCertificates",
                table: "EmployeeCertificates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCertificates_Certificates_CertificateId",
                table: "EmployeeCertificates",
                column: "CertificateId",
                principalTable: "Certificates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCertificates_Employees_EmployeeId",
                table: "EmployeeCertificates",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCertificates_Certificates_CertificateId",
                table: "EmployeeCertificates");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCertificates_Employees_EmployeeId",
                table: "EmployeeCertificates");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeCertificates",
                table: "EmployeeCertificates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates");

            migrationBuilder.RenameTable(
                name: "EmployeeCertificates",
                newName: "EmployeeCertificate");

            migrationBuilder.RenameTable(
                name: "Certificates",
                newName: "Certificate");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeCertificates_EmployeeId",
                table: "EmployeeCertificate",
                newName: "IX_EmployeeCertificate_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeCertificates_CertificateId",
                table: "EmployeeCertificate",
                newName: "IX_EmployeeCertificate_CertificateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeCertificate",
                table: "EmployeeCertificate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificate",
                table: "Certificate",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCertificate_Certificate_CertificateId",
                table: "EmployeeCertificate",
                column: "CertificateId",
                principalTable: "Certificate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCertificate_Employees_EmployeeId",
                table: "EmployeeCertificate",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

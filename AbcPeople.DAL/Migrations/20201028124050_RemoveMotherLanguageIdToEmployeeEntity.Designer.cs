﻿// <auto-generated />
using System;
using AbcPeople.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AbcPeople.DAL.Migrations
{
    [DbContext(typeof(AbcPeopleEntities))]
    [Migration("20201028124050_RemoveMotherLanguageIdToEmployeeEntity")]
    partial class RemoveMotherLanguageIdToEmployeeEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AbcPeople.DAL.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postalcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Competency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetencyCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeCompetencyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeCompetencyId");

                    b.ToTable("Competencies");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginDateOfWork")
                        .HasColumnType("datetime2");

                    b.Property<string>("Coach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeTitleId")
                        .HasColumnType("int");

                    b.Property<int>("FamilySituationId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Gsm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbys")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomeAddressId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("PrivateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescriptionEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescriptionNL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialNetworkId")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeTitleId");

                    b.HasIndex("FamilySituationId");

                    b.HasIndex("HomeAddressId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("RoleId");

                    b.HasIndex("SocialNetworkId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeCertificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCertificates");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeCompetency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("KnowledgeLevelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("KnowledgeLevelId");

                    b.ToTable("EmployeeCompetencies");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCourses");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeEducation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EmployeeEducations");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ExamId");

                    b.ToTable("EmployeeExams");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SeniorityLevelId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SeniorityLevelId");

                    b.ToTable("EmployeeTitles");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.FamilySituation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FamilySituations");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.KnowledgeLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KnowledgeLevels");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acronym")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.LanguageSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("ReadLevel")
                        .HasColumnType("int");

                    b.Property<int>("SpeakLevel")
                        .HasColumnType("int");

                    b.Property<int>("WriteLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LanguageId");

                    b.ToTable("LanguageSkills");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.ProfileAdjustment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ProfileAdjustments");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.SeniorityLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SeniorityLevels");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.SocialNetwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Blog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SocialNetworks");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlaceOfWorkAddressId")
                        .HasColumnType("int");

                    b.Property<string>("ProjectDescriptionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDescriptionNl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PlaceOfWorkAddressId");

                    b.HasIndex("RoleId");

                    b.ToTable("WorkExperiences");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Address", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Competency", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.EmployeeCompetency", null)
                        .WithMany("Competency")
                        .HasForeignKey("EmployeeCompetencyId");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.Employee", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.EmployeeTitle", "EmployeeTitle")
                        .WithMany()
                        .HasForeignKey("EmployeeTitleId");

                    b.HasOne("AbcPeople.DAL.Entities.FamilySituation", "FamilySituation")
                        .WithMany()
                        .HasForeignKey("FamilySituationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Address", "HomeAddress")
                        .WithMany()
                        .HasForeignKey("HomeAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("AbcPeople.DAL.Entities.SocialNetwork", "SocialNetwork")
                        .WithMany()
                        .HasForeignKey("SocialNetworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeCertificate", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.Certificate", "Certificate")
                        .WithMany("EmployeeCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Employee", null)
                        .WithMany("EmployeeCertificates")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeCompetency", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.Employee", "Employee")
                        .WithMany("EmployeeCompetencies")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.KnowledgeLevel", "Level")
                        .WithMany()
                        .HasForeignKey("KnowledgeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeCourse", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Employee", null)
                        .WithMany("EmployeeCourses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeExam", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.Employee", null)
                        .WithMany("EmployeeExams")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Exam", "Exam")
                        .WithMany("EmployeeExams")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.EmployeeTitle", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.SeniorityLevel", "SeniorityLevel")
                        .WithMany()
                        .HasForeignKey("SeniorityLevelId");
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.LanguageSkill", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.Employee", null)
                        .WithMany("LanguageSkills")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.ProfileAdjustment", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.Employee", "Employee")
                        .WithMany("ProfileAdjustments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbcPeople.DAL.Entities.WorkExperience", b =>
                {
                    b.HasOne("AbcPeople.DAL.Entities.Employee", "Employee")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("AbcPeople.DAL.Entities.Address", "PlaceOfWorkAddress")
                        .WithMany()
                        .HasForeignKey("PlaceOfWorkAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcPeople.DAL.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}

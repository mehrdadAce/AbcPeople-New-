using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace AbcPeople.DAL
{
    public class AbcPeopleEntities : DbContext 
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ProfileAdjustment> ProfileAdjustments { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<EmployeeCompetency> EmployeeCompetencies { get; set; }
        public DbSet<FamilySituation> FamilySituations { get; set; }
        public DbSet<EmployeeExam> EmployeeExams { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Course> Cources { get; set; }
        public DbSet<LanguageSkill> LanguageSkills { get; set; }
        public DbSet<Competency> Competencies { get; set; }
        public DbSet<KnowledgeLevel> KnowledgeLevels { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<EmployeeTitle> EmployeeTitles { get; set; }
        public DbSet<SeniorityLevel> SeniorityLevels { get; set; }

        public AbcPeopleEntities(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new WorkExperienceEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CityEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileAdjustmentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeCompetencyEntityConfiguration());
            modelBuilder.ApplyConfiguration(new FamilySituationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeExamEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEducationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new NationalityEntityConfiguration()); 
            modelBuilder.ApplyConfiguration(new CourseEntityConfiguration()); 
            modelBuilder.ApplyConfiguration(new LanguageSkillEntityConfiguration()); 
            modelBuilder.ApplyConfiguration(new CompetencyEntityConfiguration()); 
            modelBuilder.ApplyConfiguration(new KnowledgeLevelEntityConfiguration()); 
            modelBuilder.ApplyConfiguration(new RoleEntityConfiguration()); 
            modelBuilder.ApplyConfiguration(new EmployeeTitleEntityConfiguration()); 
            modelBuilder.ApplyConfiguration(new SeniorityLevelEntityConfiguration()); 
        }
    }
}

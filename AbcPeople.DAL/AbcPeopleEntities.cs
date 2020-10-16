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
        }
    }
}

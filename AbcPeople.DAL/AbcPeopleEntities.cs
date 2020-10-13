using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL
{
    public class AbcPeopleEntities : DbContext  //-> context klasse
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public AbcPeopleEntities(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new WorkExperienceEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
        }
    }
}

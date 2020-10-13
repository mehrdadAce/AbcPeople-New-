using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EmployeeEntityConfiguration : BaseEntityConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.FirstName).HasMaxLength(50);
            builder.Property(p => p.LastName).HasMaxLength(100);

            builder.HasMany(p => p.WorkExperiences).WithOne(p => p.Employee);
            //builder.HasOne(p => p.HomeAddress).WithOne(p => p.Employee);
            //builder.HasOne(p => p.PlaceOfWorkAddress).WithOne(p => p.Employee);
        }
    }
}

using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class CityEntityConfiguration : BaseEntityConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).IsRequired();

            // builder.HasOne(p => p.Employee).WithMany().HasForeignKey(p => p.EmployeeId); // relaties in 2 richrtingen definieren! => ook in EmployeeConfigurations

            //builder.HasOne(p => p.Address).WithOne(p => p.City).HasForeignKey<Address>(x => x.CityId);
        }
    }
}

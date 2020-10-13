using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class WorkExperienceEntityConfiguration : BaseEntityConfiguration<WorkExperience>
    {
        public override void Configure(EntityTypeBuilder<WorkExperience> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.StartDate).IsRequired();
            builder.Property(p => p.CompanyName).IsRequired();

            // builder.HasOne(p => p.Employee).WithMany().HasForeignKey(p => p.EmployeeId); // relaties in 2 richrtingen definieren! => ook in EmployeeConfigurations
            
        }
    }
}

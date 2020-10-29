using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EmployeeEducationEntityConfiguration : BaseEntityConfiguration<EmployeeEducation>
    {
        public override void Configure(EntityTypeBuilder<EmployeeEducation> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.EducationId).IsRequired();
            builder.Property(p => p.EmployeeId).IsRequired();
        }
    }
}

using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EmployeeTitleEntityConfiguration : BaseEntityConfiguration<EmployeeTitle>
    {
        public override void Configure(EntityTypeBuilder<EmployeeTitle> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Title).IsRequired();
            builder.HasOne(p => p.SeniorityLevel);
        }
    }
}

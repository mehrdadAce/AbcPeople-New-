using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EducationEntityConfiguration : BaseEntityConfiguration<Education>
    {
        public override void Configure(EntityTypeBuilder<Education> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).IsRequired();
        }
    }
}

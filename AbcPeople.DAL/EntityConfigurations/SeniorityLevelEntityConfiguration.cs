using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class SeniorityLevelEntityConfiguration : BaseEntityConfiguration<SeniorityLevel>
    {
        public override void Configure(EntityTypeBuilder<SeniorityLevel> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Level).IsRequired();
        }
    }
}

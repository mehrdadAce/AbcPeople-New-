using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class CompetencyEntityConfiguration : BaseEntityConfiguration<Competency>
    {
        public override void Configure(EntityTypeBuilder<Competency> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).IsRequired();
        }
    }
}

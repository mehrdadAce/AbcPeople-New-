using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class FamilySituationEntityConfiguration : BaseEntityConfiguration<FamilySituation>
    {
        public override void Configure(EntityTypeBuilder<FamilySituation> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).IsRequired();
        }
    }
}

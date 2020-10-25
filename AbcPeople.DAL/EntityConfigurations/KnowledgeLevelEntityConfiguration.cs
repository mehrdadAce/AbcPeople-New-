using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class KnowledgeLevelEntityConfiguration : BaseEntityConfiguration<KnowledgeLevel>
    {
        public override void Configure(EntityTypeBuilder<KnowledgeLevel> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Level).IsRequired();
        }
    }
}

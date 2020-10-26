using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{    public class LanguageSkillEntityConfiguration : BaseEntityConfiguration<LanguageSkill>
    {
        public override void Configure(EntityTypeBuilder<LanguageSkill> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.ReadLevel).IsRequired();
            builder.Property(p => p.WriteLevel).IsRequired();
            builder.Property(p => p.SpeakLevel).IsRequired();
            builder.Property(p => p.EmployeeId).IsRequired();
            builder.HasOne(p => p.Language);
        }
    }
}

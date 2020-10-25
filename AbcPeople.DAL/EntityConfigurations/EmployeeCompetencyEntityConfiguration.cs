using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EmployeeCompetencyEntityConfiguration : BaseEntityConfiguration<EmployeeCompetency>
    {
        public override void Configure(EntityTypeBuilder<EmployeeCompetency> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.EmployeeId).IsRequired();
            builder.Property(p => p.KnowledgeLevelId).IsRequired();
            builder.Property(p => p.CompetencyId).IsRequired();

            builder.HasMany(p => p.Competency);
        }
    }
}

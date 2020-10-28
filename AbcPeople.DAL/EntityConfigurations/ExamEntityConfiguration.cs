using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class ExamEntityConfiguration : BaseEntityConfiguration<Exam>
    {
        public override void Configure(EntityTypeBuilder<Exam> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).IsRequired();

            builder.HasMany(p => p.EmployeeExams);
        }
    }
}

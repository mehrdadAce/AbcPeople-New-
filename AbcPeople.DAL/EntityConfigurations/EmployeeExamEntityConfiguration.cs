using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EmployeeExamEntityConfiguration : BaseEntityConfiguration<EmployeeExam>
    {
        public override void Configure(EntityTypeBuilder<EmployeeExam> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.EmployeeId).IsRequired();
            builder.Property(p => p.ExamId).IsRequired();
        }
    }

}

using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EmployeeCourseEntityConfiguration : BaseEntityConfiguration<EmployeeCourse>
    {
        public override void Configure(EntityTypeBuilder<EmployeeCourse> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.EmployeeId).IsRequired();
            builder.Property(p => p.CourseId).IsRequired();
        }
    }
}

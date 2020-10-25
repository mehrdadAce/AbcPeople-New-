using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EmployeeEntityConfiguration : BaseEntityConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.FirstName).HasMaxLength(50);
            builder.Property(p => p.LastName).HasMaxLength(100);

            builder.HasMany(p => p.WorkExperiences);

            builder.HasOne(p => p.HomeAddress);
            builder.HasOne(p => p.PlaceOfWorkAddress);

            builder.HasMany(p => p.ProfileAdjustments);

            builder.HasOne(p => p.MotherLanguage);

            builder.HasMany(p => p.EmployeeCompetencies);
            builder.HasMany(p => p.LanguageSkills);

            builder.HasOne(p => p.FamilySituation);
            builder.HasOne(p => p.Nationality);
            builder.HasOne(p => p.Role);
        }
    }
}

using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class ProfileAdjustmentEntityConfiguration : BaseEntityConfiguration<ProfileAdjustment>
    {
        public override void Configure(EntityTypeBuilder<ProfileAdjustment> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.EmployeeId).IsRequired();
            builder.Property(p => p.Timestamp).IsRequired();
        }
    }
}

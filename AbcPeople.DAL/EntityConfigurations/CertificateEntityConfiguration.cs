using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class CertificateEntityConfiguration : BaseEntityConfiguration<Certificate>
    {
        public override void Configure(EntityTypeBuilder<Certificate> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).IsRequired();
            builder.HasMany(p => p.EmployeeCertificates);
        }
    }
}

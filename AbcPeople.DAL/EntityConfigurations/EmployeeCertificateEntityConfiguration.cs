using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class EmployeeCertificateEntityConfiguration : BaseEntityConfiguration<EmployeeCertificate>
    {
        public override void Configure(EntityTypeBuilder<EmployeeCertificate> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.CertificateId).IsRequired();
            builder.Property(p => p.EmployeeId).IsRequired();
        }
    }
}

using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class AddressEntityConfiguration : BaseEntityConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.StreetName).IsRequired();
            builder.Property(p => p.HouseNumber).IsRequired();
            builder.Property(p => p.Postcode).IsRequired();
            builder.Property(p => p.CityId).IsRequired();
            builder.Property(p => p.CountryId).IsRequired();
        }
    }
}

using AbcPeople.DAL.Entities;
using AbcPeople.DAL.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbcPeople.DAL.EntityConfigurations
{
    public class SocialNetworkEntityConfiguration : BaseEntityConfiguration<SocialNetwork>
    {
        public override void Configure(EntityTypeBuilder<SocialNetwork> builder)
        {
            base.Configure(builder);
        }
    }

}

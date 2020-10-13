using AbcPeople.DAL.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcPeople.DAL.EntityConfigurations.Base
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity  // -> abstracte klassen kan je niet instantieren
    {
        public virtual void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.HasQueryFilter(e => !e.DeletedOn.HasValue);
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.CreatedOn).IsRequired();
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vega.Models;

namespace vega.Persistence.Configuration
{
    public class EntityMap : EntityTypeConfiguration<Entity>
    {
        public override void Map(EntityTypeBuilder<Entity> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
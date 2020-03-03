using System;
using Star_Wars.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Star_Wars.Infra.Data.Mappings
{
    public class StarshipMap : MapBase<Starship>
    {
        public override void Configure(EntityTypeBuilder<Starship> builder)
        {
            base.Configure(builder);
            builder.ToTable("Starship");
             
            builder.Property(c => c.name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .HasField("NAME")
                .IsRequired();

            builder.Property(c => c.model)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .HasField("MODEL")
                .IsRequired();
        }
    }
}

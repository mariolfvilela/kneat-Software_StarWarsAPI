using System;
using StarWars.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace StarWars.Infra.Data.Mappings
{
    public class StarshipMap : MapBase<Starship>
    {
        public override void Configure(EntityTypeBuilder<Starship> builder)
        {
            base.Configure(builder);
            builder.ToTable("Starship");
             
            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .HasField("NAME")
                .IsRequired();

            builder.Property(c => c.Model)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .HasField("MODEL")
                .IsRequired();
        }
    }
}

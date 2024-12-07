using EmpresaMusical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Repository.Mapping
{
    public class MusicaMap : IEntityTypeConfiguration<Musica>
    {
        public void Configure(EntityTypeBuilder<Musica> builder)
        {
            builder.ToTable("Musica");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.NomeMusica)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Gravadora)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Album);
                
        }
    }
}

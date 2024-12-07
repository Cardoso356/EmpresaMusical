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
    public class AlbumMap : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Album");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.TituloAlbum)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Formato)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Data)
                .IsRequired()
                .HasColumnType("varchar(100)");

        }
    }
}

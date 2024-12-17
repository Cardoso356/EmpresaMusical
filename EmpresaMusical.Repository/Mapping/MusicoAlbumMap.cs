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
    public class MusicoAlbumMap : IEntityTypeConfiguration<MusicoAlbum>
    {
        public void Configure(EntityTypeBuilder<MusicoAlbum> builder)
        {
            builder.ToTable("MusicoAlbum");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Musico);
                
            builder.HasOne(prop => prop.Album);
                
        }
    }
}

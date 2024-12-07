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
    public class InstrumentoMap : IEntityTypeConfiguration<Instrumento>
    {
        public void Configure(EntityTypeBuilder<Instrumento> builder)
        {
            builder.ToTable("Instrumento");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.NomeInstrumento)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Tipo)
                .IsRequired()
                .HasColumnType("varchar(100)");            
            
        }
    }
}

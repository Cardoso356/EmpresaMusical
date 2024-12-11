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
    public class MusicoMap : IEntityTypeConfiguration<Musico>
    {
        public void Configure(EntityTypeBuilder<Musico> builder)
        {
            builder.ToTable("Musico");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.NomeMusico)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Login)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");

        }
    }
}

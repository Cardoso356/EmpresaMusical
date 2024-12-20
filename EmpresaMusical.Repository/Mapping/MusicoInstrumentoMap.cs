﻿using EmpresaMusical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Repository.Mapping
{
    public class MusicoInstrumentoMap : IEntityTypeConfiguration<MusicoInstrumento>
    {
        public void Configure(EntityTypeBuilder<MusicoInstrumento> builder)
        {
            builder.ToTable("MusicoInstrumento");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Musico);
                
            builder.HasOne(prop => prop.Instrumento);
                
        }
    }
}

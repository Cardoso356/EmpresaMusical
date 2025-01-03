﻿using EmpresaMusical.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Domain.Entities
{
    public class Instrumento : BaseEntity<int>
    {
        public Instrumento()
        {

        }
        public Instrumento(int id, string nomeInstrumento, string tipo)
        {
            Id = id;
            NomeInstrumento = nomeInstrumento;
            Tipo = tipo;
        }

        public string? NomeInstrumento { get; set; }
        public string? Tipo { get; set; }

    }
}

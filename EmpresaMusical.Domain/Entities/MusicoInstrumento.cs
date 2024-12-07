using EmpresaMusical.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Domain.Entities
{
    public class MusicoInstrumento : BaseEntity<int>
    {
        public MusicoInstrumento()
        {

        }

        public MusicoInstrumento(Musico? musico, Instrumento? instrumento)
        {
            Musico = musico;
            Instrumento = instrumento;
        }

        public Musico? Musico { get; set; }
        public Instrumento? Instrumento { get; set; }

    }
}

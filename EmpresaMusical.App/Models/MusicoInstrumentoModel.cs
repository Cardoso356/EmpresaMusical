using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.App.Models
{
    public class MusicoInstrumentoModel
    {
        public int IdMusico { get; set; }
        public string? Musico { get; set; }
        public int IdInstrumento { get; set; }
        public string? Instrumento { get; set; }
    }
}

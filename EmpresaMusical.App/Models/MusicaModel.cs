using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.App.Models
{
    public class MusicaModel
    {
        public int Id { get; set; }
        public string? NomeMusica { get; set; }
        public string? Gravadora { get; set; }
        public int IdAlbum { get; set; }
        public string? Album { get; set; }
    }
}

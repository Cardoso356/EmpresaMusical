using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.App.Models
{
    public class MusicoAlbumModel
    {
        public int Id { get; set; }
        public int IdMusico { get; set; }
        public string? Musico { get; set; }
        public int IdAlbum { get; set; }
        public string? Album { get; set; }
    }
}

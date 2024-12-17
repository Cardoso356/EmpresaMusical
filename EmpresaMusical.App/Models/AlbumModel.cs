using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.App.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string? TituloAlbum { get; set; }
        public string? Formato { get; set; }
        public DateTime? Data { get; set; }
    }
}

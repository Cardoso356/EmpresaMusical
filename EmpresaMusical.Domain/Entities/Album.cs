using EmpresaMusical.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Domain.Entities
{
    public class Album : BaseEntity<int>
    {
        public Album()
        {

        }

        public Album(int id, string? tituloAlbum, string? formato, DateTime data) 
        {
            Id = id;
            TituloAlbum = tituloAlbum;
            Formato = formato;
            Data = data;
        }

        public string? TituloAlbum { get; set; }
        public string? Formato { get; set; }
        public DateTime Data { get; set; }

    }
}

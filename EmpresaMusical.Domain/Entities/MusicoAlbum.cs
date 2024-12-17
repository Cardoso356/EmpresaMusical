using EmpresaMusical.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Domain.Entities
{
    public class MusicoAlbum : BaseEntity<int>
    {
        public MusicoAlbum()
        {

        }

        public MusicoAlbum(int id, Musico? musico, Album? album)
        {
            Id = id;
            Musico = musico;
            Album = album;
        }

        public Musico? Musico { get; set; }
        public Album? Album { get; set; }

    }
}

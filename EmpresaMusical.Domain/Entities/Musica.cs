using EmpresaMusical.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Domain.Entities
{
    public class Musica : BaseEntity<int>
    {
        public Musica() 
        {

        }
        public Musica(int id, string? nomeMusica, string? gravadora, Album? album) : base(id)
        {
            Id = id;
            NomeMusica = nomeMusica;
            Gravadora = gravadora;
            Album = album;
        }

        public string? NomeMusica { get; set; }
        public string? Gravadora { get; set; }
        public Album? Album { get; set; }

    }
}

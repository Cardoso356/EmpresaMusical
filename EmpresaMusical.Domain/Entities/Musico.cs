using EmpresaMusical.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Domain.Entities
{
    public class Musico : BaseEntity<int>
    {
        public Musico() 
        {

        }

        public Musico(int id, string? nomeMusico, string? endereco, string? email, string? telefone)
        {
            Id = id;
            NomeMusico = nomeMusico;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
        }

        public string? NomeMusico { get; set; }
        public string? Endereco { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

    }
}

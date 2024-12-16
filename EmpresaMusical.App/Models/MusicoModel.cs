using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.App.Models
{
    public class MusicoModel
    {
        public int Id { get; set; }
        public string? NomeMusico { get; set; }
        public string? Endereco { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
    }
}

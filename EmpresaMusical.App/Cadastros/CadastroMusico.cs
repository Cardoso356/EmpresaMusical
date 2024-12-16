using EmpresaMusical.App.Base;
using EmpresaMusical.App.Models;
using EmpresaMusical.Domain.Base;
using EmpresaMusical.Domain.Entities;
using EmpresaMusical.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaMusical.App.Cadastros
{
    public partial class CadastroMusico : CadastroBase
    {
        private readonly IBaseService<Musico> _musicoService;
        private List<MusicoModel>? musicos;
        public CadastroMusico(IBaseService<Musico> musicoService)
        {
            _musicoService = musicoService;
            InitializeComponent();
        }
    }
}

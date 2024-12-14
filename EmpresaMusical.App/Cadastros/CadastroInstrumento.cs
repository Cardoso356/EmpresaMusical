using EmpresaMusical.App.Base;
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
    public partial class CadastroInstrumento : CadastroBase
    {
        private IBaseService<Instrumento> _instrumentoService;
        private List<Instrumento> instrumentos;

        public CadastroInstrumento(IBaseService<Instrumento> instrumentoService)
        {
            _instrumentoService = instrumentoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Instrumento instrumento)
        {
            //instrumento.NomeInstrumento = txtNomeInstrumento.Text;
            //instrumento.Tipo = txtTipo.Text;
        }

    }
}

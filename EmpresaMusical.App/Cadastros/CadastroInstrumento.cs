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
        private readonly IBaseService<Instrumento> _instrumentoService;

        private List<Instrumento> instrumentos;
        public CadastroInstrumento(IBaseService<Instrumento> instrumentoService)
        {
            _instrumentoService = instrumentoService;
            InitializeComponent();
        }


        private void PreencheObjeto (Instrumento instrumento)
        {
            instrumento.NomeInstrumento = txtNomeInstrumento.Text;
            instrumento.Tipo = txtTipoInstrumento.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var instrumento = _instrumentoService.GetById<Instrumento>(id);
                        PreencheObjeto(instrumento);
                        instrumento = _instrumentoService.Update<Instrumento, Instrumento, InstrumentoValidator>(instrumento);
                    }
                }
                else
                {
                    var instrumento = new Instrumento();
                    PreencheObjeto(instrumento);
                    _instrumentoService.Add<Instrumento, Instrumento, InstrumentoValidator>(instrumento);

                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Empresa Musical",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        protected override void Deletar(int id)
        {
            try
            {
                _instrumentoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Empresa Musical",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            instrumentos = _instrumentoService.Get<Instrumento>().ToList();
            dataGridViewConsulta.DataSource = instrumentos;
            dataGridViewConsulta.Columns["NomeInstrumento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Tipo"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Alterando a ordem de exibição
            dataGridViewConsulta.Columns["Id"].DisplayIndex = 0; // Primeiro o Id
            dataGridViewConsulta.Columns["NomeInstrumento"].DisplayIndex = 1; // Depois o Nome
            dataGridViewConsulta.Columns["Tipo"].DisplayIndex = 2; // Por último o Tipo

            // Alterando o título da coluna
            dataGridViewConsulta.Columns["NomeInstrumento"].HeaderText = "Nome do Instrumento";
            dataGridViewConsulta.Columns["Tipo"].HeaderText = "Tipo do instrumento";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNomeInstrumento.Text = linha?.Cells["NomeInstrumento"].Value.ToString();
            txtTipoInstrumento.Text = linha?.Cells["Tipo"].Value.ToString();
        }



    }
}

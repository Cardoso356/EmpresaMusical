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
    public partial class CadastroMusicoInstrumento : CadastroBase
    {
        private readonly IBaseService<MusicoInstrumento> _musicoInstrumentoService;
        private readonly IBaseService<Musico> _musicoService;
        private readonly IBaseService<Instrumento> _instrumentoService;

        private List<MusicoInstrumentoModel>? musicoInstrumentos;
        public CadastroMusicoInstrumento(IBaseService<MusicoInstrumento> musicoInstrumentoService ,IBaseService<Musico> musicoService, IBaseService<Instrumento> instrumentoService)
        {
            _musicoService = musicoService;
            _instrumentoService = instrumentoService;
            _musicoInstrumentoService = musicoInstrumentoService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboMusicoId.ValueMember = "Id";
            cboMusicoId.DisplayMember = "NomeMusico";
            cboMusicoId.DataSource = _musicoService.Get<MusicoModel>().ToList();

            cboInstrumentoId.ValueMember = "Id";
            cboInstrumentoId.DisplayMember = "NomeInstrumento";
            cboInstrumentoId.DataSource = _instrumentoService.Get<InstrumentoModels>().ToList();
        }

        private void PreencheObjeto(MusicoInstrumento musicoInstrumento)
        {

            if (cboMusicoId.SelectedValue != null && int.TryParse(cboMusicoId.SelectedValue.ToString(), out int idMusico))
            {
                var musico = _musicoService.GetById<Musico>(idMusico);
                musicoInstrumento.Musico = musico;
            }

            if (cboInstrumentoId.SelectedValue != null && int.TryParse(cboInstrumentoId.SelectedValue.ToString(), out int idInstrumento))
            {
                var instrumento = _instrumentoService.GetById<Instrumento>(idInstrumento);
                musicoInstrumento.Instrumento = instrumento;
            }

        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var musicoInstrumento = _musicoInstrumentoService.GetById<MusicoInstrumento>(id);
                        PreencheObjeto(musicoInstrumento);
                        musicoInstrumento = _musicoInstrumentoService.Update<MusicoInstrumento, MusicoInstrumento, MusicoInstrumentoValidator>(musicoInstrumento);
                    }
                }
                else
                {
                    var musicoInstrumento = new MusicoInstrumento();
                    PreencheObjeto(musicoInstrumento);
                    _musicoInstrumentoService.Add<MusicoInstrumento, MusicoInstrumento, MusicoInstrumentoValidator>(musicoInstrumento);

                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void Deletar(int id)
        {
            try
            {
                _musicoInstrumentoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            musicoInstrumentos = _musicoInstrumentoService.Get<MusicoInstrumentoModel>(false, new[] { "Musico", "Instrumento" }).ToList();
            dataGridViewConsulta.DataSource = musicoInstrumentos;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;

            // Configuração das colunas
            dataGridViewConsulta.Columns["Musico"]!.HeaderText = "Músico";
            dataGridViewConsulta.Columns["Instrumento"]!.HeaderText = "Instrumento";

            dataGridViewConsulta.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewConsulta.Columns["Musico"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Instrumento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            //dataGridViewConsulta.Columns["Id"]!.Visible = false;
            //musicoInstrumentos = _musicoInstrumentoService.Get<MusicoInstrumentoModel>(false, new[] { "Instrumento" }).ToList();
            //dataGridViewConsulta.DataSource = musicoInstrumentos;
            //dataGridViewConsulta.Columns["IdInstrumento"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            cboMusicoId.SelectedValue = linha?.Cells["IdMusico"].Value.ToString();
            cboInstrumentoId.SelectedValue = linha?.Cells["IdInstrumento"].Value.ToString();
            

        }



    }
}

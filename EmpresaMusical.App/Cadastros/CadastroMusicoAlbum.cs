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
    public partial class CadastroMusicoAlbum : CadastroBase
    {
        private readonly IBaseService<MusicoAlbum> _musicoAlbumService;
        private readonly IBaseService<Musico> _musicoService;
        private readonly IBaseService<Album> _albumService;

        private List<MusicoAlbumModel>? musicoAlbums;
        public CadastroMusicoAlbum(IBaseService<MusicoAlbum> musicoAlbumService, IBaseService<Musico> musicoService, IBaseService<Album> albumService)
        {
            _albumService = albumService;
            _musicoService = musicoService;
            _musicoAlbumService = musicoAlbumService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboMusico.ValueMember = "Id";
            cboMusico.DisplayMember = "NomeMusico";
            cboMusico.DataSource = _musicoService.Get<MusicoModel>().ToList();

            cboAlbum.ValueMember = "Id";
            cboAlbum.DisplayMember = "TituloAlbum";
            cboAlbum.DataSource = _albumService.Get<AlbumModel>().ToList();
        }


        private void PreencheObjeto(MusicoAlbum musicoAlbum)
        {

            if (cboMusico.SelectedValue != null && int.TryParse(cboMusico.SelectedValue.ToString(), out int idMusico))
            {
                var musico = _musicoService.GetById<Musico>(idMusico);
                musicoAlbum.Musico = musico;
            }

            if (cboAlbum.SelectedValue != null && int.TryParse(cboAlbum.SelectedValue.ToString(), out int idAlbum))
            {
                var album = _albumService.GetById<Album>(idAlbum);
                musicoAlbum.Album = album;
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
                        var musicoAlbum = _musicoAlbumService.GetById<MusicoAlbum>(id);
                        PreencheObjeto(musicoAlbum);
                        musicoAlbum = _musicoAlbumService.Update<MusicoAlbum, MusicoAlbum, MusicoAlbumValidator>(musicoAlbum);
                    }
                }
                else
                {
                    var musicoAlbum = new MusicoAlbum();
                    PreencheObjeto(musicoAlbum);
                    _musicoAlbumService.Add<MusicoAlbum, MusicoAlbum, MusicoAlbumValidator>(musicoAlbum);

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
                _musicoAlbumService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            musicoAlbums = _musicoAlbumService.Get<MusicoAlbumModel>(false, new[] { "Musico", "Album" }).ToList();
            dataGridViewConsulta.DataSource = musicoAlbums;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;

            // Configuração das colunas
            dataGridViewConsulta.Columns["Musico"]!.HeaderText = "Músico";
            dataGridViewConsulta.Columns["Album"]!.HeaderText = "Album";

            dataGridViewConsulta.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewConsulta.Columns["Musico"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Album"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            //dataGridViewConsulta.Columns["Id"]!.Visible = false;
            //musicoInstrumentos = _musicoInstrumentoService.Get<MusicoInstrumentoModel>(false, new[] { "Instrumento" }).ToList();
            //dataGridViewConsulta.DataSource = musicoInstrumentos;
            //dataGridViewConsulta.Columns["IdInstrumento"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            cboMusico.SelectedValue = linha?.Cells["IdMusico"].Value.ToString();
            cboAlbum.SelectedValue = linha?.Cells["IdAlbum"].Value.ToString();


        }



    }
}

using EmpresaMusical.App.Base;
using EmpresaMusical.App.Models;
using EmpresaMusical.Domain.Base;
using EmpresaMusical.Domain.Entities;
using EmpresaMusical.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaMusical.App.Cadastros
{
    public partial class CadastroMusica : CadastroBase
    {
        private readonly IBaseService<Musica> _musicaService;
        private readonly IBaseService<Album> _albumService;

        private List<MusicaModel>? musicas;
        public CadastroMusica(IBaseService<Musica> musicaService, IBaseService<Album> albumService)
        {
            _musicaService = musicaService;
            _albumService = albumService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboAlbum.ValueMember = "Id";
            cboAlbum.DisplayMember = "TituloAlbum";
            cboAlbum.DataSource = _albumService.Get<AlbumModel>().ToList();

        }

        private void PreencheObjeto(Musica musica)
        {
            musica.NomeMusica = txtNomeMusica.Text;
            musica.Gravadora = txtGravadora.Text;

            if (cboAlbum.SelectedValue != null && int.TryParse(cboAlbum.SelectedValue.ToString(), out int idAlbum))
            {
                var album = _albumService.GetById<Album>(idAlbum);
                musica.Album = album;
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
                        var musica = _musicaService.GetById<Musica>(id);
                        PreencheObjeto(musica);
                        musica = _musicaService.Update<Musica, Musica, MusicaValidator>(musica);
                    }
                }
                else
                {
                    var musica = new Musica();
                    PreencheObjeto(musica);
                    _musicaService.Add<Musica, Musica, MusicaValidator>(musica);

                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Empresa Musical", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void Deletar(int id)
        {
            try
            {
                _musicaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Empresa Musical", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            musicas = _musicaService.Get<MusicaModel>(false, new[] { "Album" }).ToList();
            dataGridViewConsulta.DataSource = musicas;
            dataGridViewConsulta.Columns["NomeMusica"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Alterando a ordem de exibição
            dataGridViewConsulta.Columns["Id"].DisplayIndex = 0; // Primeiro o Id
            dataGridViewConsulta.Columns["NomeMusica"].DisplayIndex = 1; // Depois o Nome
            dataGridViewConsulta.Columns["Album"].DisplayIndex = 2; // Depois o Album
            dataGridViewConsulta.Columns["Gravadora"].DisplayIndex = 2; // Depois a Gravadora


            // Alterando o título da coluna
            dataGridViewConsulta.Columns["NomeMusica"].HeaderText = "Nome da Música";
            dataGridViewConsulta.Columns["Album"].HeaderText = "Álbum da música";
            dataGridViewConsulta.Columns["IdAlbum"].HeaderText = "Id do Álbum";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNomeMusica.Text = linha?.Cells["NomeMusica"].Value.ToString();
            cboAlbum.SelectedValue = linha?.Cells["IdAlbum"].Value.ToString();
            txtGravadora.Text = linha?.Cells["Gravadora"].Value.ToString();
            

        }




    }
}

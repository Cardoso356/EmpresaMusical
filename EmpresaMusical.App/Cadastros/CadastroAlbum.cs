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
    public partial class CadastroAlbum : CadastroBase
    {
        private readonly IBaseService<Album> _albumService;
        private List<AlbumModel>? albuns;
        public CadastroAlbum(IBaseService<Album> albumService)
        {
            _albumService = albumService;
            InitializeComponent();
        }

        private void PreencheObjeto(Album album)
        {
            album.TituloAlbum = txtTituloAlbum.Text;
            album.Formato = txtFormato.Text;

            if (DateTime.TryParse(txtData.Text, out var data))
            {
                album.Data = data;
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
                        var album = _albumService.GetById<Album>(id);
                        PreencheObjeto(album);
                        album = _albumService.Update<Album, Album, AlbumValidator>(album);
                    }
                }
                else
                {
                    var album = new Album();
                    PreencheObjeto(album);
                    _albumService.Add<Album, Album, AlbumValidator>(album);

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
                _albumService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            albuns = _albumService.Get<AlbumModel>().ToList();
            dataGridViewConsulta.DataSource = albuns;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Alterando a ordem de exibição
            dataGridViewConsulta.Columns["Id"].DisplayIndex = 0; // Primeiro o Id
            dataGridViewConsulta.Columns["TituloAlbum"].DisplayIndex = 1; // Depois o Nome
            dataGridViewConsulta.Columns["Formato"].DisplayIndex = 2; // Depois o Formato
            dataGridViewConsulta.Columns["Data"].DisplayIndex = 3; // Depois a Data

            // Alterando o título da coluna
            dataGridViewConsulta.Columns["TituloAlbum"].HeaderText = "Título do Álbum";
            dataGridViewConsulta.Columns["Formato"].HeaderText = "Formato do Álbum";
            dataGridViewConsulta.Columns["Data"].HeaderText = "Data do Álbum";

        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtTituloAlbum.Text = linha?.Cells["TituloAlbum"].Value.ToString();
            txtFormato.Text = linha?.Cells["Formato"].Value.ToString();
            txtData.Text = DateTime.TryParse(linha?.Cells["Data"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";

        }



    }
}

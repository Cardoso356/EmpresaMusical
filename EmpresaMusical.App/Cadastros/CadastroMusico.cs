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

        private void PreencheObjeto(Musico musico)
        {
            musico.NomeMusico = txtNomeMusico.Text;
            musico.Login = txtLogin.Text;
            musico.Senha = txtSenha.Text;
            musico.Endereco = txtEndereco.Text;
            musico.Email = txtEmail.Text;
            musico.Telefone = txtTelefone.Text;
        }


        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var musico = _musicoService.GetById<Musico>(id);
                        PreencheObjeto(musico);
                        musico = _musicoService.Update<Musico, Musico, MusicoValidator>(musico);
                    }
                }
                else
                {
                    var musico = new Musico();
                    PreencheObjeto(musico);
                    _musicoService.Add<Musico, Musico, MusicoValidator>(musico);

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
                _musicoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Empresa Musical", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            musicos = _musicoService.Get<MusicoModel>().ToList();
            dataGridViewConsulta.DataSource = musicos;
            dataGridViewConsulta.Columns["Senha"]!.Visible = false;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Alterando a ordem de exibição
            dataGridViewConsulta.Columns["Id"].DisplayIndex = 0; // Primeiro o Id
            dataGridViewConsulta.Columns["NomeMusico"].DisplayIndex = 1; // Depois o Nome
            dataGridViewConsulta.Columns["Login"].DisplayIndex = 2; // Depois o Login
            dataGridViewConsulta.Columns["Senha"].DisplayIndex = 3; // Depois a Senha
            dataGridViewConsulta.Columns["Telefone"].DisplayIndex = 4; // Depois o telefone
            dataGridViewConsulta.Columns["Endereco"].DisplayIndex = 5; // Depois o Endereço
            dataGridViewConsulta.Columns["Email"].DisplayIndex = 6; // Por último o Email

            // Alterando o título da coluna
            dataGridViewConsulta.Columns["NomeMusico"].HeaderText = "Nome do Musico";
            dataGridViewConsulta.Columns["Login"].HeaderText = "Login no sistema";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNomeMusico.Text = linha?.Cells["NomeMusico"].Value.ToString();
            txtLogin.Text = linha?.Cells["Login"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();

        }


    }
}

using EmpresaMusical.Domain.Base;
using EmpresaMusical.Domain.Entities;
using EmpresaMusical.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaMusical.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Musico> _musicoService;
        public Login(IBaseService<Musico> musicoService)
        {
            _musicoService = musicoService;
            InitializeComponent();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            Musico musico = ObterMusico(txtMusico.Text, txtSenha.Text);

            if (musico == null)
            {
                MessageBox.Show("Músico e/ou senha inválida!", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                musico = _musicoService.Update<Musico, Musico, MusicoValidator>(musico);
                FormPrincipal.Musico = musico;
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private Musico? ObterMusico(string login, string senha)
        {
            ChecaExistenciaDeMusicoCadastrado();
            var musico = _musicoService.Get<Musico>().Where(prop => prop.Login == login).FirstOrDefault();
            if (musico == null)
                return null;
            return musico.Senha != senha ? null : musico;
        }

        private void ChecaExistenciaDeMusicoCadastrado()
        {
            var musicos = _musicoService.Get<Musico>().ToList();
            if (!musicos.Any())
            {
                var musico = new Musico
                {
                    Login = "musico",
                    Senha = "musico",
                    NomeMusico = "Administrador do sistema",
                    Email = "admin@gmail.com",
                    Endereco = "Rua dos adm",
                    Telefone = "991220225"
                };
                _musicoService.Add<Musico, Musico, MusicoValidator>(musico);
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

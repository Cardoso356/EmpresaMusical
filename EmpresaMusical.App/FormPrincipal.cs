using EmpresaMusical.App.Cadastros;
using EmpresaMusical.App.Infra;
using EmpresaMusical.App.Outros;
using EmpresaMusical.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace EmpresaMusical.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Musico Musico { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblMusico.Text = $"Músico: {Musico.NomeMusico}";
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void musicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroMusico>();
        }

        private void instrumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroInstrumento>();
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAlbum>();
        }

        private void musicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroMusica>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //encerra a aplicação
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }


    }
}

﻿using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Diagnostics.Eventing.Reader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaMusical.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool isAlteracao = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"Empresa Musical", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastro.SelectedIndex = 1;
            }
        }

        #region Eventos_Form
        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente excluir?", @"Empresa Musical", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Empresa Musical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        #endregion

        #region Eventos_CRUD
        protected void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();
            tabControlCadastro.SelectedIndex = 0;
            tabControlCadastro.Focus();
        }

        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                tabControlCadastro.SelectedIndex = 0;
                tabControlCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Empresa Musical", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }
        #endregion

    }
}

namespace EmpresaMusical.App.Cadastros
{
    partial class CadastroInstrumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNomeInstrumento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTipoInstrumento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(734, 548);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtTipoInstrumento);
            tabPageCadastro.Controls.Add(txtNomeInstrumento);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(726, 515);
            tabPageCadastro.Controls.SetChildIndex(botaoCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(botaoSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeInstrumento, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTipoInstrumento, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(726, 515);
            // 
            // botaoCancelar
            // 
            botaoCancelar.Location = new Point(515, 452);
            // 
            // botaoSalvar
            // 
            botaoSalvar.Location = new Point(629, 452);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id Instrumento";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(15, 38);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(199, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNomeInstrumento
            // 
            txtNomeInstrumento.AnimateReadOnly = false;
            txtNomeInstrumento.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeInstrumento.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeInstrumento.BackgroundImageLayout = ImageLayout.None;
            txtNomeInstrumento.CharacterCasing = CharacterCasing.Normal;
            txtNomeInstrumento.Depth = 0;
            txtNomeInstrumento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeInstrumento.HideSelection = true;
            txtNomeInstrumento.Hint = "Nome do Instrumento";
            txtNomeInstrumento.LeadingIcon = null;
            txtNomeInstrumento.Location = new Point(238, 38);
            txtNomeInstrumento.MaxLength = 32767;
            txtNomeInstrumento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeInstrumento.Name = "txtNomeInstrumento";
            txtNomeInstrumento.PasswordChar = '\0';
            txtNomeInstrumento.PrefixSuffixText = null;
            txtNomeInstrumento.ReadOnly = false;
            txtNomeInstrumento.RightToLeft = RightToLeft.No;
            txtNomeInstrumento.SelectedText = "";
            txtNomeInstrumento.SelectionLength = 0;
            txtNomeInstrumento.SelectionStart = 0;
            txtNomeInstrumento.ShortcutsEnabled = true;
            txtNomeInstrumento.Size = new Size(467, 48);
            txtNomeInstrumento.TabIndex = 4;
            txtNomeInstrumento.TabStop = false;
            txtNomeInstrumento.TextAlign = HorizontalAlignment.Left;
            txtNomeInstrumento.TrailingIcon = null;
            txtNomeInstrumento.UseSystemPasswordChar = false;
            // 
            // txtTipoInstrumento
            // 
            txtTipoInstrumento.AnimateReadOnly = false;
            txtTipoInstrumento.AutoCompleteMode = AutoCompleteMode.None;
            txtTipoInstrumento.AutoCompleteSource = AutoCompleteSource.None;
            txtTipoInstrumento.BackgroundImageLayout = ImageLayout.None;
            txtTipoInstrumento.CharacterCasing = CharacterCasing.Normal;
            txtTipoInstrumento.Depth = 0;
            txtTipoInstrumento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTipoInstrumento.HideSelection = true;
            txtTipoInstrumento.Hint = "Tipo do Instrumento";
            txtTipoInstrumento.LeadingIcon = null;
            txtTipoInstrumento.Location = new Point(15, 117);
            txtTipoInstrumento.MaxLength = 32767;
            txtTipoInstrumento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTipoInstrumento.Name = "txtTipoInstrumento";
            txtTipoInstrumento.PasswordChar = '\0';
            txtTipoInstrumento.PrefixSuffixText = null;
            txtTipoInstrumento.ReadOnly = false;
            txtTipoInstrumento.RightToLeft = RightToLeft.No;
            txtTipoInstrumento.SelectedText = "";
            txtTipoInstrumento.SelectionLength = 0;
            txtTipoInstrumento.SelectionStart = 0;
            txtTipoInstrumento.ShortcutsEnabled = true;
            txtTipoInstrumento.Size = new Size(690, 48);
            txtTipoInstrumento.TabIndex = 5;
            txtTipoInstrumento.TabStop = false;
            txtTipoInstrumento.TextAlign = HorizontalAlignment.Left;
            txtTipoInstrumento.TrailingIcon = null;
            txtTipoInstrumento.UseSystemPasswordChar = false;
            // 
            // CadastroInstrumento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 615);
            Location = new Point(0, 0);
            Name = "CadastroInstrumento";
            Text = "Cadastro de Instrumentos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTipoInstrumento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeInstrumento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}
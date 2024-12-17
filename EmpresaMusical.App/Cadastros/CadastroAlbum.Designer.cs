namespace EmpresaMusical.App.Cadastros
{
    partial class CadastroAlbum
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
            txtTituloAlbum = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtFormato = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtData = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(731, 546);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtData);
            tabPageCadastro.Controls.Add(txtFormato);
            tabPageCadastro.Controls.Add(txtTituloAlbum);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(723, 513);
            tabPageCadastro.Controls.SetChildIndex(botaoCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(botaoSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTituloAlbum, 0);
            tabPageCadastro.Controls.SetChildIndex(txtFormato, 0);
            tabPageCadastro.Controls.SetChildIndex(txtData, 0);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id do Álbum";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(6, 24);
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
            txtId.Size = new Size(705, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtTituloAlbum
            // 
            txtTituloAlbum.AnimateReadOnly = false;
            txtTituloAlbum.AutoCompleteMode = AutoCompleteMode.None;
            txtTituloAlbum.AutoCompleteSource = AutoCompleteSource.None;
            txtTituloAlbum.BackgroundImageLayout = ImageLayout.None;
            txtTituloAlbum.CharacterCasing = CharacterCasing.Normal;
            txtTituloAlbum.Depth = 0;
            txtTituloAlbum.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTituloAlbum.HideSelection = true;
            txtTituloAlbum.Hint = "Título do Álbum";
            txtTituloAlbum.LeadingIcon = null;
            txtTituloAlbum.Location = new Point(6, 90);
            txtTituloAlbum.MaxLength = 32767;
            txtTituloAlbum.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTituloAlbum.Name = "txtTituloAlbum";
            txtTituloAlbum.PasswordChar = '\0';
            txtTituloAlbum.PrefixSuffixText = null;
            txtTituloAlbum.ReadOnly = false;
            txtTituloAlbum.RightToLeft = RightToLeft.No;
            txtTituloAlbum.SelectedText = "";
            txtTituloAlbum.SelectionLength = 0;
            txtTituloAlbum.SelectionStart = 0;
            txtTituloAlbum.ShortcutsEnabled = true;
            txtTituloAlbum.Size = new Size(705, 48);
            txtTituloAlbum.TabIndex = 4;
            txtTituloAlbum.TabStop = false;
            txtTituloAlbum.TextAlign = HorizontalAlignment.Left;
            txtTituloAlbum.TrailingIcon = null;
            txtTituloAlbum.UseSystemPasswordChar = false;
            // 
            // txtFormato
            // 
            txtFormato.AnimateReadOnly = false;
            txtFormato.AutoCompleteMode = AutoCompleteMode.None;
            txtFormato.AutoCompleteSource = AutoCompleteSource.None;
            txtFormato.BackgroundImageLayout = ImageLayout.None;
            txtFormato.CharacterCasing = CharacterCasing.Normal;
            txtFormato.Depth = 0;
            txtFormato.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFormato.HideSelection = true;
            txtFormato.Hint = "Formato do Álbum";
            txtFormato.LeadingIcon = null;
            txtFormato.Location = new Point(6, 166);
            txtFormato.MaxLength = 32767;
            txtFormato.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFormato.Name = "txtFormato";
            txtFormato.PasswordChar = '\0';
            txtFormato.PrefixSuffixText = null;
            txtFormato.ReadOnly = false;
            txtFormato.RightToLeft = RightToLeft.No;
            txtFormato.SelectedText = "";
            txtFormato.SelectionLength = 0;
            txtFormato.SelectionStart = 0;
            txtFormato.ShortcutsEnabled = true;
            txtFormato.Size = new Size(397, 48);
            txtFormato.TabIndex = 5;
            txtFormato.TabStop = false;
            txtFormato.TextAlign = HorizontalAlignment.Left;
            txtFormato.TrailingIcon = null;
            txtFormato.UseSystemPasswordChar = false;
            // 
            // txtData
            // 
            txtData.AnimateReadOnly = false;
            txtData.AutoCompleteMode = AutoCompleteMode.None;
            txtData.AutoCompleteSource = AutoCompleteSource.None;
            txtData.BackgroundImageLayout = ImageLayout.None;
            txtData.CharacterCasing = CharacterCasing.Normal;
            txtData.Depth = 0;
            txtData.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtData.HideSelection = true;
            txtData.Hint = "Data do Álbum";
            txtData.LeadingIcon = null;
            txtData.Location = new Point(409, 166);
            txtData.MaxLength = 32767;
            txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtData.Name = "txtData";
            txtData.PasswordChar = '\0';
            txtData.PrefixSuffixText = null;
            txtData.ReadOnly = false;
            txtData.RightToLeft = RightToLeft.No;
            txtData.SelectedText = "";
            txtData.SelectionLength = 0;
            txtData.SelectionStart = 0;
            txtData.ShortcutsEnabled = true;
            txtData.Size = new Size(302, 48);
            txtData.TabIndex = 6;
            txtData.TabStop = false;
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            // 
            // CadastroAlbum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 613);
            Location = new Point(0, 0);
            Name = "CadastroAlbum";
            Text = "Cadastro de Álbuns";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFormato;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTituloAlbum;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtData;
    }
}
namespace EmpresaMusical.App.Cadastros
{
    partial class CadastroMusica
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
            txtNomeMusica = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtGravadora = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboAlbum = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(726, 547);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboAlbum);
            tabPageCadastro.Controls.Add(txtGravadora);
            tabPageCadastro.Controls.Add(txtNomeMusica);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(718, 514);
            tabPageCadastro.Controls.SetChildIndex(botaoCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(botaoSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeMusica, 0);
            tabPageCadastro.Controls.SetChildIndex(txtGravadora, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAlbum, 0);
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
            txtId.Hint = "Id da Música";
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
            txtId.Size = new Size(132, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNomeMusica
            // 
            txtNomeMusica.AnimateReadOnly = false;
            txtNomeMusica.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeMusica.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeMusica.BackgroundImageLayout = ImageLayout.None;
            txtNomeMusica.CharacterCasing = CharacterCasing.Normal;
            txtNomeMusica.Depth = 0;
            txtNomeMusica.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeMusica.HideSelection = true;
            txtNomeMusica.Hint = "Nome da Música";
            txtNomeMusica.LeadingIcon = null;
            txtNomeMusica.Location = new Point(144, 24);
            txtNomeMusica.MaxLength = 32767;
            txtNomeMusica.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeMusica.Name = "txtNomeMusica";
            txtNomeMusica.PasswordChar = '\0';
            txtNomeMusica.PrefixSuffixText = null;
            txtNomeMusica.ReadOnly = false;
            txtNomeMusica.RightToLeft = RightToLeft.No;
            txtNomeMusica.SelectedText = "";
            txtNomeMusica.SelectionLength = 0;
            txtNomeMusica.SelectionStart = 0;
            txtNomeMusica.ShortcutsEnabled = true;
            txtNomeMusica.Size = new Size(567, 48);
            txtNomeMusica.TabIndex = 4;
            txtNomeMusica.TabStop = false;
            txtNomeMusica.TextAlign = HorizontalAlignment.Left;
            txtNomeMusica.TrailingIcon = null;
            txtNomeMusica.UseSystemPasswordChar = false;
            // 
            // txtGravadora
            // 
            txtGravadora.AnimateReadOnly = false;
            txtGravadora.AutoCompleteMode = AutoCompleteMode.None;
            txtGravadora.AutoCompleteSource = AutoCompleteSource.None;
            txtGravadora.BackgroundImageLayout = ImageLayout.None;
            txtGravadora.CharacterCasing = CharacterCasing.Normal;
            txtGravadora.Depth = 0;
            txtGravadora.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGravadora.HideSelection = true;
            txtGravadora.Hint = "Gravadora Responsável Pela Música";
            txtGravadora.LeadingIcon = null;
            txtGravadora.Location = new Point(6, 97);
            txtGravadora.MaxLength = 32767;
            txtGravadora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtGravadora.Name = "txtGravadora";
            txtGravadora.PasswordChar = '\0';
            txtGravadora.PrefixSuffixText = null;
            txtGravadora.ReadOnly = false;
            txtGravadora.RightToLeft = RightToLeft.No;
            txtGravadora.SelectedText = "";
            txtGravadora.SelectionLength = 0;
            txtGravadora.SelectionStart = 0;
            txtGravadora.ShortcutsEnabled = true;
            txtGravadora.Size = new Size(705, 48);
            txtGravadora.TabIndex = 5;
            txtGravadora.TabStop = false;
            txtGravadora.TextAlign = HorizontalAlignment.Left;
            txtGravadora.TrailingIcon = null;
            txtGravadora.UseSystemPasswordChar = false;
            // 
            // cboAlbum
            // 
            cboAlbum.AutoResize = false;
            cboAlbum.BackColor = Color.FromArgb(255, 255, 255);
            cboAlbum.Depth = 0;
            cboAlbum.DrawMode = DrawMode.OwnerDrawVariable;
            cboAlbum.DropDownHeight = 174;
            cboAlbum.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlbum.DropDownWidth = 121;
            cboAlbum.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAlbum.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAlbum.FormattingEnabled = true;
            cboAlbum.Hint = "Álbum";
            cboAlbum.IntegralHeight = false;
            cboAlbum.ItemHeight = 43;
            cboAlbum.Location = new Point(6, 171);
            cboAlbum.MaxDropDownItems = 4;
            cboAlbum.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAlbum.Name = "cboAlbum";
            cboAlbum.Size = new Size(365, 49);
            cboAlbum.StartIndex = 0;
            cboAlbum.TabIndex = 6;
            // 
            // CadastroMusica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 614);
            Location = new Point(0, 0);
            Name = "CadastroMusica";
            Text = "Cadastro de Músicas";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboAlbum;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGravadora;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeMusica;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}
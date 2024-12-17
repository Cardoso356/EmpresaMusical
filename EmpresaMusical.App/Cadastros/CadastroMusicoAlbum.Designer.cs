namespace EmpresaMusical.App.Cadastros
{
    partial class CadastroMusicoAlbum
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
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboMusico = new ReaLTaiizor.Controls.MaterialComboBox();
            cboAlbum = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(730, 548);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboAlbum);
            tabPageCadastro.Controls.Add(cboMusico);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(materialTextBoxEdit1);
            tabPageCadastro.Size = new Size(722, 515);
            tabPageCadastro.Controls.SetChildIndex(botaoCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(botaoSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit1, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboMusico, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAlbum, 0);
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Enabled = false;
            materialTextBoxEdit1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.Hint = "                                                             Relação de Músico-Álbum";
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(11, 19);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(700, 48);
            materialTextBoxEdit1.TabIndex = 3;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
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
            txtId.Hint = "Id da relação";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(11, 163);
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
            txtId.Size = new Size(700, 48);
            txtId.TabIndex = 6;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboMusico
            // 
            cboMusico.AutoResize = false;
            cboMusico.BackColor = Color.FromArgb(255, 255, 255);
            cboMusico.Depth = 0;
            cboMusico.DrawMode = DrawMode.OwnerDrawVariable;
            cboMusico.DropDownHeight = 174;
            cboMusico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMusico.DropDownWidth = 121;
            cboMusico.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboMusico.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMusico.FormattingEnabled = true;
            cboMusico.Hint = "Músico";
            cboMusico.IntegralHeight = false;
            cboMusico.ItemHeight = 43;
            cboMusico.Location = new Point(11, 89);
            cboMusico.MaxDropDownItems = 4;
            cboMusico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboMusico.Name = "cboMusico";
            cboMusico.Size = new Size(348, 49);
            cboMusico.StartIndex = 0;
            cboMusico.TabIndex = 7;
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
            cboAlbum.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAlbum.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAlbum.FormattingEnabled = true;
            cboAlbum.Hint = "Álbum";
            cboAlbum.IntegralHeight = false;
            cboAlbum.ItemHeight = 43;
            cboAlbum.Location = new Point(365, 89);
            cboAlbum.MaxDropDownItems = 4;
            cboAlbum.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAlbum.Name = "cboAlbum";
            cboAlbum.Size = new Size(346, 49);
            cboAlbum.StartIndex = 0;
            cboAlbum.TabIndex = 8;
            // 
            // CadastroMusicoAlbum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 615);
            Location = new Point(0, 0);
            Name = "CadastroMusicoAlbum";
            Text = "Cadastro de Musico-Álbum";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboAlbum;
        private ReaLTaiizor.Controls.MaterialComboBox cboMusico;
    }
}
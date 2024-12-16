namespace EmpresaMusical.App.Cadastros
{
    partial class CadastroMusicoInstrumento
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
            cboMusicoId = new ReaLTaiizor.Controls.MaterialComboBox();
            cboInstrumentoId = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(731, 548);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboInstrumentoId);
            tabPageCadastro.Controls.Add(cboMusicoId);
            tabPageCadastro.Controls.Add(materialTextBoxEdit1);
            tabPageCadastro.Size = new Size(723, 515);
            tabPageCadastro.Controls.SetChildIndex(botaoCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(botaoSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboMusicoId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboInstrumentoId, 0);
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(6, 17);
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
            materialTextBoxEdit1.Size = new Size(705, 48);
            materialTextBoxEdit1.TabIndex = 5;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.Text = "                                                         Relação de Músico-Instrumento";
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // cboMusicoId
            // 
            cboMusicoId.AutoResize = false;
            cboMusicoId.BackColor = Color.FromArgb(255, 255, 255);
            cboMusicoId.Depth = 0;
            cboMusicoId.DrawMode = DrawMode.OwnerDrawVariable;
            cboMusicoId.DropDownHeight = 174;
            cboMusicoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMusicoId.DropDownWidth = 121;
            cboMusicoId.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboMusicoId.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMusicoId.FormattingEnabled = true;
            cboMusicoId.Hint = "Id do Músico";
            cboMusicoId.IntegralHeight = false;
            cboMusicoId.ItemHeight = 43;
            cboMusicoId.Location = new Point(6, 86);
            cboMusicoId.MaxDropDownItems = 4;
            cboMusicoId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboMusicoId.Name = "cboMusicoId";
            cboMusicoId.Size = new Size(350, 49);
            cboMusicoId.StartIndex = 0;
            cboMusicoId.TabIndex = 6;
            // 
            // cboInstrumentoId
            // 
            cboInstrumentoId.AutoResize = false;
            cboInstrumentoId.BackColor = Color.FromArgb(255, 255, 255);
            cboInstrumentoId.Depth = 0;
            cboInstrumentoId.DrawMode = DrawMode.OwnerDrawVariable;
            cboInstrumentoId.DropDownHeight = 174;
            cboInstrumentoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInstrumentoId.DropDownWidth = 121;
            cboInstrumentoId.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboInstrumentoId.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboInstrumentoId.FormattingEnabled = true;
            cboInstrumentoId.Hint = "Id do Instrumento";
            cboInstrumentoId.IntegralHeight = false;
            cboInstrumentoId.ItemHeight = 43;
            cboInstrumentoId.Location = new Point(362, 86);
            cboInstrumentoId.MaxDropDownItems = 4;
            cboInstrumentoId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboInstrumentoId.Name = "cboInstrumentoId";
            cboInstrumentoId.Size = new Size(349, 49);
            cboInstrumentoId.StartIndex = 0;
            cboInstrumentoId.TabIndex = 7;
            // 
            // CadastroMusicoInstrumento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 615);
            Location = new Point(0, 0);
            Name = "CadastroMusicoInstrumento";
            Text = "Cadastro de Musico-Instrumento";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialComboBox cboMusicoId;
        private ReaLTaiizor.Controls.MaterialComboBox cboInstrumentoId;
    }
}
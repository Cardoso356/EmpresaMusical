namespace EmpresaMusical.App.Outros
{
    partial class Login
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
            txtMusico = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            botaoCancelar = new ReaLTaiizor.Controls.MaterialButton();
            botaoOK = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtMusico
            // 
            txtMusico.AnimateReadOnly = false;
            txtMusico.AutoCompleteMode = AutoCompleteMode.None;
            txtMusico.AutoCompleteSource = AutoCompleteSource.None;
            txtMusico.BackgroundImageLayout = ImageLayout.None;
            txtMusico.CharacterCasing = CharacterCasing.Normal;
            txtMusico.Depth = 0;
            txtMusico.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMusico.HideSelection = true;
            txtMusico.Hint = "Usuário/Musico";
            txtMusico.LeadingIcon = null;
            txtMusico.Location = new Point(6, 90);
            txtMusico.MaxLength = 32767;
            txtMusico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMusico.Name = "txtMusico";
            txtMusico.PasswordChar = '\0';
            txtMusico.PrefixSuffixText = null;
            txtMusico.ReadOnly = false;
            txtMusico.RightToLeft = RightToLeft.No;
            txtMusico.SelectedText = "";
            txtMusico.SelectionLength = 0;
            txtMusico.SelectionStart = 0;
            txtMusico.ShortcutsEnabled = true;
            txtMusico.Size = new Size(415, 48);
            txtMusico.TabIndex = 0;
            txtMusico.TabStop = false;
            txtMusico.TextAlign = HorizontalAlignment.Left;
            txtMusico.TrailingIcon = null;
            txtMusico.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(6, 173);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '\0';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(415, 48);
            txtSenha.TabIndex = 1;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // botaoCancelar
            // 
            botaoCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoCancelar.Depth = 0;
            botaoCancelar.HighEmphasis = true;
            botaoCancelar.Icon = null;
            botaoCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botaoCancelar.Location = new Point(223, 335);
            botaoCancelar.Margin = new Padding(4, 6, 4, 6);
            botaoCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.NoAccentTextColor = Color.Empty;
            botaoCancelar.Size = new Size(96, 36);
            botaoCancelar.TabIndex = 2;
            botaoCancelar.Text = "cancelar";
            botaoCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoCancelar.UseAccentColor = false;
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // botaoOK
            // 
            botaoOK.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoOK.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoOK.Depth = 0;
            botaoOK.HighEmphasis = true;
            botaoOK.Icon = null;
            botaoOK.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botaoOK.Location = new Point(342, 335);
            botaoOK.Margin = new Padding(4, 6, 4, 6);
            botaoOK.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botaoOK.Name = "botaoOK";
            botaoOK.NoAccentTextColor = Color.Empty;
            botaoOK.Size = new Size(64, 36);
            botaoOK.TabIndex = 3;
            botaoOK.Text = "ok";
            botaoOK.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoOK.UseAccentColor = false;
            botaoOK.UseVisualStyleBackColor = true;
            botaoOK.Click += botaoOK_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 380);
            Controls.Add(botaoOK);
            Controls.Add(botaoCancelar);
            Controls.Add(txtSenha);
            Controls.Add(txtMusico);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login no Sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMusico;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialButton botaoCancelar;
        private ReaLTaiizor.Controls.MaterialButton botaoOK;
    }
}
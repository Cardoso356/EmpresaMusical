namespace EmpresaMusical.App.Base
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            tabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            botaoSalvar = new ReaLTaiizor.Controls.MaterialButton();
            botaoCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tabPageConsulta = new TabPage();
            dataGridViewConsulta = new DataGridView();
            botaoEditar = new ReaLTaiizor.Controls.MaterialButton();
            botaoExcluir = new ReaLTaiizor.Controls.MaterialButton();
            botaoNovo = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageCadastro);
            tabControlCadastro.Controls.Add(tabPageConsulta);
            tabControlCadastro.Depth = 0;
            tabControlCadastro.Dock = DockStyle.Fill;
            tabControlCadastro.ImageList = imageList1;
            tabControlCadastro.Location = new Point(3, 64);
            tabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastro.Multiline = true;
            tabControlCadastro.Name = "tabControlCadastro";
            tabControlCadastro.SelectedIndex = 0;
            tabControlCadastro.Size = new Size(766, 559);
            tabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(botaoSalvar);
            tabPageCadastro.Controls.Add(botaoCancelar);
            tabPageCadastro.ImageKey = "ImagemCadastro.png";
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(758, 526);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // botaoSalvar
            // 
            botaoSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoSalvar.Depth = 0;
            botaoSalvar.HighEmphasis = true;
            botaoSalvar.Icon = null;
            botaoSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botaoSalvar.Location = new Point(635, 465);
            botaoSalvar.Margin = new Padding(4, 6, 4, 6);
            botaoSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botaoSalvar.Name = "botaoSalvar";
            botaoSalvar.NoAccentTextColor = Color.Empty;
            botaoSalvar.Size = new Size(76, 36);
            botaoSalvar.TabIndex = 2;
            botaoSalvar.Text = "salvar";
            botaoSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoSalvar.UseAccentColor = false;
            botaoSalvar.UseVisualStyleBackColor = true;
            botaoSalvar.Click += botaoSalvar_Click;
            // 
            // botaoCancelar
            // 
            botaoCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoCancelar.Depth = 0;
            botaoCancelar.HighEmphasis = true;
            botaoCancelar.Icon = null;
            botaoCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botaoCancelar.Location = new Point(522, 465);
            botaoCancelar.Margin = new Padding(4, 6, 4, 6);
            botaoCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.NoAccentTextColor = Color.Empty;
            botaoCancelar.Size = new Size(96, 36);
            botaoCancelar.TabIndex = 1;
            botaoCancelar.Text = "cancelar";
            botaoCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoCancelar.UseAccentColor = false;
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(dataGridViewConsulta);
            tabPageConsulta.Controls.Add(botaoEditar);
            tabPageConsulta.Controls.Add(botaoExcluir);
            tabPageConsulta.Controls.Add(botaoNovo);
            tabPageConsulta.ImageKey = "ImagemConsulta.png";
            tabPageConsulta.Location = new Point(4, 29);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(758, 526);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Dock = DockStyle.Top;
            dataGridViewConsulta.Location = new Point(3, 3);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.RowHeadersWidth = 51;
            dataGridViewConsulta.Size = new Size(752, 456);
            dataGridViewConsulta.TabIndex = 3;
            // 
            // botaoEditar
            // 
            botaoEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoEditar.Depth = 0;
            botaoEditar.HighEmphasis = true;
            botaoEditar.Icon = null;
            botaoEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botaoEditar.Location = new Point(543, 471);
            botaoEditar.Margin = new Padding(4, 6, 4, 6);
            botaoEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botaoEditar.Name = "botaoEditar";
            botaoEditar.NoAccentTextColor = Color.Empty;
            botaoEditar.Size = new Size(71, 36);
            botaoEditar.TabIndex = 2;
            botaoEditar.Text = "editar";
            botaoEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoEditar.UseAccentColor = false;
            botaoEditar.UseVisualStyleBackColor = true;
            botaoEditar.Click += botaoEditar_Click;
            // 
            // botaoExcluir
            // 
            botaoExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoExcluir.Depth = 0;
            botaoExcluir.HighEmphasis = true;
            botaoExcluir.Icon = null;
            botaoExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botaoExcluir.Location = new Point(634, 471);
            botaoExcluir.Margin = new Padding(4, 6, 4, 6);
            botaoExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botaoExcluir.Name = "botaoExcluir";
            botaoExcluir.NoAccentTextColor = Color.Empty;
            botaoExcluir.Size = new Size(80, 36);
            botaoExcluir.TabIndex = 1;
            botaoExcluir.Text = "excluir";
            botaoExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoExcluir.UseAccentColor = false;
            botaoExcluir.UseVisualStyleBackColor = true;
            botaoExcluir.Click += botaoExcluir_Click;
            // 
            // botaoNovo
            // 
            botaoNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botaoNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botaoNovo.Depth = 0;
            botaoNovo.HighEmphasis = true;
            botaoNovo.Icon = null;
            botaoNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botaoNovo.Location = new Point(460, 471);
            botaoNovo.Margin = new Padding(4, 6, 4, 6);
            botaoNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botaoNovo.Name = "botaoNovo";
            botaoNovo.NoAccentTextColor = Color.Empty;
            botaoNovo.Size = new Size(64, 36);
            botaoNovo.TabIndex = 0;
            botaoNovo.Text = "novo";
            botaoNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botaoNovo.UseAccentColor = false;
            botaoNovo.UseVisualStyleBackColor = true;
            botaoNovo.Click += botaoNovo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ImagemCadastro.png");
            imageList1.Images.SetKeyName(1, "ImagemConsulta.png");
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 626);
            Controls.Add(tabControlCadastro);
            DrawerTabControl = tabControlCadastro;
            Name = "CadastroBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroBase";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        protected ReaLTaiizor.Controls.MaterialTabControl tabControlCadastro;
        protected TabPage tabPageCadastro;
        protected TabPage tabPageConsulta;
        private ImageList imageList1;
        protected ReaLTaiizor.Controls.MaterialButton botaoCancelar;
        protected ReaLTaiizor.Controls.MaterialButton botaoSalvar;
        protected ReaLTaiizor.Controls.MaterialButton botaoNovo;
        protected ReaLTaiizor.Controls.MaterialButton botaoEditar;
        protected ReaLTaiizor.Controls.MaterialButton botaoExcluir;
        protected DataGridView dataGridViewConsulta;
    }
}
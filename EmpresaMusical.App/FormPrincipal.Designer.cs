namespace EmpresaMusical.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            musicoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            instrumentoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            albumToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            musicaToolStripMenuItem = new ToolStripMenuItem();
            relaçõesToolStripMenuItem = new ToolStripMenuItem();
            musicoInstrumentoToolStripMenuItem = new ToolStripMenuItem();
            musicAlbumToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblMusico = new ToolStripStatusLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            menuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relaçõesToolStripMenuItem, sairToolStripMenuItem });
            menuStrip.Location = new Point(3, 64);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(845, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { musicoToolStripMenuItem, toolStripSeparator1, instrumentoToolStripMenuItem, toolStripSeparator2, albumToolStripMenuItem, toolStripSeparator3, musicaToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // musicoToolStripMenuItem
            // 
            musicoToolStripMenuItem.Name = "musicoToolStripMenuItem";
            musicoToolStripMenuItem.Size = new Size(171, 26);
            musicoToolStripMenuItem.Text = "Músico";
            musicoToolStripMenuItem.Click += musicoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(168, 6);
            // 
            // instrumentoToolStripMenuItem
            // 
            instrumentoToolStripMenuItem.Name = "instrumentoToolStripMenuItem";
            instrumentoToolStripMenuItem.Size = new Size(171, 26);
            instrumentoToolStripMenuItem.Text = "Instrumento";
            instrumentoToolStripMenuItem.Click += instrumentoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(168, 6);
            // 
            // albumToolStripMenuItem
            // 
            albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            albumToolStripMenuItem.Size = new Size(171, 26);
            albumToolStripMenuItem.Text = "Álbum";
            albumToolStripMenuItem.Click += albumToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(168, 6);
            // 
            // musicaToolStripMenuItem
            // 
            musicaToolStripMenuItem.Name = "musicaToolStripMenuItem";
            musicaToolStripMenuItem.Size = new Size(171, 26);
            musicaToolStripMenuItem.Text = "Música";
            musicaToolStripMenuItem.Click += musicaToolStripMenuItem_Click;
            // 
            // relaçõesToolStripMenuItem
            // 
            relaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { musicoInstrumentoToolStripMenuItem, toolStripSeparator4, musicAlbumToolStripMenuItem });
            relaçõesToolStripMenuItem.Name = "relaçõesToolStripMenuItem";
            relaçõesToolStripMenuItem.Size = new Size(82, 24);
            relaçõesToolStripMenuItem.Text = "Relações";
            // 
            // musicoInstrumentoToolStripMenuItem
            // 
            musicoInstrumentoToolStripMenuItem.Name = "musicoInstrumentoToolStripMenuItem";
            musicoInstrumentoToolStripMenuItem.Size = new Size(224, 26);
            musicoInstrumentoToolStripMenuItem.Text = "Musico-Instrumento";
            musicoInstrumentoToolStripMenuItem.Click += musicoInstrumentoToolStripMenuItem_Click;
            // 
            // musicAlbumToolStripMenuItem
            // 
            musicAlbumToolStripMenuItem.Name = "musicAlbumToolStripMenuItem";
            musicAlbumToolStripMenuItem.Size = new Size(224, 26);
            musicAlbumToolStripMenuItem.Text = "Musico-Álbum";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblMusico });
            statusStrip1.Location = new Point(3, 542);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(845, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblMusico
            // 
            lblMusico.Name = "lblMusico";
            lblMusico.Size = new Size(56, 20);
            lblMusico.Text = "Musico";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(221, 6);
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(851, 571);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Empresa Musical";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem musicoToolStripMenuItem;
        private ToolStripMenuItem instrumentoToolStripMenuItem;
        private ToolStripMenuItem albumToolStripMenuItem;
        private ToolStripMenuItem musicaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblMusico;
        private ToolStripMenuItem relaçõesToolStripMenuItem;
        private ToolStripMenuItem musicoInstrumentoToolStripMenuItem;
        private ToolStripMenuItem musicAlbumToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
    }
}

namespace ProjetoFiguraGUI
{
    partial class ProjetoPrincipalMainView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeFigurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDDeCírculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasAsFigurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.figurasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoDeFigurasToolStripMenuItem,
            this.cRUDDeCírculosToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.figurasToolStripMenuItem.Text = "&Figuras";
            // 
            // manutençãoDeFigurasToolStripMenuItem
            // 
            this.manutençãoDeFigurasToolStripMenuItem.Name = "manutençãoDeFigurasToolStripMenuItem";
            this.manutençãoDeFigurasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manutençãoDeFigurasToolStripMenuItem.Text = "CRUD de Retângulos";
            this.manutençãoDeFigurasToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeFigurasToolStripMenuItem_Click);
            // 
            // cRUDDeCírculosToolStripMenuItem
            // 
            this.cRUDDeCírculosToolStripMenuItem.Name = "cRUDDeCírculosToolStripMenuItem";
            this.cRUDDeCírculosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cRUDDeCírculosToolStripMenuItem.Text = "CRUD de círculos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasAsFigurasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // todasAsFigurasToolStripMenuItem
            // 
            this.todasAsFigurasToolStripMenuItem.Name = "todasAsFigurasToolStripMenuItem";
            this.todasAsFigurasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.todasAsFigurasToolStripMenuItem.Text = "Todas as Figuras";
            this.todasAsFigurasToolStripMenuItem.Click += new System.EventHandler(this.todasAsFigurasToolStripMenuItem_Click);
            // 
            // ProjetoPrincipalMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjetoPrincipalMainView";
            this.Text = "Sistema de Gestão de Figuras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeFigurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDDeCírculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasAsFigurasToolStripMenuItem;
    }
}


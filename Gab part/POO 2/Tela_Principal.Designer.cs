namespace POO_2
{
    partial class Tela_Principal
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
            this.Menu_Principal = new System.Windows.Forms.MenuStrip();
            this.Menu_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.BtFuncionariosTLprincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.BtProdutosTLprincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Principal
            // 
            this.Menu_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Cadastro,
            this.Menu_Consulta,
            this.Menu_Relatorio});
            this.Menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal.Name = "Menu_Principal";
            this.Menu_Principal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menu_Principal.Size = new System.Drawing.Size(586, 24);
            this.Menu_Principal.TabIndex = 1;
            this.Menu_Principal.Text = "Menu_Principal";
            this.Menu_Principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Menu_Cadastro
            // 
            this.Menu_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtFuncionariosTLprincipal,
            this.BtProdutosTLprincipal});
            this.Menu_Cadastro.Name = "Menu_Cadastro";
            this.Menu_Cadastro.Size = new System.Drawing.Size(66, 20);
            this.Menu_Cadastro.Text = "Cadastro";
            // 
            // BtFuncionariosTLprincipal
            // 
            this.BtFuncionariosTLprincipal.Name = "BtFuncionariosTLprincipal";
            this.BtFuncionariosTLprincipal.Size = new System.Drawing.Size(180, 22);
            this.BtFuncionariosTLprincipal.Text = "Funcionarios";
            this.BtFuncionariosTLprincipal.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // BtProdutosTLprincipal
            // 
            this.BtProdutosTLprincipal.Name = "BtProdutosTLprincipal";
            this.BtProdutosTLprincipal.Size = new System.Drawing.Size(180, 22);
            this.BtProdutosTLprincipal.Text = "Produtos";
            this.BtProdutosTLprincipal.Click += new System.EventHandler(this.BtProdutosTLprincipal_Click);
            // 
            // Menu_Consulta
            // 
            this.Menu_Consulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem});
            this.Menu_Consulta.Name = "Menu_Consulta";
            this.Menu_Consulta.Size = new System.Drawing.Size(66, 20);
            this.Menu_Consulta.Text = "Consulta";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // Menu_Relatorio
            // 
            this.Menu_Relatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.Menu_Relatorio.Name = "Menu_Relatorio";
            this.Menu_Relatorio.Size = new System.Drawing.Size(66, 20);
            this.Menu_Relatorio.Text = "Relatorio";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.Menu_Principal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu_Principal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tela_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Tela_Principal";
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.Menu_Principal.ResumeLayout(false);
            this.Menu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_Cadastro;
        private System.Windows.Forms.ToolStripMenuItem BtFuncionariosTLprincipal;
        private System.Windows.Forms.ToolStripMenuItem Menu_Consulta;
        private System.Windows.Forms.ToolStripMenuItem BtProdutosTLprincipal;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Relatorio;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}
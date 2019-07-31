namespace CRMesc.APRESENTACAO
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dISCIPLINAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pONTUAÇAOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adcionarNovoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.dISCIPLINAToolStripMenuItem,
            this.pONTUAÇAOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adcionarNovoAlunoToolStripMenuItem,
            this.nomeToolStripMenuItem,
            this.estatisticasToolStripMenuItem,
            this.editarRemoverToolStripMenuItem,
            this.mSFToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.alunoToolStripMenuItem.Text = "ALUNO";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.AlunoToolStripMenuItem_Click);
            // 
            // dISCIPLINAToolStripMenuItem
            // 
            this.dISCIPLINAToolStripMenuItem.Name = "dISCIPLINAToolStripMenuItem";
            this.dISCIPLINAToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.dISCIPLINAToolStripMenuItem.Text = "DISCIPLINA";
            // 
            // pONTUAÇAOToolStripMenuItem
            // 
            this.pONTUAÇAOToolStripMenuItem.Name = "pONTUAÇAOToolStripMenuItem";
            this.pONTUAÇAOToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.pONTUAÇAOToolStripMenuItem.Text = "PONTUAÇAO";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // adcionarNovoAlunoToolStripMenuItem
            // 
            this.adcionarNovoAlunoToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.adcionarNovoAlunoToolStripMenuItem.Name = "adcionarNovoAlunoToolStripMenuItem";
            this.adcionarNovoAlunoToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.adcionarNovoAlunoToolStripMenuItem.Text = "Adicionar Novo Aluno";
            this.adcionarNovoAlunoToolStripMenuItem.Click += new System.EventHandler(this.AdcionarNovoAlunoToolStripMenuItem_Click);
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.nomeToolStripMenuItem.Text = "Lista de Aluno";
            this.nomeToolStripMenuItem.Click += new System.EventHandler(this.NomeToolStripMenuItem_Click);
            // 
            // estatisticasToolStripMenuItem
            // 
            this.estatisticasToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.estatisticasToolStripMenuItem.Name = "estatisticasToolStripMenuItem";
            this.estatisticasToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.estatisticasToolStripMenuItem.Text = "Estatisticas";
            this.estatisticasToolStripMenuItem.Click += new System.EventHandler(this.EstatisticasToolStripMenuItem_Click);
            // 
            // editarRemoverToolStripMenuItem
            // 
            this.editarRemoverToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.editarRemoverToolStripMenuItem.Name = "editarRemoverToolStripMenuItem";
            this.editarRemoverToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.editarRemoverToolStripMenuItem.Text = "Editar / Remover";
            this.editarRemoverToolStripMenuItem.Click += new System.EventHandler(this.EditarRemoverToolStripMenuItem_Click);
            // 
            // mSFToolStripMenuItem
            // 
            this.mSFToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mSFToolStripMenuItem.Name = "mSFToolStripMenuItem";
            this.mSFToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.mSFToolStripMenuItem.Text = "Gerenciar gestor de aluno";
            this.mSFToolStripMenuItem.Click += new System.EventHandler(this.MSFToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 448);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISCIPLINAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pONTUAÇAOToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adcionarNovoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRemoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    }
}
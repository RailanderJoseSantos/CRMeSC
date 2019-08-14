namespace CRMesc.APRESENTACAO
{
    partial class Lista_Alunos
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
            this.grid_Alunos = new System.Windows.Forms.DataGridView();
            this.grid_responsavel = new System.Windows.Forms.DataGridView();
            this.grid_Telefone = new System.Windows.Forms.DataGridView();
            this.grid_Endereco = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_responsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Telefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Endereco)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Alunos
            // 
            this.grid_Alunos.AllowUserToAddRows = false;
            this.grid_Alunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Alunos.Location = new System.Drawing.Point(12, 12);
            this.grid_Alunos.Name = "grid_Alunos";
            this.grid_Alunos.Size = new System.Drawing.Size(416, 380);
            this.grid_Alunos.TabIndex = 0;
            this.grid_Alunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Alunos_CellContentClick);
            this.grid_Alunos.DoubleClick += new System.EventHandler(this.Grid_Alunos_DoubleClick);
            // 
            // grid_responsavel
            // 
            this.grid_responsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_responsavel.Location = new System.Drawing.Point(434, 12);
            this.grid_responsavel.Name = "grid_responsavel";
            this.grid_responsavel.Size = new System.Drawing.Size(347, 380);
            this.grid_responsavel.TabIndex = 1;
            // 
            // grid_Telefone
            // 
            this.grid_Telefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Telefone.Location = new System.Drawing.Point(787, 12);
            this.grid_Telefone.Name = "grid_Telefone";
            this.grid_Telefone.Size = new System.Drawing.Size(232, 380);
            this.grid_Telefone.TabIndex = 2;
            // 
            // grid_Endereco
            // 
            this.grid_Endereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Endereco.Location = new System.Drawing.Point(1025, 12);
            this.grid_Endereco.Name = "grid_Endereco";
            this.grid_Endereco.Size = new System.Drawing.Size(235, 380);
            this.grid_Endereco.TabIndex = 3;
            // 
            // Lista_Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 450);
            this.Controls.Add(this.grid_Endereco);
            this.Controls.Add(this.grid_Telefone);
            this.Controls.Add(this.grid_responsavel);
            this.Controls.Add(this.grid_Alunos);
            this.Name = "Lista_Alunos";
            this.Text = "Lista_Alunos";
            this.Load += new System.EventHandler(this.Lista_Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_responsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Telefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Endereco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Alunos;
        private System.Windows.Forms.DataGridView grid_responsavel;
        private System.Windows.Forms.DataGridView grid_Telefone;
        private System.Windows.Forms.DataGridView grid_Endereco;
    }
}
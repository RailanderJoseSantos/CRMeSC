namespace CRMesc
{
    partial class ListaAlunoForm
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
            this.grid_alunos = new System.Windows.Forms.DataGridView();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_alunos
            // 
            this.grid_alunos.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.grid_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alunos.Location = new System.Drawing.Point(15, 13);
            this.grid_alunos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_alunos.Name = "grid_alunos";
            this.grid_alunos.Size = new System.Drawing.Size(1029, 407);
            this.grid_alunos.TabIndex = 0;
            this.grid_alunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_alunos_CellContentClick);
            this.grid_alunos.DoubleClick += new System.EventHandler(this.Grid_alunos_DoubleClick);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.Navy;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Atualizar.Location = new System.Drawing.Point(15, 428);
            this.btn_Atualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(146, 45);
            this.btn_Atualizar.TabIndex = 1;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // ListaAlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1067, 486);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.grid_alunos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListaAlunoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaAlunoForm";
            this.Load += new System.EventHandler(this.ListaAlunoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_alunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_alunos;
        private System.Windows.Forms.Button btn_Atualizar;
    }
}
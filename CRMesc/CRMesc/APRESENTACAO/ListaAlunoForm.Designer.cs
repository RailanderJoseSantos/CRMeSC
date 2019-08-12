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
            this.dataGrid_EnderecoAluno = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_EnderecoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_alunos
            // 
            this.grid_alunos.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.grid_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alunos.Location = new System.Drawing.Point(15, 13);
            this.grid_alunos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_alunos.Name = "grid_alunos";
            this.grid_alunos.Size = new System.Drawing.Size(435, 407);
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
            // dataGrid_EnderecoAluno
            // 
            this.dataGrid_EnderecoAluno.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGrid_EnderecoAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_EnderecoAluno.Location = new System.Drawing.Point(456, 13);
            this.dataGrid_EnderecoAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGrid_EnderecoAluno.Name = "dataGrid_EnderecoAluno";
            this.dataGrid_EnderecoAluno.Size = new System.Drawing.Size(482, 407);
            this.dataGrid_EnderecoAluno.TabIndex = 2;
            this.dataGrid_EnderecoAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_EnderecoAluno_CellContentClick);
            this.dataGrid_EnderecoAluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_EnderecoAluno_CellDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(944, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(98, 407);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1048, 13);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(170, 407);
            this.dataGridView2.TabIndex = 4;
            // 
            // ListaAlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1342, 486);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGrid_EnderecoAluno);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_EnderecoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_alunos;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.DataGridView dataGrid_EnderecoAluno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
namespace CRMesc
{
    partial class AdicionarAlunoForm
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nomeAluno = new System.Windows.Forms.TextBox();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.dtBox_nascimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.gb_genero = new System.Windows.Forms.GroupBox();
            this.td_btn_generoFem = new System.Windows.Forms.RadioButton();
            this.rd_btn_genero_masc = new System.Windows.Forms.RadioButton();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.pctb_fotoAluno = new System.Windows.Forms.PictureBox();
            this.btn_adicionarfotoaluno = new System.Windows.Forms.Button();
            this.btn_salvarmatricula = new System.Windows.Forms.Button();
            this.btn_cancelarMatricula = new System.Windows.Forms.Button();
            this.gb_genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_fotoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(12, 21);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(138, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome completo:";
            // 
            // txt_nomeAluno
            // 
            this.txt_nomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeAluno.Location = new System.Drawing.Point(156, 21);
            this.txt_nomeAluno.Name = "txt_nomeAluno";
            this.txt_nomeAluno.Size = new System.Drawing.Size(233, 26);
            this.txt_nomeAluno.TabIndex = 1;
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.ForeColor = System.Drawing.Color.White;
            this.lbl_nascimento.Location = new System.Drawing.Point(51, 68);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(99, 20);
            this.lbl_nascimento.TabIndex = 2;
            this.lbl_nascimento.Text = "Nacimento:";
            // 
            // dtBox_nascimento
            // 
            this.dtBox_nascimento.Location = new System.Drawing.Point(156, 68);
            this.dtBox_nascimento.Name = "dtBox_nascimento";
            this.dtBox_nascimento.Size = new System.Drawing.Size(233, 20);
            this.dtBox_nascimento.TabIndex = 3;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.Color.White;
            this.lbl_genero.Location = new System.Drawing.Point(76, 121);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(74, 20);
            this.lbl_genero.TabIndex = 4;
            this.lbl_genero.Text = "Gênero:";
            // 
            // gb_genero
            // 
            this.gb_genero.Controls.Add(this.td_btn_generoFem);
            this.gb_genero.Controls.Add(this.rd_btn_genero_masc);
            this.gb_genero.ForeColor = System.Drawing.Color.White;
            this.gb_genero.Location = new System.Drawing.Point(156, 107);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Size = new System.Drawing.Size(233, 40);
            this.gb_genero.TabIndex = 5;
            this.gb_genero.TabStop = false;
            this.gb_genero.Text = "Sexo";
            // 
            // td_btn_generoFem
            // 
            this.td_btn_generoFem.AutoSize = true;
            this.td_btn_generoFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.td_btn_generoFem.Location = new System.Drawing.Point(108, 14);
            this.td_btn_generoFem.Name = "td_btn_generoFem";
            this.td_btn_generoFem.Size = new System.Drawing.Size(81, 20);
            this.td_btn_generoFem.TabIndex = 1;
            this.td_btn_generoFem.TabStop = true;
            this.td_btn_generoFem.Text = "Feminino";
            this.td_btn_generoFem.UseVisualStyleBackColor = true;
            // 
            // rd_btn_genero_masc
            // 
            this.rd_btn_genero_masc.AutoSize = true;
            this.rd_btn_genero_masc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_genero_masc.Location = new System.Drawing.Point(15, 14);
            this.rd_btn_genero_masc.Name = "rd_btn_genero_masc";
            this.rd_btn_genero_masc.Size = new System.Drawing.Size(87, 20);
            this.rd_btn_genero_masc.TabIndex = 0;
            this.rd_btn_genero_masc.TabStop = true;
            this.rd_btn_genero_masc.Text = "Masculino";
            this.rd_btn_genero_masc.UseVisualStyleBackColor = true;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(156, 166);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(233, 26);
            this.txt_telefone.TabIndex = 7;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.ForeColor = System.Drawing.Color.White;
            this.lbl_telefone.Location = new System.Drawing.Point(66, 166);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(84, 20);
            this.lbl_telefone.TabIndex = 6;
            this.lbl_telefone.Text = "Telefone:";
            this.lbl_telefone.Click += new System.EventHandler(this.Lbl_telefone_Click);
            // 
            // txt_endereco
            // 
            this.txt_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(156, 212);
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(236, 72);
            this.txt_endereco.TabIndex = 9;
            this.txt_endereco.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.ForeColor = System.Drawing.Color.White;
            this.lbl_endereco.Location = new System.Drawing.Point(59, 215);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(91, 20);
            this.lbl_endereco.TabIndex = 8;
            this.lbl_endereco.Text = "Endereço:";
            this.lbl_endereco.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.ForeColor = System.Drawing.Color.White;
            this.lbl_foto.Location = new System.Drawing.Point(54, 302);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(96, 20);
            this.lbl_foto.TabIndex = 10;
            this.lbl_foto.Text = "Foto (3x4):";
            // 
            // pctb_fotoAluno
            // 
            this.pctb_fotoAluno.BackColor = System.Drawing.Color.White;
            this.pctb_fotoAluno.Location = new System.Drawing.Point(156, 302);
            this.pctb_fotoAluno.Name = "pctb_fotoAluno";
            this.pctb_fotoAluno.Size = new System.Drawing.Size(111, 93);
            this.pctb_fotoAluno.TabIndex = 11;
            this.pctb_fotoAluno.TabStop = false;
            // 
            // btn_adicionarfotoaluno
            // 
            this.btn_adicionarfotoaluno.Location = new System.Drawing.Point(156, 403);
            this.btn_adicionarfotoaluno.Name = "btn_adicionarfotoaluno";
            this.btn_adicionarfotoaluno.Size = new System.Drawing.Size(52, 23);
            this.btn_adicionarfotoaluno.TabIndex = 13;
            this.btn_adicionarfotoaluno.Text = "Inserir";
            this.btn_adicionarfotoaluno.UseVisualStyleBackColor = true;
            // 
            // btn_salvarmatricula
            // 
            this.btn_salvarmatricula.BackColor = System.Drawing.Color.Green;
            this.btn_salvarmatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvarmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarmatricula.ForeColor = System.Drawing.Color.White;
            this.btn_salvarmatricula.Location = new System.Drawing.Point(196, 452);
            this.btn_salvarmatricula.Name = "btn_salvarmatricula";
            this.btn_salvarmatricula.Size = new System.Drawing.Size(128, 40);
            this.btn_salvarmatricula.TabIndex = 14;
            this.btn_salvarmatricula.Text = "Salvar";
            this.btn_salvarmatricula.UseVisualStyleBackColor = false;
            this.btn_salvarmatricula.Click += new System.EventHandler(this.Btn_salvarmatricula_Click);
            // 
            // btn_cancelarMatricula
            // 
            this.btn_cancelarMatricula.BackColor = System.Drawing.Color.Red;
            this.btn_cancelarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarMatricula.ForeColor = System.Drawing.Color.White;
            this.btn_cancelarMatricula.Location = new System.Drawing.Point(12, 452);
            this.btn_cancelarMatricula.Name = "btn_cancelarMatricula";
            this.btn_cancelarMatricula.Size = new System.Drawing.Size(128, 40);
            this.btn_cancelarMatricula.TabIndex = 15;
            this.btn_cancelarMatricula.Text = "Cancelar";
            this.btn_cancelarMatricula.UseVisualStyleBackColor = false;
            // 
            // AdicionarAlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(421, 504);
            this.Controls.Add(this.btn_cancelarMatricula);
            this.Controls.Add(this.btn_salvarmatricula);
            this.Controls.Add(this.btn_adicionarfotoaluno);
            this.Controls.Add(this.pctb_fotoAluno);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.gb_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.dtBox_nascimento);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.txt_nomeAluno);
            this.Controls.Add(this.lbl_nome);
            this.Name = "AdicionarAlunoForm";
            this.Text = "AdicionarAlunoForm";
            this.Load += new System.EventHandler(this.AdicionarAlunoForm_Load);
            this.gb_genero.ResumeLayout(false);
            this.gb_genero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_fotoAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nomeAluno;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.DateTimePicker dtBox_nascimento;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.GroupBox gb_genero;
        private System.Windows.Forms.RadioButton td_btn_generoFem;
        private System.Windows.Forms.RadioButton rd_btn_genero_masc;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.PictureBox pctb_fotoAluno;
        private System.Windows.Forms.Button btn_adicionarfotoaluno;
        private System.Windows.Forms.Button btn_salvarmatricula;
        private System.Windows.Forms.Button btn_cancelarMatricula;
    }
}
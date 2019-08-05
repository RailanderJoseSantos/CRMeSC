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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.dtBox_nascimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.gb_genero = new System.Windows.Forms.GroupBox();
            this.rd_btn_generoFem = new System.Windows.Forms.RadioButton();
            this.rd_btn_generoMasc = new System.Windows.Forms.RadioButton();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.pctb_foto = new System.Windows.Forms.PictureBox();
            this.btn_adicionarfotoaluno = new System.Windows.Forms.Button();
            this.btn_salvarmatricula = new System.Windows.Forms.Button();
            this.btn_cancelarMatricula = new System.Windows.Forms.Button();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.btn_preencher_endereco = new System.Windows.Forms.Button();
            this.lbl_end = new System.Windows.Forms.Label();
            this.txt_codEndAluno = new System.Windows.Forms.TextBox();
            this.btn_anexarId = new System.Windows.Forms.Button();
            this.gb_genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(12, 24);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(138, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome completo:";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(156, 21);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(233, 26);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Text = "teste";
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
            this.dtBox_nascimento.Checked = false;
            this.dtBox_nascimento.CustomFormat = "dd/MM/yyyy";
            this.dtBox_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBox_nascimento.Location = new System.Drawing.Point(156, 68);
            this.dtBox_nascimento.Name = "dtBox_nascimento";
            this.dtBox_nascimento.Size = new System.Drawing.Size(233, 20);
            this.dtBox_nascimento.TabIndex = 3;
            this.dtBox_nascimento.Value = new System.DateTime(2011, 8, 1, 0, 0, 0, 0);
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.Color.White;
            this.lbl_genero.Location = new System.Drawing.Point(76, 175);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(74, 20);
            this.lbl_genero.TabIndex = 4;
            this.lbl_genero.Text = "Gênero:";
            // 
            // gb_genero
            // 
            this.gb_genero.Controls.Add(this.rd_btn_generoFem);
            this.gb_genero.Controls.Add(this.rd_btn_generoMasc);
            this.gb_genero.ForeColor = System.Drawing.Color.White;
            this.gb_genero.Location = new System.Drawing.Point(156, 161);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Size = new System.Drawing.Size(233, 40);
            this.gb_genero.TabIndex = 5;
            this.gb_genero.TabStop = false;
            this.gb_genero.Text = "Sexo";
            // 
            // rd_btn_generoFem
            // 
            this.rd_btn_generoFem.AutoSize = true;
            this.rd_btn_generoFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_generoFem.Location = new System.Drawing.Point(108, 14);
            this.rd_btn_generoFem.Name = "rd_btn_generoFem";
            this.rd_btn_generoFem.Size = new System.Drawing.Size(81, 20);
            this.rd_btn_generoFem.TabIndex = 1;
            this.rd_btn_generoFem.Text = "Feminino";
            this.rd_btn_generoFem.UseVisualStyleBackColor = true;
            // 
            // rd_btn_generoMasc
            // 
            this.rd_btn_generoMasc.AutoSize = true;
            this.rd_btn_generoMasc.Checked = true;
            this.rd_btn_generoMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_generoMasc.Location = new System.Drawing.Point(15, 14);
            this.rd_btn_generoMasc.Name = "rd_btn_generoMasc";
            this.rd_btn_generoMasc.Size = new System.Drawing.Size(87, 20);
            this.rd_btn_generoMasc.TabIndex = 0;
            this.rd_btn_generoMasc.TabStop = true;
            this.rd_btn_generoMasc.Text = "Masculino";
            this.rd_btn_generoMasc.UseVisualStyleBackColor = true;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(156, 119);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(233, 26);
            this.txt_telefone.TabIndex = 7;
            this.txt_telefone.Text = "111";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.ForeColor = System.Drawing.Color.White;
            this.lbl_telefone.Location = new System.Drawing.Point(66, 119);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(84, 20);
            this.lbl_telefone.TabIndex = 6;
            this.lbl_telefone.Text = "Telefone:";
            this.lbl_telefone.Click += new System.EventHandler(this.Lbl_telefone_Click);
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.ForeColor = System.Drawing.Color.White;
            this.lbl_foto.Location = new System.Drawing.Point(54, 311);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(96, 20);
            this.lbl_foto.TabIndex = 10;
            this.lbl_foto.Text = "Foto (3x4):";
            // 
            // pctb_foto
            // 
            this.pctb_foto.BackColor = System.Drawing.Color.White;
            this.pctb_foto.Location = new System.Drawing.Point(156, 311);
            this.pctb_foto.Name = "pctb_foto";
            this.pctb_foto.Size = new System.Drawing.Size(102, 93);
            this.pctb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctb_foto.TabIndex = 11;
            this.pctb_foto.TabStop = false;
            this.pctb_foto.Click += new System.EventHandler(this.Pctb_foto_Click);
            // 
            // btn_adicionarfotoaluno
            // 
            this.btn_adicionarfotoaluno.BackColor = System.Drawing.Color.Green;
            this.btn_adicionarfotoaluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionarfotoaluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionarfotoaluno.ForeColor = System.Drawing.Color.White;
            this.btn_adicionarfotoaluno.Location = new System.Drawing.Point(156, 412);
            this.btn_adicionarfotoaluno.Name = "btn_adicionarfotoaluno";
            this.btn_adicionarfotoaluno.Size = new System.Drawing.Size(102, 28);
            this.btn_adicionarfotoaluno.TabIndex = 13;
            this.btn_adicionarfotoaluno.Text = "Inserir";
            this.btn_adicionarfotoaluno.UseVisualStyleBackColor = false;
            this.btn_adicionarfotoaluno.Click += new System.EventHandler(this.Btn_adicionarfotoaluno_Click);
            // 
            // btn_salvarmatricula
            // 
            this.btn_salvarmatricula.BackColor = System.Drawing.Color.Green;
            this.btn_salvarmatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvarmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarmatricula.ForeColor = System.Drawing.Color.White;
            this.btn_salvarmatricula.Location = new System.Drawing.Point(261, 452);
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
            this.btn_cancelarMatricula.Location = new System.Drawing.Point(22, 452);
            this.btn_cancelarMatricula.Name = "btn_cancelarMatricula";
            this.btn_cancelarMatricula.Size = new System.Drawing.Size(128, 40);
            this.btn_cancelarMatricula.TabIndex = 15;
            this.btn_cancelarMatricula.Text = "Cancelar";
            this.btn_cancelarMatricula.UseVisualStyleBackColor = false;
            this.btn_cancelarMatricula.Click += new System.EventHandler(this.Btn_cancelarMatricula_Click);
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
            // btn_preencher_endereco
            // 
            this.btn_preencher_endereco.BackColor = System.Drawing.Color.Silver;
            this.btn_preencher_endereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preencher_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preencher_endereco.ForeColor = System.Drawing.Color.Black;
            this.btn_preencher_endereco.Location = new System.Drawing.Point(156, 225);
            this.btn_preencher_endereco.Name = "btn_preencher_endereco";
            this.btn_preencher_endereco.Size = new System.Drawing.Size(99, 28);
            this.btn_preencher_endereco.TabIndex = 16;
            this.btn_preencher_endereco.Text = "Preencher:";
            this.btn_preencher_endereco.UseVisualStyleBackColor = false;
            this.btn_preencher_endereco.Click += new System.EventHandler(this.Btn_preencher_endereco_Click);
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end.ForeColor = System.Drawing.Color.White;
            this.lbl_end.Location = new System.Drawing.Point(59, 229);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(91, 20);
            this.lbl_end.TabIndex = 17;
            this.lbl_end.Text = "Endereço:";
            // 
            // txt_codEndAluno
            // 
            this.txt_codEndAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codEndAluno.Location = new System.Drawing.Point(351, 228);
            this.txt_codEndAluno.Name = "txt_codEndAluno";
            this.txt_codEndAluno.ReadOnly = true;
            this.txt_codEndAluno.Size = new System.Drawing.Size(51, 26);
            this.txt_codEndAluno.TabIndex = 20;
            this.txt_codEndAluno.TextChanged += new System.EventHandler(this.Txt_codEndAluno_TextChanged);
            // 
            // btn_anexarId
            // 
            this.btn_anexarId.BackColor = System.Drawing.Color.Silver;
            this.btn_anexarId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anexarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anexarId.ForeColor = System.Drawing.Color.Black;
            this.btn_anexarId.Location = new System.Drawing.Point(261, 225);
            this.btn_anexarId.Name = "btn_anexarId";
            this.btn_anexarId.Size = new System.Drawing.Size(84, 29);
            this.btn_anexarId.TabIndex = 21;
            this.btn_anexarId.Text = "Anexar:";
            this.btn_anexarId.UseVisualStyleBackColor = false;
            this.btn_anexarId.Click += new System.EventHandler(this.btn_anexarId_Clicked);
            // 
            // AdicionarAlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(478, 504);
            this.Controls.Add(this.btn_anexarId);
            this.Controls.Add(this.txt_codEndAluno);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.btn_preencher_endereco);
            this.Controls.Add(this.btn_cancelarMatricula);
            this.Controls.Add(this.btn_salvarmatricula);
            this.Controls.Add(this.btn_adicionarfotoaluno);
            this.Controls.Add(this.pctb_foto);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.gb_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.dtBox_nascimento);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "AdicionarAlunoForm";
            this.Text = "AdicionarAlunoForm";
            this.Load += new System.EventHandler(this.AdicionarAlunoForm_Load);
            this.gb_genero.ResumeLayout(false);
            this.gb_genero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.DateTimePicker dtBox_nascimento;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.GroupBox gb_genero;
        private System.Windows.Forms.RadioButton rd_btn_generoFem;
        private System.Windows.Forms.RadioButton rd_btn_generoMasc;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.PictureBox pctb_foto;
        private System.Windows.Forms.Button btn_salvarmatricula;
        private System.Windows.Forms.Button btn_cancelarMatricula;
        private System.Windows.Forms.Button btn_adicionarfotoaluno;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Button btn_anexarId;
    }
}
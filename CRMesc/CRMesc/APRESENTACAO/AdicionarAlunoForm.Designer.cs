namespace CRMesc
{
    partial class AdicionarEnderecoForm
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
            this.lbl_foto = new System.Windows.Forms.Label();
            this.pctb_foto = new System.Windows.Forms.PictureBox();
            this.btn_adicionarfotoaluno = new System.Windows.Forms.Button();
            this.btn_salvarmatricula = new System.Windows.Forms.Button();
            this.btn_cancelarMatricula = new System.Windows.Forms.Button();
            this.label_cep = new System.Windows.Forms.Label();
            this.label_uf = new System.Windows.Forms.Label();
            this.label_cidade = new System.Windows.Forms.Label();
            this.label_bairro = new System.Windows.Forms.Label();
            this.label_rua = new System.Windows.Forms.Label();
            this.label_numero = new System.Windows.Forms.Label();
            this.textBox_uf = new System.Windows.Forms.TextBox();
            this.textBox_cidade = new System.Windows.Forms.TextBox();
            this.textBox_bairro = new System.Windows.Forms.TextBox();
            this.textBox_rua = new System.Windows.Forms.TextBox();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.button_buscaCep = new System.Windows.Forms.Button();
            this.label_responsavel = new System.Windows.Forms.Label();
            this.textBox_responsavel = new System.Windows.Forms.TextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.mascara_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.mascara_cep = new System.Windows.Forms.MaskedTextBox();
            this.gb_genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(141, 45);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(138, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome completo:";
            // 
            // txt_nome
            // 
            this.txt_nome.AcceptsTab = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(285, 42);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(260, 26);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.ForeColor = System.Drawing.Color.White;
            this.lbl_nascimento.Location = new System.Drawing.Point(180, 98);
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
            this.dtBox_nascimento.Location = new System.Drawing.Point(285, 98);
            this.dtBox_nascimento.Name = "dtBox_nascimento";
            this.dtBox_nascimento.Size = new System.Drawing.Size(260, 20);
            this.dtBox_nascimento.TabIndex = 3;
            this.dtBox_nascimento.Value = new System.DateTime(2019, 8, 1, 0, 0, 0, 0);
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.Color.White;
            this.lbl_genero.Location = new System.Drawing.Point(205, 170);
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
            this.gb_genero.Location = new System.Drawing.Point(285, 150);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Size = new System.Drawing.Size(260, 40);
            this.gb_genero.TabIndex = 5;
            this.gb_genero.TabStop = false;
            this.gb_genero.Text = "Sexo";
            // 
            // rd_btn_generoFem
            // 
            this.rd_btn_generoFem.AutoSize = true;
            this.rd_btn_generoFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_generoFem.Location = new System.Drawing.Point(152, 14);
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
            this.rd_btn_generoMasc.Location = new System.Drawing.Point(24, 14);
            this.rd_btn_generoMasc.Name = "rd_btn_generoMasc";
            this.rd_btn_generoMasc.Size = new System.Drawing.Size(87, 20);
            this.rd_btn_generoMasc.TabIndex = 0;
            this.rd_btn_generoMasc.TabStop = true;
            this.rd_btn_generoMasc.Text = "Masculino";
            this.rd_btn_generoMasc.UseVisualStyleBackColor = true;
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.ForeColor = System.Drawing.Color.White;
            this.lbl_foto.Location = new System.Drawing.Point(12, 9);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(96, 20);
            this.lbl_foto.TabIndex = 10;
            this.lbl_foto.Text = "Foto (3x4):";
            // 
            // pctb_foto
            // 
            this.pctb_foto.BackColor = System.Drawing.Color.White;
            this.pctb_foto.Location = new System.Drawing.Point(16, 42);
            this.pctb_foto.Name = "pctb_foto";
            this.pctb_foto.Size = new System.Drawing.Size(102, 116);
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
            this.btn_adicionarfotoaluno.Location = new System.Drawing.Point(16, 166);
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
            this.btn_salvarmatricula.Location = new System.Drawing.Point(406, 452);
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
            this.btn_cancelarMatricula.Location = new System.Drawing.Point(58, 452);
            this.btn_cancelarMatricula.Name = "btn_cancelarMatricula";
            this.btn_cancelarMatricula.Size = new System.Drawing.Size(128, 40);
            this.btn_cancelarMatricula.TabIndex = 15;
            this.btn_cancelarMatricula.Text = "Cancelar";
            this.btn_cancelarMatricula.UseVisualStyleBackColor = false;
            this.btn_cancelarMatricula.Click += new System.EventHandler(this.Btn_cancelarMatricula_Click);
            // 
            // label_cep
            // 
            this.label_cep.AutoSize = true;
            this.label_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cep.ForeColor = System.Drawing.Color.White;
            this.label_cep.Location = new System.Drawing.Point(670, 39);
            this.label_cep.Name = "label_cep";
            this.label_cep.Size = new System.Drawing.Size(46, 20);
            this.label_cep.TabIndex = 0;
            this.label_cep.Text = "Cep:";
            // 
            // label_uf
            // 
            this.label_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uf.ForeColor = System.Drawing.Color.White;
            this.label_uf.Location = new System.Drawing.Point(677, 241);
            this.label_uf.Name = "label_uf";
            this.label_uf.Size = new System.Drawing.Size(40, 20);
            this.label_uf.TabIndex = 1;
            this.label_uf.Text = "UF: ";
            // 
            // label_cidade
            // 
            this.label_cidade.AutoSize = true;
            this.label_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cidade.ForeColor = System.Drawing.Color.White;
            this.label_cidade.Location = new System.Drawing.Point(647, 96);
            this.label_cidade.Name = "label_cidade";
            this.label_cidade.Size = new System.Drawing.Size(70, 20);
            this.label_cidade.TabIndex = 2;
            this.label_cidade.Text = "Cidade:";
            // 
            // label_bairro
            // 
            this.label_bairro.AutoSize = true;
            this.label_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bairro.ForeColor = System.Drawing.Color.White;
            this.label_bairro.Location = new System.Drawing.Point(654, 150);
            this.label_bairro.Name = "label_bairro";
            this.label_bairro.Size = new System.Drawing.Size(62, 20);
            this.label_bairro.TabIndex = 3;
            this.label_bairro.Text = "Bairro:";
            this.label_bairro.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label_rua
            // 
            this.label_rua.AutoSize = true;
            this.label_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rua.ForeColor = System.Drawing.Color.White;
            this.label_rua.Location = new System.Drawing.Point(670, 199);
            this.label_rua.Name = "label_rua";
            this.label_rua.Size = new System.Drawing.Size(47, 20);
            this.label_rua.TabIndex = 4;
            this.label_rua.Text = "Rua:";
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.ForeColor = System.Drawing.Color.White;
            this.label_numero.Location = new System.Drawing.Point(783, 238);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(76, 20);
            this.label_numero.TabIndex = 5;
            this.label_numero.Text = "Número:";
            // 
            // textBox_uf
            // 
            this.textBox_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_uf.Location = new System.Drawing.Point(719, 238);
            this.textBox_uf.Name = "textBox_uf";
            this.textBox_uf.Size = new System.Drawing.Size(49, 26);
            this.textBox_uf.TabIndex = 7;
            // 
            // textBox_cidade
            // 
            this.textBox_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cidade.Location = new System.Drawing.Point(719, 96);
            this.textBox_cidade.Name = "textBox_cidade";
            this.textBox_cidade.Size = new System.Drawing.Size(257, 26);
            this.textBox_cidade.TabIndex = 8;
            // 
            // textBox_bairro
            // 
            this.textBox_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bairro.Location = new System.Drawing.Point(719, 150);
            this.textBox_bairro.Name = "textBox_bairro";
            this.textBox_bairro.Size = new System.Drawing.Size(257, 26);
            this.textBox_bairro.TabIndex = 9;
            // 
            // textBox_rua
            // 
            this.textBox_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rua.Location = new System.Drawing.Point(719, 199);
            this.textBox_rua.Name = "textBox_rua";
            this.textBox_rua.Size = new System.Drawing.Size(257, 26);
            this.textBox_rua.TabIndex = 10;
            // 
            // textBox_numero
            // 
            this.textBox_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_numero.Location = new System.Drawing.Point(865, 235);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(111, 26);
            this.textBox_numero.TabIndex = 11;
            this.textBox_numero.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // button_buscaCep
            // 
            this.button_buscaCep.BackColor = System.Drawing.Color.Green;
            this.button_buscaCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscaCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscaCep.ForeColor = System.Drawing.Color.White;
            this.button_buscaCep.Location = new System.Drawing.Point(865, 36);
            this.button_buscaCep.Name = "button_buscaCep";
            this.button_buscaCep.Size = new System.Drawing.Size(111, 26);
            this.button_buscaCep.TabIndex = 12;
            this.button_buscaCep.Text = "Buscar";
            this.button_buscaCep.UseVisualStyleBackColor = false;
            this.button_buscaCep.Click += new System.EventHandler(this.Button_buscaCep_Click);
            // 
            // label_responsavel
            // 
            this.label_responsavel.AutoSize = true;
            this.label_responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_responsavel.ForeColor = System.Drawing.Color.White;
            this.label_responsavel.Location = new System.Drawing.Point(162, 226);
            this.label_responsavel.Name = "label_responsavel";
            this.label_responsavel.Size = new System.Drawing.Size(117, 20);
            this.label_responsavel.TabIndex = 16;
            this.label_responsavel.Text = "Responsável:";
            this.label_responsavel.Click += new System.EventHandler(this.Label1_Click_3);
            // 
            // textBox_responsavel
            // 
            this.textBox_responsavel.AcceptsTab = true;
            this.textBox_responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_responsavel.Location = new System.Drawing.Point(285, 226);
            this.textBox_responsavel.Name = "textBox_responsavel";
            this.textBox_responsavel.Size = new System.Drawing.Size(260, 26);
            this.textBox_responsavel.TabIndex = 17;
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefone.ForeColor = System.Drawing.Color.White;
            this.label_telefone.Location = new System.Drawing.Point(195, 289);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(84, 20);
            this.label_telefone.TabIndex = 18;
            this.label_telefone.Text = "Telefone:";
            this.label_telefone.Click += new System.EventHandler(this.Label_telefone_Click);
            // 
            // mascara_Telefone
            // 
            this.mascara_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascara_Telefone.Location = new System.Drawing.Point(285, 289);
            this.mascara_Telefone.Mask = "(99) 0000 - 0000";
            this.mascara_Telefone.Name = "mascara_Telefone";
            this.mascara_Telefone.Size = new System.Drawing.Size(138, 26);
            this.mascara_Telefone.TabIndex = 20;
            // 
            // mascara_cep
            // 
            this.mascara_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascara_cep.Location = new System.Drawing.Point(719, 36);
            this.mascara_cep.Mask = "00000-000";
            this.mascara_cep.Name = "mascara_cep";
            this.mascara_cep.Size = new System.Drawing.Size(140, 26);
            this.mascara_cep.TabIndex = 21;
            this.mascara_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // AdicionarEnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1056, 504);
            this.Controls.Add(this.mascara_cep);
            this.Controls.Add(this.mascara_Telefone);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.textBox_responsavel);
            this.Controls.Add(this.label_responsavel);
            this.Controls.Add(this.button_buscaCep);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.textBox_rua);
            this.Controls.Add(this.textBox_bairro);
            this.Controls.Add(this.textBox_cidade);
            this.Controls.Add(this.textBox_uf);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.label_rua);
            this.Controls.Add(this.label_bairro);
            this.Controls.Add(this.label_cidade);
            this.Controls.Add(this.label_uf);
            this.Controls.Add(this.label_cep);
            this.Controls.Add(this.btn_cancelarMatricula);
            this.Controls.Add(this.btn_salvarmatricula);
            this.Controls.Add(this.btn_adicionarfotoaluno);
            this.Controls.Add(this.pctb_foto);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.gb_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.dtBox_nascimento);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "AdicionarEnderecoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarAlunoForm";
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
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.PictureBox pctb_foto;
        private System.Windows.Forms.Button btn_salvarmatricula;
        private System.Windows.Forms.Button btn_cancelarMatricula;
        private System.Windows.Forms.Button btn_adicionarfotoaluno;
        private System.Windows.Forms.Label label_cep;
        private System.Windows.Forms.Label label_uf;
        private System.Windows.Forms.Label label_cidade;
        private System.Windows.Forms.Label label_bairro;
        private System.Windows.Forms.Label label_rua;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.TextBox textBox_uf;
        private System.Windows.Forms.TextBox textBox_cidade;
        private System.Windows.Forms.TextBox textBox_bairro;
        private System.Windows.Forms.TextBox textBox_rua;
        private System.Windows.Forms.Button button_buscaCep;
        private System.Windows.Forms.Label label_responsavel;
        private System.Windows.Forms.TextBox textBox_responsavel;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.MaskedTextBox mascara_Telefone;
        private System.Windows.Forms.MaskedTextBox mascara_cep;
        public System.Windows.Forms.TextBox textBox_numero;
    }
}
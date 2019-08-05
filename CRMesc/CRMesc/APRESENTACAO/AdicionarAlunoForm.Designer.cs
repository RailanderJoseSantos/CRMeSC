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
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
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
            this.txt_nome.AcceptsTab = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(156, 21);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(233, 26);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Text = "Morgana Aparecida da Silva";
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
            this.dtBox_nascimento.Value = new System.DateTime(2019, 8, 1, 0, 0, 0, 0);
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
            this.txt_telefone.Text = "(31)988604909";
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
            this.lbl_foto.Location = new System.Drawing.Point(54, 258);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(96, 20);
            this.lbl_foto.TabIndex = 10;
            this.lbl_foto.Text = "Foto (3x4):";
            // 
            // pctb_foto
            // 
            this.pctb_foto.BackColor = System.Drawing.Color.White;
            this.pctb_foto.Location = new System.Drawing.Point(156, 251);
            this.pctb_foto.Name = "pctb_foto";
            this.pctb_foto.Size = new System.Drawing.Size(116, 100);
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
            this.btn_adicionarfotoaluno.Location = new System.Drawing.Point(156, 359);
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
            // txt_cep
            // 
            this.txt_cep.AcceptsTab = true;
            this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(479, 21);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(233, 26);
            this.txt_cep.TabIndex = 17;
            this.txt_cep.Text = "35000000";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.ForeColor = System.Drawing.Color.White;
            this.lbl_cep.Location = new System.Drawing.Point(427, 21);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(46, 20);
            this.lbl_cep.TabIndex = 16;
            this.lbl_cep.Text = "Cep:";
            // 
            // txt_rua
            // 
            this.txt_rua.AcceptsTab = true;
            this.txt_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(479, 68);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(233, 26);
            this.txt_rua.TabIndex = 19;
            this.txt_rua.Text = "Taquara";
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.ForeColor = System.Drawing.Color.White;
            this.lbl_rua.Location = new System.Drawing.Point(427, 68);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(47, 20);
            this.lbl_rua.TabIndex = 18;
            this.lbl_rua.Text = "Rua:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.AcceptsTab = true;
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(479, 175);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(233, 26);
            this.txt_bairro.TabIndex = 21;
            this.txt_bairro.Text = "Fazenda Lagoa";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.ForeColor = System.Drawing.Color.White;
            this.lbl_bairro.Location = new System.Drawing.Point(412, 178);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(62, 20);
            this.lbl_bairro.TabIndex = 20;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.AcceptsTab = true;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(478, 228);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(233, 26);
            this.txt_cidade.TabIndex = 23;
            this.txt_cidade.Text = "Dores de Guanhães";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.ForeColor = System.Drawing.Color.White;
            this.lbl_cidade.Location = new System.Drawing.Point(402, 231);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(70, 20);
            this.lbl_cidade.TabIndex = 22;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_estado
            // 
            this.txt_estado.AcceptsTab = true;
            this.txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.Location = new System.Drawing.Point(478, 282);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(233, 26);
            this.txt_estado.TabIndex = 25;
            this.txt_estado.Text = "MG";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(402, 285);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(71, 20);
            this.lbl_estado.TabIndex = 24;
            this.lbl_estado.Text = "Estado:";
            // 
            // txt_numero
            // 
            this.txt_numero.AcceptsTab = true;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(479, 119);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(233, 26);
            this.txt_numero.TabIndex = 27;
            this.txt_numero.Text = "10";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.ForeColor = System.Drawing.Color.White;
            this.lbl_numero.Location = new System.Drawing.Point(403, 122);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(76, 20);
            this.lbl_numero.TabIndex = 26;
            this.lbl_numero.Text = "Número:";
            // 
            // AdicionarAlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(794, 504);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_cep);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.PictureBox pctb_foto;
        private System.Windows.Forms.Button btn_salvarmatricula;
        private System.Windows.Forms.Button btn_cancelarMatricula;
        private System.Windows.Forms.Button btn_adicionarfotoaluno;
      
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_numero;
    }
}
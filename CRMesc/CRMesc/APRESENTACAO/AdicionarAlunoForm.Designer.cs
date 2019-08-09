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
            this.lbl_foto = new System.Windows.Forms.Label();
            this.pctb_foto = new System.Windows.Forms.PictureBox();
            this.btn_adicionarfotoaluno = new System.Windows.Forms.Button();
            this.btn_salvarmatricula = new System.Windows.Forms.Button();
            this.btn_cancelarMatricula = new System.Windows.Forms.Button();
            this.label_CadastraEndereco = new System.Windows.Forms.Label();
            this.button_buscaEndereco = new System.Windows.Forms.Button();
            this.button_Anexar = new System.Windows.Forms.Button();
            this.textBoxidEndereco = new System.Windows.Forms.TextBox();
            this.labeL_idEndereco = new System.Windows.Forms.Label();
            this.textBox_IdResponsavel = new System.Windows.Forms.TextBox();
            this.label_reponsavelAluno = new System.Windows.Forms.Label();
            this.label_idResponsavel = new System.Windows.Forms.Label();
            this.button_cadastraResponsavel = new System.Windows.Forms.Button();
            this.button_vincularIdResponsavel = new System.Windows.Forms.Button();
            this.buttonVinculaIdTel = new System.Windows.Forms.Button();
            this.label_idTelefone = new System.Windows.Forms.Label();
            this.button_telefone = new System.Windows.Forms.Button();
            this.textBox_idtelefone = new System.Windows.Forms.TextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.gb_genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(157, 61);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(138, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome completo:";
            // 
            // txt_nome
            // 
            this.txt_nome.AcceptsTab = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(301, 58);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(260, 26);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Text = "Morgana Aparecida da Silva";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.ForeColor = System.Drawing.Color.White;
            this.lbl_nascimento.Location = new System.Drawing.Point(196, 114);
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
            this.dtBox_nascimento.Location = new System.Drawing.Point(301, 114);
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
            this.lbl_genero.Location = new System.Drawing.Point(221, 186);
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
            this.gb_genero.Location = new System.Drawing.Point(301, 166);
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
            this.pctb_foto.Location = new System.Drawing.Point(16, 32);
            this.pctb_foto.Name = "pctb_foto";
            this.pctb_foto.Size = new System.Drawing.Size(116, 126);
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
            // label_CadastraEndereco
            // 
            this.label_CadastraEndereco.AutoSize = true;
            this.label_CadastraEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CadastraEndereco.ForeColor = System.Drawing.Color.White;
            this.label_CadastraEndereco.Location = new System.Drawing.Point(196, 253);
            this.label_CadastraEndereco.Name = "label_CadastraEndereco";
            this.label_CadastraEndereco.Size = new System.Drawing.Size(91, 20);
            this.label_CadastraEndereco.TabIndex = 16;
            this.label_CadastraEndereco.Text = "Endereco:";
            this.label_CadastraEndereco.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // button_buscaEndereco
            // 
            this.button_buscaEndereco.BackColor = System.Drawing.Color.DarkGray;
            this.button_buscaEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscaEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscaEndereco.ForeColor = System.Drawing.Color.White;
            this.button_buscaEndereco.Location = new System.Drawing.Point(301, 243);
            this.button_buscaEndereco.Name = "button_buscaEndereco";
            this.button_buscaEndereco.Size = new System.Drawing.Size(77, 30);
            this.button_buscaEndereco.TabIndex = 17;
            this.button_buscaEndereco.Text = "Cadastrar";
            this.button_buscaEndereco.UseVisualStyleBackColor = false;
            // 
            // button_Anexar
            // 
            this.button_Anexar.BackColor = System.Drawing.Color.Green;
            this.button_Anexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Anexar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Anexar.ForeColor = System.Drawing.Color.White;
            this.button_Anexar.Location = new System.Drawing.Point(481, 243);
            this.button_Anexar.Name = "button_Anexar";
            this.button_Anexar.Size = new System.Drawing.Size(80, 30);
            this.button_Anexar.TabIndex = 18;
            this.button_Anexar.TabStop = false;
            this.button_Anexar.Text = "Vincular";
            this.button_Anexar.UseVisualStyleBackColor = false;
            this.button_Anexar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxidEndereco
            // 
            this.textBoxidEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxidEndereco.Location = new System.Drawing.Point(420, 245);
            this.textBoxidEndereco.Name = "textBoxidEndereco";
            this.textBoxidEndereco.Size = new System.Drawing.Size(55, 26);
            this.textBoxidEndereco.TabIndex = 19;
            // 
            // labeL_idEndereco
            // 
            this.labeL_idEndereco.AutoSize = true;
            this.labeL_idEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeL_idEndereco.ForeColor = System.Drawing.Color.White;
            this.labeL_idEndereco.Location = new System.Drawing.Point(384, 253);
            this.labeL_idEndereco.Name = "labeL_idEndereco";
            this.labeL_idEndereco.Size = new System.Drawing.Size(30, 20);
            this.labeL_idEndereco.TabIndex = 20;
            this.labeL_idEndereco.Text = "Id:";
            // 
            // textBox_IdResponsavel
            // 
            this.textBox_IdResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IdResponsavel.Location = new System.Drawing.Point(420, 305);
            this.textBox_IdResponsavel.Name = "textBox_IdResponsavel";
            this.textBox_IdResponsavel.Size = new System.Drawing.Size(55, 26);
            this.textBox_IdResponsavel.TabIndex = 22;
            // 
            // label_reponsavelAluno
            // 
            this.label_reponsavelAluno.AutoSize = true;
            this.label_reponsavelAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reponsavelAluno.ForeColor = System.Drawing.Color.White;
            this.label_reponsavelAluno.Location = new System.Drawing.Point(180, 311);
            this.label_reponsavelAluno.Name = "label_reponsavelAluno";
            this.label_reponsavelAluno.Size = new System.Drawing.Size(107, 20);
            this.label_reponsavelAluno.TabIndex = 21;
            this.label_reponsavelAluno.Text = "Resposável:";
            // 
            // label_idResponsavel
            // 
            this.label_idResponsavel.AutoSize = true;
            this.label_idResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idResponsavel.ForeColor = System.Drawing.Color.White;
            this.label_idResponsavel.Location = new System.Drawing.Point(384, 311);
            this.label_idResponsavel.Name = "label_idResponsavel";
            this.label_idResponsavel.Size = new System.Drawing.Size(30, 20);
            this.label_idResponsavel.TabIndex = 24;
            this.label_idResponsavel.Text = "Id:";
            // 
            // button_cadastraResponsavel
            // 
            this.button_cadastraResponsavel.BackColor = System.Drawing.Color.DarkGray;
            this.button_cadastraResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastraResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastraResponsavel.ForeColor = System.Drawing.Color.White;
            this.button_cadastraResponsavel.Location = new System.Drawing.Point(301, 301);
            this.button_cadastraResponsavel.Name = "button_cadastraResponsavel";
            this.button_cadastraResponsavel.Size = new System.Drawing.Size(77, 30);
            this.button_cadastraResponsavel.TabIndex = 23;
            this.button_cadastraResponsavel.Text = "Cadastrar";
            this.button_cadastraResponsavel.UseVisualStyleBackColor = false;
            // 
            // button_vincularIdResponsavel
            // 
            this.button_vincularIdResponsavel.BackColor = System.Drawing.Color.Green;
            this.button_vincularIdResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vincularIdResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vincularIdResponsavel.ForeColor = System.Drawing.Color.White;
            this.button_vincularIdResponsavel.Location = new System.Drawing.Point(481, 303);
            this.button_vincularIdResponsavel.Name = "button_vincularIdResponsavel";
            this.button_vincularIdResponsavel.Size = new System.Drawing.Size(80, 30);
            this.button_vincularIdResponsavel.TabIndex = 25;
            this.button_vincularIdResponsavel.TabStop = false;
            this.button_vincularIdResponsavel.Text = "Vincular";
            this.button_vincularIdResponsavel.UseVisualStyleBackColor = false;
            // 
            // buttonVinculaIdTel
            // 
            this.buttonVinculaIdTel.BackColor = System.Drawing.Color.Green;
            this.buttonVinculaIdTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVinculaIdTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinculaIdTel.ForeColor = System.Drawing.Color.White;
            this.buttonVinculaIdTel.Location = new System.Drawing.Point(481, 360);
            this.buttonVinculaIdTel.Name = "buttonVinculaIdTel";
            this.buttonVinculaIdTel.Size = new System.Drawing.Size(80, 30);
            this.buttonVinculaIdTel.TabIndex = 30;
            this.buttonVinculaIdTel.TabStop = false;
            this.buttonVinculaIdTel.Text = "Vincular";
            this.buttonVinculaIdTel.UseVisualStyleBackColor = false;
            this.buttonVinculaIdTel.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label_idTelefone
            // 
            this.label_idTelefone.AutoSize = true;
            this.label_idTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idTelefone.ForeColor = System.Drawing.Color.White;
            this.label_idTelefone.Location = new System.Drawing.Point(384, 368);
            this.label_idTelefone.Name = "label_idTelefone";
            this.label_idTelefone.Size = new System.Drawing.Size(30, 20);
            this.label_idTelefone.TabIndex = 29;
            this.label_idTelefone.Text = "Id:";
            this.label_idTelefone.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // button_telefone
            // 
            this.button_telefone.BackColor = System.Drawing.Color.DarkGray;
            this.button_telefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_telefone.ForeColor = System.Drawing.Color.White;
            this.button_telefone.Location = new System.Drawing.Point(301, 358);
            this.button_telefone.Name = "button_telefone";
            this.button_telefone.Size = new System.Drawing.Size(77, 30);
            this.button_telefone.TabIndex = 28;
            this.button_telefone.Text = "Telefone";
            this.button_telefone.UseVisualStyleBackColor = false;
            this.button_telefone.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // textBox_idtelefone
            // 
            this.textBox_idtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idtelefone.Location = new System.Drawing.Point(420, 362);
            this.textBox_idtelefone.Name = "textBox_idtelefone";
            this.textBox_idtelefone.Size = new System.Drawing.Size(55, 26);
            this.textBox_idtelefone.TabIndex = 27;
            this.textBox_idtelefone.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_2);
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefone.ForeColor = System.Drawing.Color.White;
            this.label_telefone.Location = new System.Drawing.Point(196, 365);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(84, 20);
            this.label_telefone.TabIndex = 26;
            this.label_telefone.Text = "Telefone:";
            this.label_telefone.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // AdicionarAlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(826, 504);
            this.Controls.Add(this.buttonVinculaIdTel);
            this.Controls.Add(this.label_idTelefone);
            this.Controls.Add(this.button_telefone);
            this.Controls.Add(this.textBox_idtelefone);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.button_vincularIdResponsavel);
            this.Controls.Add(this.label_idResponsavel);
            this.Controls.Add(this.button_cadastraResponsavel);
            this.Controls.Add(this.textBox_IdResponsavel);
            this.Controls.Add(this.label_reponsavelAluno);
            this.Controls.Add(this.labeL_idEndereco);
            this.Controls.Add(this.textBoxidEndereco);
            this.Controls.Add(this.button_Anexar);
            this.Controls.Add(this.button_buscaEndereco);
            this.Controls.Add(this.label_CadastraEndereco);
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
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.PictureBox pctb_foto;
        private System.Windows.Forms.Button btn_salvarmatricula;
        private System.Windows.Forms.Button btn_cancelarMatricula;
        private System.Windows.Forms.Button btn_adicionarfotoaluno;
        private System.Windows.Forms.Label label_CadastraEndereco;
        private System.Windows.Forms.Button button_buscaEndereco;
        private System.Windows.Forms.Button button_Anexar;
        private System.Windows.Forms.TextBox textBoxidEndereco;
        private System.Windows.Forms.Label labeL_idEndereco;
        private System.Windows.Forms.TextBox textBox_IdResponsavel;
        private System.Windows.Forms.Label label_reponsavelAluno;
        private System.Windows.Forms.Label label_idResponsavel;
        private System.Windows.Forms.Button button_cadastraResponsavel;
        private System.Windows.Forms.Button button_vincularIdResponsavel;
        private System.Windows.Forms.Button buttonVinculaIdTel;
        private System.Windows.Forms.Label label_idTelefone;
        private System.Windows.Forms.Button button_telefone;
        private System.Windows.Forms.TextBox textBox_idtelefone;
        private System.Windows.Forms.Label label_telefone;
    }
}
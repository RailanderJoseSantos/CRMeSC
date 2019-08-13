namespace CRMesc
{
    partial class Atualiza_Deleta_AlunoForm
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
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.gb_genero = new System.Windows.Forms.GroupBox();
            this.rd_btn_generoFem = new System.Windows.Forms.RadioButton();
            this.rd_btn_generoMasc = new System.Windows.Forms.RadioButton();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.dtBox_nascimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_idAluno = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.btn_adicionarfotoaluno = new System.Windows.Forms.Button();
            this.pctb_foto = new System.Windows.Forms.PictureBox();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_salvarmatricula = new System.Windows.Forms.Button();
            this.btn_procurarId = new System.Windows.Forms.Button();
            this.button_procuraResponsavel = new System.Windows.Forms.Button();
            this.textBox_idResponsavel = new System.Windows.Forms.TextBox();
            this.label_idResponsavel = new System.Windows.Forms.Label();
            this.textBox_nomeResponsavel = new System.Windows.Forms.TextBox();
            this.label_nomeResponsavel = new System.Windows.Forms.Label();
            this.button_buscaTelefone = new System.Windows.Forms.Button();
            this.textBox_idTelefone = new System.Windows.Forms.TextBox();
            this.label_idTelefone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_telefone
            // 
            this.txt_telefone.AcceptsTab = true;
            this.txt_telefone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_telefone.BackColor = System.Drawing.Color.White;
            this.txt_telefone.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(154, 157);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(233, 26);
            this.txt_telefone.TabIndex = 15;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.ForeColor = System.Drawing.Color.White;
            this.lbl_telefone.Location = new System.Drawing.Point(59, 157);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(75, 20);
            this.lbl_telefone.TabIndex = 14;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // gb_genero
            // 
            this.gb_genero.Controls.Add(this.rd_btn_generoFem);
            this.gb_genero.Controls.Add(this.rd_btn_generoMasc);
            this.gb_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_genero.ForeColor = System.Drawing.Color.White;
            this.gb_genero.Location = new System.Drawing.Point(154, 199);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Size = new System.Drawing.Size(233, 47);
            this.gb_genero.TabIndex = 13;
            this.gb_genero.TabStop = false;
            this.gb_genero.Text = "Sexo";
            // 
            // rd_btn_generoFem
            // 
            this.rd_btn_generoFem.AutoSize = true;
            this.rd_btn_generoFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_generoFem.Location = new System.Drawing.Point(108, 21);
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
            this.rd_btn_generoMasc.Location = new System.Drawing.Point(15, 21);
            this.rd_btn_generoMasc.Name = "rd_btn_generoMasc";
            this.rd_btn_generoMasc.Size = new System.Drawing.Size(87, 20);
            this.rd_btn_generoMasc.TabIndex = 0;
            this.rd_btn_generoMasc.TabStop = true;
            this.rd_btn_generoMasc.Text = "Masculino";
            this.rd_btn_generoMasc.UseVisualStyleBackColor = true;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.Color.White;
            this.lbl_genero.Location = new System.Drawing.Point(67, 213);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(67, 20);
            this.lbl_genero.TabIndex = 12;
            this.lbl_genero.Text = "Gênero:";
            // 
            // dtBox_nascimento
            // 
            this.dtBox_nascimento.Checked = false;
            this.dtBox_nascimento.CustomFormat = "dd/MM/yyyy";
            this.dtBox_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBox_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBox_nascimento.Location = new System.Drawing.Point(154, 106);
            this.dtBox_nascimento.Name = "dtBox_nascimento";
            this.dtBox_nascimento.Size = new System.Drawing.Size(233, 26);
            this.dtBox_nascimento.TabIndex = 11;
            this.dtBox_nascimento.Value = new System.DateTime(2011, 8, 1, 0, 0, 0, 0);
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.ForeColor = System.Drawing.Color.White;
            this.lbl_nascimento.Location = new System.Drawing.Point(45, 106);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(89, 20);
            this.lbl_nascimento.TabIndex = 10;
            this.lbl_nascimento.Text = "Nacimento:";
            // 
            // txt_nome
            // 
            this.txt_nome.AcceptsTab = true;
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(154, 62);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(233, 26);
            this.txt_nome.TabIndex = 9;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(10, 62);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(124, 20);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome completo:";
            // 
            // txt_idAluno
            // 
            this.txt_idAluno.AcceptsTab = true;
            this.txt_idAluno.BackColor = System.Drawing.Color.White;
            this.txt_idAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idAluno.Location = new System.Drawing.Point(154, 15);
            this.txt_idAluno.Name = "txt_idAluno";
            this.txt_idAluno.Size = new System.Drawing.Size(112, 26);
            this.txt_idAluno.TabIndex = 17;
            this.txt_idAluno.TextChanged += new System.EventHandler(this.Txt_idAluno_TextChanged_1);
            this.txt_idAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_idAluno_KeyPress);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(104, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 20);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "ID:";
            // 
            // txt_rua
            // 
            this.txt_rua.AcceptsTab = true;
            this.txt_rua.BackColor = System.Drawing.Color.White;
            this.txt_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(558, 170);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(233, 26);
            this.txt_rua.TabIndex = 21;
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.ForeColor = System.Drawing.Color.White;
            this.lbl_rua.Location = new System.Drawing.Point(509, 170);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(43, 20);
            this.lbl_rua.TabIndex = 20;
            this.lbl_rua.Text = "Rua:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.ForeColor = System.Drawing.Color.White;
            this.lbl_bairro.Location = new System.Drawing.Point(489, 222);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(55, 20);
            this.lbl_bairro.TabIndex = 18;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.AcceptsTab = true;
            this.txt_bairro.BackColor = System.Drawing.Color.White;
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(558, 219);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(233, 26);
            this.txt_bairro.TabIndex = 22;
            // 
            // txt_cidade
            // 
            this.txt_cidade.AcceptsTab = true;
            this.txt_cidade.BackColor = System.Drawing.Color.White;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(558, 266);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(233, 26);
            this.txt_cidade.TabIndex = 24;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.ForeColor = System.Drawing.Color.White;
            this.lbl_cidade.Location = new System.Drawing.Point(489, 269);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(63, 20);
            this.lbl_cidade.TabIndex = 23;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_estado
            // 
            this.txt_estado.AcceptsTab = true;
            this.txt_estado.BackColor = System.Drawing.Color.White;
            this.txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.Location = new System.Drawing.Point(558, 314);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(233, 26);
            this.txt_estado.TabIndex = 26;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(489, 317);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(64, 20);
            this.lbl_estado.TabIndex = 25;
            this.lbl_estado.Text = "Estado:";
            // 
            // txt_cep
            // 
            this.txt_cep.AcceptsTab = true;
            this.txt_cep.BackColor = System.Drawing.Color.White;
            this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(559, 370);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(233, 26);
            this.txt_cep.TabIndex = 28;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.ForeColor = System.Drawing.Color.White;
            this.lbl_cep.Location = new System.Drawing.Point(510, 376);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(42, 20);
            this.lbl_cep.TabIndex = 27;
            this.lbl_cep.Text = "Cep:";
            // 
            // txt_numero
            // 
            this.txt_numero.AcceptsTab = true;
            this.txt_numero.BackColor = System.Drawing.Color.White;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(558, 410);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(233, 26);
            this.txt_numero.TabIndex = 30;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.ForeColor = System.Drawing.Color.White;
            this.lbl_num.Location = new System.Drawing.Point(489, 413);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(69, 20);
            this.lbl_num.TabIndex = 29;
            this.lbl_num.Text = "Número:";
            // 
            // btn_adicionarfotoaluno
            // 
            this.btn_adicionarfotoaluno.BackColor = System.Drawing.Color.Green;
            this.btn_adicionarfotoaluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionarfotoaluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionarfotoaluno.ForeColor = System.Drawing.Color.White;
            this.btn_adicionarfotoaluno.Location = new System.Drawing.Point(63, 415);
            this.btn_adicionarfotoaluno.Name = "btn_adicionarfotoaluno";
            this.btn_adicionarfotoaluno.Size = new System.Drawing.Size(102, 28);
            this.btn_adicionarfotoaluno.TabIndex = 33;
            this.btn_adicionarfotoaluno.Text = "Inserir";
            this.btn_adicionarfotoaluno.UseVisualStyleBackColor = false;
            this.btn_adicionarfotoaluno.Click += new System.EventHandler(this.Btn_adicionarfotoaluno_Click);
            // 
            // pctb_foto
            // 
            this.pctb_foto.BackColor = System.Drawing.Color.White;
            this.pctb_foto.Location = new System.Drawing.Point(63, 314);
            this.pctb_foto.Name = "pctb_foto";
            this.pctb_foto.Size = new System.Drawing.Size(102, 93);
            this.pctb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctb_foto.TabIndex = 32;
            this.pctb_foto.TabStop = false;
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.ForeColor = System.Drawing.Color.White;
            this.lbl_foto.Location = new System.Drawing.Point(59, 281);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(96, 20);
            this.lbl_foto.TabIndex = 31;
            this.lbl_foto.Text = "Foto (3x4):";
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.Red;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.Color.White;
            this.btn_remover.Location = new System.Drawing.Point(154, 474);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(128, 40);
            this.btn_remover.TabIndex = 35;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // btn_salvarmatricula
            // 
            this.btn_salvarmatricula.BackColor = System.Drawing.Color.Green;
            this.btn_salvarmatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvarmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarmatricula.ForeColor = System.Drawing.Color.White;
            this.btn_salvarmatricula.Location = new System.Drawing.Point(468, 474);
            this.btn_salvarmatricula.Name = "btn_salvarmatricula";
            this.btn_salvarmatricula.Size = new System.Drawing.Size(128, 40);
            this.btn_salvarmatricula.TabIndex = 34;
            this.btn_salvarmatricula.Text = "Salvar";
            this.btn_salvarmatricula.UseVisualStyleBackColor = false;
            this.btn_salvarmatricula.Click += new System.EventHandler(this.Btn_salvarmatricula_Click);
            // 
            // btn_procurarId
            // 
            this.btn_procurarId.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_procurarId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procurarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurarId.ForeColor = System.Drawing.Color.White;
            this.btn_procurarId.Location = new System.Drawing.Point(272, 15);
            this.btn_procurarId.Name = "btn_procurarId";
            this.btn_procurarId.Size = new System.Drawing.Size(115, 26);
            this.btn_procurarId.TabIndex = 37;
            this.btn_procurarId.Text = "Procurar";
            this.btn_procurarId.UseVisualStyleBackColor = false;
            this.btn_procurarId.Click += new System.EventHandler(this.Btn_procurarId_Click);
            // 
            // button_procuraResponsavel
            // 
            this.button_procuraResponsavel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_procuraResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_procuraResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_procuraResponsavel.ForeColor = System.Drawing.Color.White;
            this.button_procuraResponsavel.Location = new System.Drawing.Point(675, 18);
            this.button_procuraResponsavel.Name = "button_procuraResponsavel";
            this.button_procuraResponsavel.Size = new System.Drawing.Size(115, 26);
            this.button_procuraResponsavel.TabIndex = 42;
            this.button_procuraResponsavel.Text = "Procurar";
            this.button_procuraResponsavel.UseVisualStyleBackColor = false;
            // 
            // textBox_idResponsavel
            // 
            this.textBox_idResponsavel.AcceptsTab = true;
            this.textBox_idResponsavel.BackColor = System.Drawing.Color.White;
            this.textBox_idResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idResponsavel.Location = new System.Drawing.Point(557, 18);
            this.textBox_idResponsavel.Name = "textBox_idResponsavel";
            this.textBox_idResponsavel.Size = new System.Drawing.Size(112, 26);
            this.textBox_idResponsavel.TabIndex = 41;
            // 
            // label_idResponsavel
            // 
            this.label_idResponsavel.AutoSize = true;
            this.label_idResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idResponsavel.ForeColor = System.Drawing.Color.White;
            this.label_idResponsavel.Location = new System.Drawing.Point(425, 21);
            this.label_idResponsavel.Name = "label_idResponsavel";
            this.label_idResponsavel.Size = new System.Drawing.Size(126, 20);
            this.label_idResponsavel.TabIndex = 40;
            this.label_idResponsavel.Text = "ID Responsavel:";
            // 
            // textBox_nomeResponsavel
            // 
            this.textBox_nomeResponsavel.AcceptsTab = true;
            this.textBox_nomeResponsavel.BackColor = System.Drawing.Color.White;
            this.textBox_nomeResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nomeResponsavel.Location = new System.Drawing.Point(557, 62);
            this.textBox_nomeResponsavel.Name = "textBox_nomeResponsavel";
            this.textBox_nomeResponsavel.Size = new System.Drawing.Size(233, 26);
            this.textBox_nomeResponsavel.TabIndex = 39;
            // 
            // label_nomeResponsavel
            // 
            this.label_nomeResponsavel.AutoSize = true;
            this.label_nomeResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeResponsavel.ForeColor = System.Drawing.Color.White;
            this.label_nomeResponsavel.Location = new System.Drawing.Point(403, 65);
            this.label_nomeResponsavel.Name = "label_nomeResponsavel";
            this.label_nomeResponsavel.Size = new System.Drawing.Size(151, 20);
            this.label_nomeResponsavel.TabIndex = 38;
            this.label_nomeResponsavel.Text = "Nome Responsavel:";
            // 
            // button_buscaTelefone
            // 
            this.button_buscaTelefone.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_buscaTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscaTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscaTelefone.ForeColor = System.Drawing.Color.White;
            this.button_buscaTelefone.Location = new System.Drawing.Point(676, 94);
            this.button_buscaTelefone.Name = "button_buscaTelefone";
            this.button_buscaTelefone.Size = new System.Drawing.Size(115, 26);
            this.button_buscaTelefone.TabIndex = 47;
            this.button_buscaTelefone.Text = "Procurar";
            this.button_buscaTelefone.UseVisualStyleBackColor = false;
            // 
            // textBox_idTelefone
            // 
            this.textBox_idTelefone.AcceptsTab = true;
            this.textBox_idTelefone.BackColor = System.Drawing.Color.White;
            this.textBox_idTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idTelefone.Location = new System.Drawing.Point(558, 94);
            this.textBox_idTelefone.Name = "textBox_idTelefone";
            this.textBox_idTelefone.Size = new System.Drawing.Size(112, 26);
            this.textBox_idTelefone.TabIndex = 46;
            // 
            // label_idTelefone
            // 
            this.label_idTelefone.AutoSize = true;
            this.label_idTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idTelefone.ForeColor = System.Drawing.Color.White;
            this.label_idTelefone.Location = new System.Drawing.Point(426, 97);
            this.label_idTelefone.Name = "label_idTelefone";
            this.label_idTelefone.Size = new System.Drawing.Size(89, 20);
            this.label_idTelefone.TabIndex = 45;
            this.label_idTelefone.Text = "Id telefone:";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(558, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 26);
            this.textBox2.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(404, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome Responsavel:";
            // 
            // Atualiza_Deleta_AlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(816, 526);
            this.Controls.Add(this.button_buscaTelefone);
            this.Controls.Add(this.textBox_idTelefone);
            this.Controls.Add(this.label_idTelefone);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_procuraResponsavel);
            this.Controls.Add(this.textBox_idResponsavel);
            this.Controls.Add(this.label_idResponsavel);
            this.Controls.Add(this.textBox_nomeResponsavel);
            this.Controls.Add(this.label_nomeResponsavel);
            this.Controls.Add(this.btn_procurarId);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_salvarmatricula);
            this.Controls.Add(this.btn_adicionarfotoaluno);
            this.Controls.Add(this.pctb_foto);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_idAluno);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.gb_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.dtBox_nascimento);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Atualiza_Deleta_AlunoForm";
            this.Text = "Atualiza_Deleta_Aluno";
            this.Load += new System.EventHandler(this.Atualiza_Deleta_Aluno_Load);
            this.gb_genero.ResumeLayout(false);
            this.gb_genero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.GroupBox gb_genero;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Button btn_adicionarfotoaluno;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_salvarmatricula;
        private System.Windows.Forms.Button btn_procurarId;
        internal System.Windows.Forms.TextBox txt_telefone;
        internal System.Windows.Forms.RadioButton rd_btn_generoMasc;
        internal System.Windows.Forms.PictureBox pctb_foto;
        internal System.Windows.Forms.RadioButton rd_btn_generoFem;
        internal System.Windows.Forms.DateTimePicker dtBox_nascimento;
        internal System.Windows.Forms.TextBox txt_nome;
        internal System.Windows.Forms.TextBox txt_rua;
        internal System.Windows.Forms.TextBox txt_bairro;
        internal System.Windows.Forms.TextBox txt_cidade;
        internal System.Windows.Forms.TextBox txt_estado;
        internal System.Windows.Forms.TextBox txt_cep;
        internal System.Windows.Forms.TextBox txt_numero;
        internal System.Windows.Forms.TextBox txt_idAluno;
        private System.Windows.Forms.Button button_procuraResponsavel;
        internal System.Windows.Forms.TextBox textBox_idResponsavel;
        private System.Windows.Forms.Label label_idResponsavel;
        internal System.Windows.Forms.TextBox textBox_nomeResponsavel;
        private System.Windows.Forms.Label label_nomeResponsavel;
        private System.Windows.Forms.Button button_buscaTelefone;
        internal System.Windows.Forms.TextBox textBox_idTelefone;
        private System.Windows.Forms.Label label_idTelefone;
        internal System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
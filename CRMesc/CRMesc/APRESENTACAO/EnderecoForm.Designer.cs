namespace CRMesc
{
    partial class EnderecoForm
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
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cep
            // 
            this.lbl_cep.BackColor = System.Drawing.Color.Gray;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.ForeColor = System.Drawing.Color.White;
            this.lbl_cep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_cep.Location = new System.Drawing.Point(36, 20);
            this.lbl_cep.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(53, 23);
            this.lbl_cep.TabIndex = 0;
            this.lbl_cep.Text = "Cep:";
            // 
            // txt_cep
            // 
            this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(107, 17);
            this.txt_cep.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(366, 26);
            this.txt_cep.TabIndex = 1;
            this.txt_cep.Text = "35-000-000";
            this.txt_cep.TextChanged += new System.EventHandler(this.Txt_cep_TextChanged);
            // 
            // txt_cidade
            // 
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(107, 53);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(366, 26);
            this.txt_cidade.TabIndex = 3;
            this.txt_cidade.Text = "Dores de Guanhães";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.BackColor = System.Drawing.Color.Gray;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.ForeColor = System.Drawing.Color.White;
            this.lbl_cidade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_cidade.Location = new System.Drawing.Point(8, 53);
            this.lbl_cidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(81, 26);
            this.lbl_cidade.TabIndex = 2;
            this.lbl_cidade.Text = "Cidade:";
            this.lbl_cidade.Click += new System.EventHandler(this.Lbl_cidade_Click);
            // 
            // txt_bairro
            // 
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(107, 89);
            this.txt_bairro.Margin = new System.Windows.Forms.Padding(5);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(366, 26);
            this.txt_bairro.TabIndex = 5;
            this.txt_bairro.Text = "Fazenda Lagoa";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.BackColor = System.Drawing.Color.Gray;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.ForeColor = System.Drawing.Color.White;
            this.lbl_bairro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_bairro.Location = new System.Drawing.Point(14, 89);
            this.lbl_bairro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(75, 26);
            this.lbl_bairro.TabIndex = 4;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(107, 161);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(5);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(366, 26);
            this.txt_numero.TabIndex = 7;
            this.txt_numero.Text = "115";
            // 
            // lbl_numero
            // 
            this.lbl_numero.BackColor = System.Drawing.Color.Gray;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.ForeColor = System.Drawing.Color.White;
            this.lbl_numero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_numero.Location = new System.Drawing.Point(6, 161);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(81, 26);
            this.lbl_numero.TabIndex = 6;
            this.lbl_numero.Text = "Número:";
            // 
            // txt_uf
            // 
            this.txt_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uf.Location = new System.Drawing.Point(107, 197);
            this.txt_uf.Margin = new System.Windows.Forms.Padding(5);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(366, 26);
            this.txt_uf.TabIndex = 9;
            this.txt_uf.Text = "MG";
            // 
            // lbl_uf
            // 
            this.lbl_uf.BackColor = System.Drawing.Color.Gray;
            this.lbl_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uf.ForeColor = System.Drawing.Color.White;
            this.lbl_uf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_uf.Location = new System.Drawing.Point(14, 205);
            this.lbl_uf.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(75, 27);
            this.lbl_uf.TabIndex = 8;
            this.lbl_uf.Text = "Estado:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(107, 403);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 45);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(345, 403);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(128, 45);
            this.btn_salvar.TabIndex = 11;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // txt_rua
            // 
            this.txt_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(107, 125);
            this.txt_rua.Margin = new System.Windows.Forms.Padding(5);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(366, 26);
            this.txt_rua.TabIndex = 13;
            this.txt_rua.Text = "Taquara";
            // 
            // lbl_rua
            // 
            this.lbl_rua.BackColor = System.Drawing.Color.Gray;
            this.lbl_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.ForeColor = System.Drawing.Color.White;
            this.lbl_rua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_rua.Location = new System.Drawing.Point(24, 125);
            this.lbl_rua.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(47, 26);
            this.lbl_rua.TabIndex = 12;
            this.lbl_rua.Text = "Rua:";
            // 
            // EnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(556, 460);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.lbl_uf);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_cep);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EnderecoForm";
            this.Text = "EnderecoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}
using CRMesc.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRMesc
{
    public partial class AdicionarAlunoForm : Form
    {
        public String id;
        public bool btn_preencherIdClicado = false;
        public bool btn_anexarId_Clicado = false;
        public AdicionarAlunoForm()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarAlunoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_salvarmatricula_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            String nome = txt_nome.Text;
            DateTime nascimento = dtBox_nascimento.Value;
            String telefone = txt_telefone.Text;
            String genero = "Masculino";
            String cep = txt_cep.Text;
            String rua = txt_rua.Text;
            String bairro = txt_bairro.Text;
            int numero = int.Parse(txt_numero.Text);
            String cidade = txt_cidade.Text;
            String uf = txt_estado.Text;



            if (rd_btn_generoFem.Checked)
            {
                genero = "Feminino";
            }

            MemoryStream fot = new MemoryStream();

            // checando idade de aluno ( 5 a 100 anos)
            int ano_nasc = dtBox_nascimento.Value.Year;
            int ano_atual = DateTime.Now.Year;
            if (limitesCaracteresAceitos())
            {
                if ((ano_atual - ano_nasc) < 5 || (ano_atual - ano_nasc) > 100)
                {
                    MessageBox.Show("O aluno deve ter entre 5 e 100 anos", "Data de ascimento inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // adicionar aluno no banco
                if (verificaCampoVazio())
                {
                    pctb_foto.Image.Save(fot, pctb_foto.Image.RawFormat);
                    if (aluno.inserirAluno(nome, nascimento, telefone, genero, fot, cep, rua, bairro, numero, cidade, uf))
                    {
                        MessageBox.Show("Aluno cadastrado ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Endereco endereco = new Endereco();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // funcao para  verificar campo em branco
        bool limitesCaracteresAceitos()
        {
            if ((txt_nome.Text.Length > 50))
            {
                MessageBox.Show("Nome do aluno pode ter no máximo 50 caracteres ", "Cadatro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((txt_telefone.Text.Length) > 20)
            {
                MessageBox.Show("Telefone do aluno pode ter no máximo 20 digitos ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((txt_cep.Text.Length > 15))
            {
                MessageBox.Show("Cep do aluno pode ter no máximo 15 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((txt_rua.Text.Length > 50))
            {
                MessageBox.Show("Rua do aluno pode ter no máximo 50 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((txt_bairro.Text.Length > 50))
            {
                MessageBox.Show("Bairro do aluno pode ter no máximo 50 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((txt_estado.Text.Length > 2)) { 
                MessageBox.Show("Estado do aluno pode ter no máximo 2 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
           
        }
        // funcao para  verificar campo em branco
        bool verificaCampoVazio()
        {
            if ((txt_nome.Text.Trim() == "") ||
                (txt_telefone.Text.Trim() == "") ||
                (rd_btn_generoFem.Checked == false && rd_btn_generoMasc.Checked == false) ||
                (pctb_foto.Image == null) ||
                (txt_cep.Text.Trim() == "")|| 
                (txt_cidade.Text.Trim() == "") ||
                (txt_rua.Text.Trim() == "") ||
                (txt_numero.Text.Trim() == "") ||
                (txt_bairro.Text.Trim() == "") ||
                (txt_estado.Text.Trim() == "")
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Lbl_telefone_Click(object sender, EventArgs e)
        {

        }

        private void Btn_adicionarfotoaluno_Click(object sender, EventArgs e)
        {
            // buscador de imagens no pc
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Selecione a foto(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pctb_foto.Image = Image.FromFile(opf.FileName);
            }

        }

        private void Btn_cancelarMatricula_Click(object sender, EventArgs e)
        {
            //cancela matricula
            Close();
        }

        private void Pctb_foto_Click(object sender, EventArgs e)
        {

        }

        private void Txt_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_preencher_endereco_Click(object sender, EventArgs e)
        {
        }

        private void setBtn_preencherClicado(bool valor)
        {
            this.btn_preencherIdClicado = valor;
        }
        private bool getBtn_preencherIdClicado()
        {
            return this.btn_preencherIdClicado;
        }
        private void setBtn_anexarIdClicado(bool valor)
        {
            this.btn_anexarId_Clicado = valor;
        }
        private bool getBtn_anexarIdClicado()
        {
            return this.btn_anexarId_Clicado;
        }

    }

}

    



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
            String genero = "";
            int idEndereco = 0;
            //if(this.getBtn_preencherIdClicado())
               // idEndereco = int.Parse(txt_codEndAluno.ToString());
          

            if (rd_btn_generoMasc.Checked) {
                genero = "Masculino";
            }
            if (rd_btn_generoFem.Checked)
            {
                genero = "Feminino";
            }
            
            MemoryStream fot = new MemoryStream();

            // checando idade de aluno ( 5 a 100 anos)
            int ano_nasc = dtBox_nascimento.Value.Year;
            int ano_atual = DateTime.Now.Year;
            if ((ano_atual - ano_nasc) < 5 || (ano_atual - ano_nasc) > 100)
            {
                MessageBox.Show("O aluno deve ter entre 5 e 100 anos", "Data de ascimento inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // adicionar aluno no banco
            if (verificaCampoVazio())
            {
                pctb_foto.Image.Save(fot, pctb_foto.Image.RawFormat);
                if (aluno.inserirAluno(nome, nascimento, telefone,genero,idEndereco, fot) /*&& (!this.getBtn_anexarIdClicado())*/ )
                {
                  //  MessageBox.Show("Aluno cadastrado ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // Endereco endereco = new Endereco();
                }
            }
            else {
                MessageBox.Show("Preencha todos os campos ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        // funcao para  verificar campo em branco
        bool verificaCampoVazio()
        {
            if ( (txt_nome.Text.Trim() == "") ||
                (txt_telefone.Text.Trim() == "") ||
                (this.getBtn_preencherIdClicado() == false) ||
                (this.getBtn_anexarIdClicado() == false) ||
                (rd_btn_generoFem.Checked == false && rd_btn_generoMasc.Checked == false) ||
                (lbl_endereco.Text.Trim() == "") ||
                (pctb_foto.Image == null)
                )
            {
                return false;
            }
            else {
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
            if (this.getBtn_preencherIdClicado())
            {
                Endereco endereco = new Endereco();
                endereco.deletarEndereco(0, true);
            }
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
             this.setBtn_preencherClicado(true);
            EnderecoForm end = new EnderecoForm();
            //this.txt_codEndAluno.Text = this.id;
            EnderecoForm endereco = new EnderecoForm();
            endereco.Show();
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

        private void Txt_codEndAluno_TextChanged(object sender, EventArgs e)
        {
            //EnderecoForm end = new EnderecoForm();
            /*if (end.get_btn_salvaEnderecoClicado())
            {
                Banco bd = new Banco();
                SqlConnection conexao = new SqlConnection();
                SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM ENDERECO", bd.conectar());
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    this.txt_codEndAluno.Text = registro.GetValue(0).ToString();
                    //MessageBox.Show("id: " + registro.GetValue(0));

                }
            }
            else
            {
                MessageBox.Show("Preencha o campo endereço primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }
        public void setTxt_codEndAluno_TextChanged(int id)
        {
            this.txt_codEndAluno.Text = id.ToString();
        }

        private void btn_anexarId_Clicked(object sender, EventArgs e)
        {
            if (!this.getBtn_preencherIdClicado())
            {
                MessageBox.Show("Antes de associar endereço com aluno, você deve cadastrar o endereço antes! ","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                    this.setBtn_anexarIdClicado(true);
                    this.setBtn_anexarIdClicado(true);
                    EnderecoForm endereco = new EnderecoForm();
                    Banco bd = new Banco();
                    SqlConnection conexao = new SqlConnection();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM ENDERECO", bd.conectar());
                    SqlDataReader registro = cmd.ExecuteReader();
                    if (registro.Read())
                    {
                        this.txt_codEndAluno.Text = registro.GetValue(0).ToString();
                        //MessageBox.Show("id: " + registro.GetValue(0));

                    }else{
                         MessageBox.Show("Preencha o campo endereço primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                
            }
        }


        /*   private void btn_anexar_endereco_Click(object sender, EventArgs e)
           {
               if (this.setBtn_preencherClicado())
               {
                   this.setBtn_anexarIdClicado(true);
                   EnderecoForm endereco = new EnderecoForm();
                   Banco bd = new Banco();
                   SqlConnection conexao = new SqlConnection();
                   SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM ENDERECO", bd.conectar());
                   SqlDataReader registro = cmd.ExecuteReader();
                   if (registro.Read())
                   {
                       this.txt_codEndAluno.Text = registro.GetValue(0).ToString();
                       //MessageBox.Show("id: " + registro.GetValue(0));

                   }
               }
               else
               {
                   MessageBox.Show("Preencha o campo endereço primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }*/
    }
    }

    



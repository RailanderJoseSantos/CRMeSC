using CRMesc.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRMesc
{
    public partial class EnderecoForm : Form
    {

        private bool btn_salvaEnderecoClicado = false;
        public EnderecoForm()
        {
            InitializeComponent();
        }

        private void Lbl_cidade_Click(object sender, EventArgs e)
        {

        }

        private void Txt_cep_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            /*Esse salvar deve enviar dados coletados para o salvar de aluno */
            this.set_btn_salvaEnderecoClicado(true);
            String cep = txt_cep.Text;
            String rua = txt_rua.Text;
            String bairro = txt_bairro.Text;
            int  numero = int.Parse(txt_numero.Text);
            String cidade = txt_cidade.Text;
            String uf = txt_uf.Text;
            Endereco endereco = new Endereco();
   
            if (verificaCampoVazio())
            {
                  if (endereco.inserirEndereco(cep, rua, bairro, numero, cidade, uf))
                {
                    MessageBox.Show("Endereço inserido ", "Cadastro de endereço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preecheId();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Erro ", "Cadastro de endereço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        void preecheId()
        {
            AdicionarAlunoForm addaluno = new AdicionarAlunoForm();
            EnderecoForm end = new  EnderecoForm();
           // if (end.get_btn_salvaEnderecoClicado().)
         //   {
                Banco bd = new Banco();
                SqlConnection conexao = new SqlConnection();
                SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM ENDERECO", bd.conectar());
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    int id = int.Parse(registro.GetValue(0).ToString());
                    addaluno.setTxt_codEndAluno_TextChanged(id);
                    //MessageBox.Show("id: " + registro.GetValue(0));

                }
     /*       }
            else
            {
                MessageBox.Show("Preencha o campo endereço primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        

        bool verificaCampoVazio()
        {
            if ((txt_cep.Text.Trim() == "") ||
                (txt_cidade.Text.Trim() == "") ||
                (txt_rua.Text.Trim() == "") ||
                (txt_numero.Text.Trim() == "") ||
                (txt_bairro.Text.Trim() == "") ||
                (txt_uf.Text.Trim() == "")
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal bool get_btn_salvaEnderecoClicado()
        {
            return this.btn_salvaEnderecoClicado;
        }
        internal void set_btn_salvaEnderecoClicado(bool val)
        {
             this.btn_salvaEnderecoClicado = val;
        }
    }
}

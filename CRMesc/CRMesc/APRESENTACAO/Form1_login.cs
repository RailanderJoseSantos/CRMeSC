using CRMesc.APRESENTACAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRMesc
{
    public partial class Form1_login : Form
    {
        public Form1_login()
        {
            InitializeComponent();
        }

        private void Form1_login_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("../../imagens/avatar_red.png");
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_logar_Click(object sender, EventArgs e)
        {
            LoginControle controle = new LoginControle();
            controle.verificarLogin(txt_usuario.Text, txt_senha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    /*MessageBox.Show("Logado com sucesso",
                        "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    //instanciar e abrir formulario de acesso*/
                    MainForm principalJanela = new MainForm();
                    principalJanela.Show(); 
                }
                else
                {
                    MessageBox.Show("Cadastro não encontrado, verifique usuário e/ou senha",
                        "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
           
        }

        private void Txt_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

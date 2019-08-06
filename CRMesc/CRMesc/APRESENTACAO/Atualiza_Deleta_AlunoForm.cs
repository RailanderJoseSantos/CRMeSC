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
    public partial class Atualiza_Deleta_AlunoForm : Form
    {
        public Atualiza_Deleta_AlunoForm()
        {
            InitializeComponent();
        }

        private void Atualiza_Deleta_Aluno_Load(object sender, EventArgs e)
        {

        }

        private void Btn_salvarmatricula_Click(object sender, EventArgs e)
        {
            // salvando atualização do aluno
            Aluno aluno = new Aluno();
            int idAluno = Convert.ToInt32(txt_idAluno.Text);
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
                    if (aluno.atualizarAluno(idAluno, nome, nascimento, telefone, genero, fot, cep, rua, bairro, numero, cidade, uf))
                    {
                        MessageBox.Show("Matrícula atualizada ", "Atualização de matrícula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ", "Atualização de aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Endereco endereco = new Endereco();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos ", "Atualização de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


       /* private void Button2_Click(object sender, EventArgs e)
        {

        }*/

        private void Txt_ptocurar_Click(object sender, EventArgs e)
        {
     
        }

        private void Btn_adicionarfotoaluno_Click(object sender, EventArgs e)
        {
            // buscador de imagens no pc
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Selecione a foto(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pctb_foto.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Txt_idAluno_TextChanged(object sender, EventArgs e)
        {

        }

        bool verificaCampoVazio()
        {
            if ((txt_nome.Text.Trim() == "") ||
                (txt_telefone.Text.Trim() == "") ||
                (rd_btn_generoFem.Checked == false && rd_btn_generoMasc.Checked == false) ||
                (pctb_foto.Image == null) ||
                (txt_cep.Text.Trim() == "") ||
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
            else if ((txt_estado.Text.Length > 2))
            {
                MessageBox.Show("Estado do aluno pode ter no máximo 2 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            // deletar aluno
            Aluno aluno = new Aluno();
            if (MessageBox.Show("Você realmente deseja deletar a matrícula do aluno? ", "Deletar aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idAluno = Convert.ToInt32(txt_idAluno.Text);
                if (aluno.deletarAluno(idAluno))
                {
                    MessageBox.Show("Matrícula excluída", "Excluir matricula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpa textbox
                    txt_idAluno.Clear();
                    txt_nome.Clear();
                    txt_telefone.Clear();
                    dtBox_nascimento.Value = DateTime.Now;
                    pctb_foto.Image = null;
                    txt_cep.Clear();
                    txt_rua.Clear();
                    txt_bairro.Clear();
                    txt_numero.Clear();
                    txt_cidade.Clear();
                    txt_estado.Clear();
                }
                else
                {
                    MessageBox.Show("Matrícula não excluída", "Excluir matricula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // aceitar somente numeros na caixa de texto
        private void Txt_idAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )//verifica se é qlq coisa diferente de nmrs
            {

            }
        }

        private void Btn_procurarId_Click(object sender, EventArgs e)
        {

            Aluno aluno = new Aluno();
            //buscar  Aluno por id
            int idAluno = Convert.ToInt32(txt_idAluno.Text);
            SqlCommand cmd = new SqlCommand("SELECT ID, NOME, NASCIMENTO, GENERO, TELEFONE, FOTO, CEP, RUA, BAIRRO, NUMERO, CIDADE, UF FROM ALUNO WHERE ID = " + idAluno);
            DataTable tabela = aluno.getAlunos(cmd);
            if (tabela.Rows.Count > 0)
            {
                txt_idAluno.Text = tabela.Rows[0]["Id"].ToString();
                txt_nome.Text = tabela.Rows[0]["Nome"].ToString();
                dtBox_nascimento.Value = (DateTime)tabela.Rows[0]["Nascimento"];
                if (tabela.Rows[0]["Genero"].ToString() == "Feminino")
                {
                    rd_btn_generoFem.Checked = true;
                }
                else
                {
                    rd_btn_generoMasc.Checked = true;
                }
                txt_telefone.Text = tabela.Rows[0]["Telefone"].ToString();

                byte[] foto = (byte[])tabela.Rows[0]["Foto"];
                MemoryStream imagem = new MemoryStream(foto);
                pctb_foto.Image = Image.FromStream(imagem);

                txt_cep.Text = tabela.Rows[0]["Cep"].ToString();
                txt_rua.Text = tabela.Rows[0]["Rua"].ToString();
                txt_bairro.Text = tabela.Rows[0]["Bairro"].ToString();
                txt_numero.Text = tabela.Rows[0]["Numero"].ToString();
                txt_cidade.Text = tabela.Rows[0]["Cidade"].ToString();
                txt_estado.Text = tabela.Rows[0]["UF"].ToString();
            }
            else
            {
                MessageBox.Show("O ID informado não existe no banco", "Erro ao Deletar aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_idAluno_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}


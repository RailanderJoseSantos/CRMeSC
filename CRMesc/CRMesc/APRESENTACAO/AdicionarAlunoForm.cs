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
    public partial class AdicionarEnderecoForm : Form
    {
   
        public bool btn_preencherIdClicado = false;
        public bool btn_anexarId_Clicado = false;

        public AdicionarEnderecoForm()
        {
            InitializeComponent();
        }

        private void Btn_salvarmatricula_Click(object sender, EventArgs e)
        {

            Endereco en = new Endereco();
            Aluno aluno = new Aluno();
            Responsavel resp = new Responsavel();
            Telefone tel = new Telefone();

            String responsavel = textBox_responsavel.Text;
            String telefone = mascara_Telefone.Text;


            String cep = mascara_cep.Text;
            String rua = textBox_rua.Text;
            String bairro = textBox_bairro.Text;
            int numero = 0;
            if (textBox_numero.Text.Trim() != "")
            {
                numero = Convert.ToInt32(textBox_numero.Text);
            }
            String cidade = textBox_cidade.Text;
            String uf = textBox_uf.Text;

            String nome = txt_nome.Text;
            DateTime nascimento = dtBox_nascimento.Value;
            // String telefone = txt_telefone.Text;
            String genero = "M";

            if (rd_btn_generoFem.Checked)
            {
                genero = "F";
            }

            MemoryStream fot = new MemoryStream();

            int countSucesso = 0;
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
                    if ((aluno.inserirAluno(nome, nascimento, genero, fot)))
                    {
                        countSucesso += 1;
                        int idAluno = Convert.ToInt32(aluno.getIdAluno());
                        if (resp.inserirResponsavel(responsavel, idAluno))
                        {
                            countSucesso += 1;
                            int idResponsavel = Convert.ToInt32(resp.GetIdResponsavel());
                            if ((en.inserirEndereco(cep, rua, bairro, numero, cidade, uf)))
                            {
                                countSucesso += 1;
                                int idEndereco = Convert.ToInt32(en.getIdEndereco());
                                Endereco endereco = new Endereco();
                                if (endereco.AssociaEnderResponsavel(idResponsavel, idEndereco))
                                {
                                    countSucesso += 1;
                                    int idTelefone = Convert.ToInt32(tel.GetIdTelefone());
                                    if (tel.inserirTelefone(telefone))
                                    {
                                        countSucesso += 1;
                                        if (tel.AssociaTelefoneResponsavel(idResponsavel, idTelefone))
                                        {
                                            countSucesso += 1;
                                            if (countSucesso == 6)
                                            {
                                                MessageBox.Show("Aluno cadastrado ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                limpaCampos();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Erro ao associar telefone ao responsavel", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erro ao cadastrar telefone do responsavel", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao associar endereco ao responsavel", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erro ao inserir endereco do responsavel", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir responsavel ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Endereco endereco = new Endereco();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao associar telefone ao responsavel", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if ((mascara_Telefone.Text.Length) > 20)
            {
                MessageBox.Show("Telefone  pode ter no máximo 20 digitos ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if( textBox_responsavel.Text.Length > 50)
            {
                MessageBox.Show("Nome do pai/responsável  pode ter no máximo 50 letras ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((mascara_cep.Text.Length > 15))
            {
                MessageBox.Show("Cep  pode ter no máximo 15 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((textBox_rua.Text.Length > 50))
            {
                MessageBox.Show("Rua do aluno pode ter no máximo 50 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((textBox_bairro.Text.Length > 50))
            {
                MessageBox.Show("Bairro do aluno pode ter no máximo 50 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((textBox_uf.Text.Length > 2))
            {
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
 //               (txt_telefone.Text.Trim() == "") ||
                (rd_btn_generoFem.Checked == false && rd_btn_generoMasc.Checked == false) ||
                (pctb_foto.Image == null) ||
                (mascara_cep.Text.Trim() == "")|| 
                (textBox_cidade.Text.Trim() == "") ||
                (textBox_rua.Text.Trim() == "") ||
                (textBox_numero.Text == "") ||
                (textBox_bairro.Text.Trim() == "") ||
                (textBox_uf.Text.Trim() == "") ||
                (textBox_responsavel.Text.Trim() == "")
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Selecione a foto(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif"
            };
            OpenFileDialog opf = openFileDialog;
            if (opf.ShowDialog() == DialogResult.OK)
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Button_buscaEndereco_Click(object sender, EventArgs e)
        {

 
            
        }

        private void TextBoxidEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Anexar_MouseClick(object sender, MouseEventArgs e)
        {
            //AdicionaEnderecoForm endereco = new AdicionaEnderecoForm();
            //textBoxidEndereco.Text = Convert.ToString( endereco.idEndereco);
        }

        private void Button_Anexar_Click(object sender, EventArgs e)
        {

        }

        private void Button_cadastraResponsavel_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Label_telefone_Click(object sender, EventArgs e)
        {

        }
        void limpaCampos()
        {
            txt_nome.Clear();
            pctb_foto.Image = null;
            // dtBox_nascimento.Value = hoje.AddYears(-7);
            dtBox_nascimento.Value = DateTime.Now;
            mascara_Telefone.Clear();
            textBox_responsavel.Clear();
            textBox_rua.Clear();
            mascara_cep.Clear();
            textBox_uf.Clear();
            textBox_cidade.Clear();
            textBox_bairro.Clear();
            textBox_cidade.Clear();
            textBox_numero.Clear();
        }

        private void Button_buscaCep_Click(object sender, EventArgs e)
        {
            if (mascara_cep.Text.Trim() != "" )
            {
                String aux = "35162484";
                if (aux.Length < 11)
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        String site = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", aux);
                        ds.ReadXml(site);
                        textBox_rua.Text = ds.Tables[0].Rows[0]["Logradouro"].ToString();
                        textBox_bairro.Text = ds.Tables[0].Rows[0]["Bairro"].ToString();
                          textBox_cidade.Text = ds.Tables[0].Rows[0]["Cidade"].ToString();
                        textBox_uf.Text = ds.Tables[0].Rows[0]["Uf"].ToString();
                    }
                    catch {
                        MessageBox.Show("Erro ao buscar endereço por cep, preencha manualmente", "Buscar endereco por cep", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    /*
                    textBox_uf.Text = restResponse();
                    textBox_rua.Text = buscaCep.GetRua();
                    textBox_bairro.Text = buscaCep.GetBairro();
                    textBox_cidade.Text = buscaCep.GetCidade();*/
                }
                else
                {
                    MessageBox.Show("Cep deve ter 9 digitos","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira o código do cep antes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

    



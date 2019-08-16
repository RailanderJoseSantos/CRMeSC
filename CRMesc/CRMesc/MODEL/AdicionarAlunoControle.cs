using CRMesc.DAL;
using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CRMesc.MODEL
{
   public class AdicionarAlunoControle
    {
        private AdicionarEnderecoForm formAddAluno = new AdicionarEnderecoForm();
        public void SalvaMatricula() {
            Endereco en = new Endereco();
            Aluno aluno = new Aluno();

            Responsavel resp = new Responsavel();
            Telefone tel = new Telefone();

            String responsavel = formAddAluno.textBox_responsavel.Text;
            String telefone = formAddAluno.mascara_Telefone.Text;

            String cep = formAddAluno.mascara_cep.Text;
            String rua = formAddAluno.textBox_rua.Text;
            String bairro = formAddAluno.textBox_bairro.Text;
            int numero = 0;
            if (formAddAluno.textBox_numero.Text.Trim() != "")
            {
                numero = Convert.ToInt32(formAddAluno.textBox_numero.Text);
            }
            String cidade = formAddAluno.textBox_cidade.Text;
            String uf = formAddAluno.textBox_uf.Text;

            String nome = formAddAluno.txt_nome.Text;
            DateTime nascimento = formAddAluno.dtBox_nascimento.Value;
            // String telefone = txt_telefone.Text;
            String genero = "M";

            if (formAddAluno.rd_btn_generoFem.Checked)
            {
                genero = "F";
            }

            MemoryStream fot = new MemoryStream();

            int countSucesso = 0;
            // checando idade de aluno ( 5 a 100 anos)
            int ano_nasc = formAddAluno.dtBox_nascimento.Value.Year;
            int ano_atual = DateTime.Now.Year;
            if (LimitesCaracteresAceitos())
            {
                if ((ano_atual - ano_nasc) < 5 || (ano_atual - ano_nasc) > 100)
                {
                    MessageBox.Show("O aluno deve ter entre 5 e 100 anos", "Data de ascimento inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // adicionar aluno no banco
                if (VerificaCampoVazio())
                {
                    formAddAluno.pctb_foto.Image.Save(fot, formAddAluno.pctb_foto.Image.RawFormat);
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
                                                LimpaCampos();
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
       public bool LimitesCaracteresAceitos()
        {
            if ((formAddAluno.txt_nome.Text.Length > 50))
            {
                MessageBox.Show("Nome do aluno pode ter no máximo 50 caracteres ", "Cadatro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((formAddAluno.mascara_Telefone.Text.Length) > 20)
            {
                MessageBox.Show("Telefone  pode ter no máximo 20 digitos ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (formAddAluno.textBox_responsavel.Text.Length > 50)
            {
                MessageBox.Show("Nome do pai/responsável  pode ter no máximo 50 letras ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((formAddAluno.mascara_cep.Text.Length > 15))
            {
                MessageBox.Show("Cep  pode ter no máximo 15 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((formAddAluno.textBox_rua.Text.Length > 50))
            {
                MessageBox.Show("Rua do aluno pode ter no máximo 50 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((formAddAluno.textBox_bairro.Text.Length > 50))
            {
                MessageBox.Show("Bairro do aluno pode ter no máximo 50 caracteres ", "Cadastro de aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((formAddAluno.textBox_uf.Text.Length > 2))
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
        private bool VerificaCampoVazio()
        {
            if ((formAddAluno.txt_nome.Text.Trim() == "") ||
                //               (txt_telefone.Text.Trim() == "") ||
                (formAddAluno.rd_btn_generoFem.Checked == false && formAddAluno.rd_btn_generoMasc.Checked == false) ||
                (formAddAluno.pctb_foto.Image == null) ||
                (formAddAluno.mascara_cep.Text.Trim() == "") ||
                (formAddAluno.textBox_cidade.Text.Trim() == "") ||
                (formAddAluno.textBox_rua.Text.Trim() == "") ||
                (formAddAluno.textBox_numero.Text == "") ||
                (formAddAluno.textBox_bairro.Text.Trim() == "") ||
                (formAddAluno.textBox_uf.Text.Trim() == "") ||
                (formAddAluno.textBox_responsavel.Text.Trim() == "")
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       private void LimpaCampos()
        {
            formAddAluno.txt_nome.Clear();
            formAddAluno.pctb_foto.Image = null;
            formAddAluno.dtBox_nascimento.Value = DateTime.Now;
            formAddAluno.mascara_Telefone.Clear();
            formAddAluno.textBox_responsavel.Clear();
            formAddAluno.textBox_rua.Clear();
            formAddAluno.mascara_cep.Clear();
            formAddAluno.textBox_uf.Clear();
            formAddAluno.textBox_cidade.Clear();
            formAddAluno.textBox_bairro.Clear();
            formAddAluno.textBox_cidade.Clear();
            formAddAluno.textBox_numero.Clear();
        }

        public void BuscarCep(String cep)
        {
           /* if (formAddAluno.mascara_cep.Text.Trim() != "")
            {*/

                if (formAddAluno.mascara_cep.Text.Trim().Length < 11)
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        String site = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", cep);
                        ds.ReadXml(site);
                        formAddAluno.textBox_rua.Text = ds.Tables[0].Rows[0]["Logradouro"].ToString();
                        formAddAluno.textBox_bairro.Text = ds.Tables[0].Rows[0]["Bairro"].ToString();
                        formAddAluno.textBox_cidade.Text = ds.Tables[0].Rows[0]["Cidade"].ToString();
                        formAddAluno.textBox_uf.Text = ds.Tables[0].Rows[0]["Uf"].ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao buscar endereço por cep, preencha manualmente", "Buscar endereco por cep", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cep deve ter 9 digitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           /* }
            else
            {
                MessageBox.Show("Insira o código do cep no campo de texto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}


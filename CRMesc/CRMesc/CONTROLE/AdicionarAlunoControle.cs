using CRMesc.DAO;
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
        public DataSet ds;
        private AdicionarEnderecoForm formAddAluno = new AdicionarEnderecoForm();
        public void SalvaMatricula(String nome, DateTime nascimento, String genero, MemoryStream fot, String responsavel,
         String cep, String rua, String bairro, int numero, String cidade, String uf, String numTelefone)
        {
            AlunoDao alunoDao = new AlunoDao();
            ResponsavelDao respDao = new ResponsavelDao();
            EnderecoDao endDao = new EnderecoDao();
            TelefoneDao telDao = new TelefoneDao();

            int countSucesso = 0;
            if ((alunoDao.inserirAluno(nome, nascimento, genero, fot)))
            {
                countSucesso += 1;
                int idAluno = Convert.ToInt32(alunoDao.getIdAluno());
                if (respDao.inserirResponsavel(responsavel, idAluno))
                {
                    countSucesso += 1;
                    int idResponsavel = Convert.ToInt32(respDao.GetIdResponsavel());
                    if ((endDao.inserirEndereco(cep, rua, bairro, numero, cidade, uf)))
                    {
                        countSucesso += 1;
                        int idEndereco = Convert.ToInt32(endDao.GetIdEndereco());
                        if (endDao.AssociaEnderResponsavel(idResponsavel, idEndereco))
                        {
                            countSucesso += 1;
                            int idTelefone = Convert.ToInt32(telDao.GetIdTelefone());
                            if (telDao.InserirTelefone(numTelefone))
                            {
                                countSucesso += 1;
                                if (telDao.AssociaTelefoneResponsavel(idResponsavel, idTelefone))
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
                    ds = new DataSet();
                    String site = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", cep);
                    ds.ReadXml(site);
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


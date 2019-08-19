using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using CRMesc.DAO;

namespace CRMesc.APRESENTACAO
{
    public partial class Lista_Alunos : Form
    {
        public Lista_Alunos()
        {
            InitializeComponent();
        }
        AlunoDao aluno = new AlunoDao();
        ResponsavelDao responsavelDao = new ResponsavelDao();
        TelefoneDao telefoneDao = new TelefoneDao();
        EnderecoDao enderecoDao = new EnderecoDao();
        private void Lista_Alunos_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT IDALUNO, NOME, NASCIMENTO, GENERO, FOTO FROM ALUNO ORDER BY IDALUNO");
            grid_Alunos.ReadOnly = true;
            DataGridViewImageColumn fotoCol = new DataGridViewImageColumn();
            grid_Alunos.RowTemplate.Height = 80;
            grid_Alunos.DataSource = aluno.getAlunos(cmd);
            fotoCol = (DataGridViewImageColumn)grid_Alunos.Columns[4];
            fotoCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            grid_Alunos.AllowUserToAddRows = false;

            SqlCommand cmd2 = new SqlCommand("SELECT R.NOME, R.IDALUNO FROM RESPONSAVEL R" +
                " INNER JOIN ALUNO A" +
                " ON R.IDALUNO = A.IDALUNO  ORDER BY R.IDALUNO");
            grid_responsavel.ReadOnly = true;
            grid_responsavel.RowTemplate.Height = 80;
            grid_responsavel.DataSource = responsavelDao.getResponsavel(cmd2);
            grid_responsavel.AllowUserToAddRows = false;

            SqlCommand cmd3 = new SqlCommand("SELECT R.IDRESPONSAVEL, T.NUMERO FROM TELEFONE T INNER JOIN RESPONSAVEL_TELEFONE RT ON RT.IDTELEFONE = T.IDTELEFONE INNER JOIN RESPONSAVEL R ON R.IDRESPONSAVEL = RT.IDRESPONSAVEL INNER JOIN ALUNO A ON A.IDALUNO = R.IDALUNO ORDER BY R.IDALUNO");
            grid_Telefone.ReadOnly = true;
            grid_Telefone.RowTemplate.Height = 80;
            grid_Telefone.DataSource = telefoneDao.GetTelefone(cmd3);
            grid_Telefone.AllowUserToAddRows = false; 

            SqlCommand cmd4 = new SqlCommand("SELECT E.CEP, E.UF, E.CIDADE, E.BAIRRO, E.RUA, E.NUMERO FROM ENDERECO E INNER JOIN RESPONSAVEL_ENDERECO RE ON RE.IDENDERECO = E.IDENDERECO INNER JOIN RESPONSAVEL R ON R.IDRESPONSAVEL = RE.IDRESPONSAVEL INNER JOIN ALUNO A ON A.IDALUNO = R.IDALUNO ORDER BY A.IDALUNO");
            grid_Endereco.ReadOnly = true;
            grid_Endereco.RowTemplate.Height = 80;
            grid_Endereco.DataSource = enderecoDao.GetEndereco(cmd4);
            grid_Endereco.AllowUserToAddRows = false;
        }

        private void Grid_Alunos_DoubleClick(object sender, EventArgs e)
        {
            Atualiza_Deleta_AlunoForm atualiza_Deleta = new Atualiza_Deleta_AlunoForm();
            atualiza_Deleta.txt_idAluno.Text = grid_Alunos.CurrentRow.Cells[0].Value.ToString();
            atualiza_Deleta.txt_nome.Text = grid_Alunos.CurrentRow.Cells[1].Value.ToString();
            atualiza_Deleta.dtBox_nascimento.Value =(DateTime) grid_Alunos.CurrentRow.Cells[2].Value;
            if (grid_Alunos.CurrentRow.Cells[3].Value.ToString() == "F")
            {              
                atualiza_Deleta.rd_btn_generoFem.Checked = true;
            }

            byte[] foto;
            foto = (byte[]) grid_Alunos.CurrentRow.Cells[4].Value;
            MemoryStream picture = new MemoryStream(foto);
            atualiza_Deleta.pctb_foto.Image = Image.FromStream(picture);


            atualiza_Deleta.mascara_cep.Text = grid_Endereco.CurrentRow.Cells[0].Value.ToString();
            atualiza_Deleta.txt_estado.Text = grid_Endereco.CurrentRow.Cells[1].Value.ToString();
            atualiza_Deleta.txt_cidade.Text = grid_Endereco.CurrentRow.Cells[2].Value.ToString();
            atualiza_Deleta.txt_bairro.Text = grid_Endereco.CurrentRow.Cells[3].Value.ToString();
            atualiza_Deleta.txt_rua.Text = grid_Endereco.CurrentRow.Cells[4].Value.ToString();
            atualiza_Deleta.textBox_numero.Text = grid_Endereco.CurrentRow.Cells[5].Value.ToString();

            atualiza_Deleta.textBox_nomeResponsavel.Text = grid_responsavel.CurrentRow.Cells[0].Value.ToString();
            atualiza_Deleta.mascara_telefone.Text = grid_Telefone.CurrentRow.Cells[0].Value.ToString();

            atualiza_Deleta.Show();
        }

        private void Grid_Alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

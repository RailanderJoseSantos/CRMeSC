using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMesc.APRESENTACAO
{
    public partial class Lista_Alunos : Form
    {
        public Lista_Alunos()
        {
            InitializeComponent();
        }
        Aluno aluno = new Aluno();
        Responsavel responsavel = new Responsavel();
        Telefone telefone = new Telefone();
        Endereco endereco = new Endereco();
        private void Lista_Alunos_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT IDALUNO, NOME, NASCIMENTO, FOTO FROM ALUNO ORDER BY NOME");
            grid_Alunos.ReadOnly = true;
            DataGridViewImageColumn fotoCol = new DataGridViewImageColumn();
            grid_Alunos.RowTemplate.Height = 80;
            grid_Alunos.DataSource = aluno.getAlunos(cmd);
            fotoCol = (DataGridViewImageColumn)grid_Alunos.Columns[3];
            fotoCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            grid_Alunos.AllowUserToAddRows = false;

            SqlCommand cmd2 = new SqlCommand("SELECT R.IDRESPONSAVEL, R.NOME, R.IDALUNO FROM RESPONSAVEL R" +
                " INNER JOIN ALUNO A" +
                " ON R.IDALUNO = A.IDALUNO");
            grid_responsavel.ReadOnly = true;
            grid_responsavel.RowTemplate.Height = 80;
            grid_responsavel.DataSource = responsavel.getResponsavel(cmd2);
            grid_responsavel.AllowUserToAddRows = false;

            SqlCommand cmd3 = new SqlCommand("SELECT T.IDTELEFONE, T.NUMERO FROM TELEFONE T INNER JOIN RESPONSAVEL_TELEFONE RT ON RT.IDTELEFONE = T.IDTELEFONE INNER JOIN RESPONSAVEL R ON R.IDRESPONSAVEL = RT.IDRESPONSAVEL INNER JOIN ALUNO A ON A.IDALUNO = R.IDALUNO");
            grid_Telefone.ReadOnly = true;
            grid_Telefone.RowTemplate.Height = 80;
            grid_Telefone.DataSource = telefone.GetTelefone(cmd3);
            grid_Telefone.AllowUserToAddRows = false;

            SqlCommand cmd4 = new SqlCommand("SELECT E.IDENDERECO, E.CEP, E.RUA, E.BAIRRO, E.RUA, E.NUMERO FROM ENDERECO E INNER JOIN RESPONSAVEL_ENDERECO RE ON RE.IDENDERECO = E.IDENDERECO INNER JOIN RESPONSAVEL R ON R.IDRESPONSAVEL = RE.IDRESPONSAVEL INNER JOIN ALUNO A ON A.IDALUNO = R.IDALUNO");
            grid_Endereco.ReadOnly = true;
            grid_Endereco.RowTemplate.Height = 80;
            grid_Endereco.DataSource = endereco.getEndereco(cmd4);
            grid_Endereco.AllowUserToAddRows = false;
        }

        private void Grid_Alunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Atualiza_Deleta_AlunoForm atualiza_Deleta = new Atualiza_Deleta_AlunoForm();
            atualiza_Deleta.Show();
        }

        private void Grid_responsavel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Atualiza_Deleta_AlunoForm atualiza_Deleta = new Atualiza_Deleta_AlunoForm();
            atualiza_Deleta.Show();
        }

        private void Grid_Telefone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Atualiza_Deleta_AlunoForm atualiza_Deleta = new Atualiza_Deleta_AlunoForm();
            atualiza_Deleta.Show();
        }
    }
}

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
    public partial class ListaAlunoForm : Form
    {
        public ListaAlunoForm()
        {
            InitializeComponent();
        }
        Aluno aluno = new Aluno();
        private void ListaAlunoForm_Load(object sender, EventArgs e)
        {
            //populando a grid
            SqlCommand comand = new SqlCommand("SELECT * FROM ALUNO");
            grid_alunos.ReadOnly = true;
            DataGridViewImageColumn fotoCol = new DataGridViewImageColumn();
            grid_alunos.RowTemplate.Height = 80;
            grid_alunos.DataSource = aluno.getAlunos(comand);
            //6 indice da imagem em relacao aos campos no banco
            fotoCol = (DataGridViewImageColumn)grid_alunos.Columns[6];
            fotoCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            grid_alunos.AllowUserToAddRows = false;

        }

        private void Grid_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_alunos_DoubleClick(object sender, EventArgs e)
        {
            //duplo clique: editar/remover
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            //atualiza a grid
        }
    }
}

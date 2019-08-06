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
            fotoCol = (DataGridViewImageColumn)grid_alunos.Columns[5];
            fotoCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            grid_alunos.AllowUserToAddRows = false;

        }

        private void Grid_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_alunos_DoubleClick(object sender, EventArgs e)
        {
            //duplo clique: editar/remover
            Atualiza_Deleta_AlunoForm atualizaDeleta = new Atualiza_Deleta_AlunoForm();

            atualizaDeleta.txt_idAluno.Text = Convert.ToString( grid_alunos.CurrentRow.Cells[0].Value);
            atualizaDeleta.txt_nome.Text = grid_alunos.CurrentRow.Cells[1].Value.ToString();
            atualizaDeleta.dtBox_nascimento.Value =(DateTime) grid_alunos.CurrentRow.Cells[2].Value;
            //genero
            if(grid_alunos.CurrentRow.Cells[3].Value.ToString() == "Feminino")
            {
                atualizaDeleta.rd_btn_generoFem.Checked = true;
            }
            atualizaDeleta.txt_telefone.Text = grid_alunos.CurrentRow.Cells[4].Value.ToString();

            // foto
            byte[] foto;
            foto = (byte[])grid_alunos.CurrentRow.Cells[5].Value;
            MemoryStream imagem = new MemoryStream(foto);
            atualizaDeleta.pctb_foto.Image = Image.FromStream(imagem);
            //endereco
            atualizaDeleta.txt_cep.Text = grid_alunos.CurrentRow.Cells[6].Value.ToString();
            atualizaDeleta.txt_rua.Text = grid_alunos.CurrentRow.Cells[7].Value.ToString();
            atualizaDeleta.txt_bairro.Text = grid_alunos.CurrentRow.Cells[8].Value.ToString();
            atualizaDeleta.txt_numero.Text = grid_alunos.CurrentRow.Cells[9].Value.ToString();
            atualizaDeleta.txt_cidade.Text = grid_alunos.CurrentRow.Cells[10].Value.ToString();
            atualizaDeleta.txt_estado.Text = grid_alunos.CurrentRow.Cells[11].Value.ToString();
            atualizaDeleta.Show();
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            //atualiza a grid
            SqlCommand comand = new SqlCommand("SELECT * FROM ALUNO");
            grid_alunos.ReadOnly = true;
            DataGridViewImageColumn fotoCol = new DataGridViewImageColumn();
            grid_alunos.RowTemplate.Height = 80;
            grid_alunos.DataSource = aluno.getAlunos(comand);
            //6 indice da imagem em relacao aos campos no banco
            fotoCol = (DataGridViewImageColumn)grid_alunos.Columns[5];
            fotoCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            grid_alunos.AllowUserToAddRows = false;

        }
    }
}

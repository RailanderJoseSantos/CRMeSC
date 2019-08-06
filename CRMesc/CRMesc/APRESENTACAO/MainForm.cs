using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRMesc.APRESENTACAO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AdcionarNovoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarAlunoForm adicionarAluno = new AdicionarAlunoForm();
            adicionarAluno.Show(this);
        }

        private void NomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAlunoForm listaAluno = new ListaAlunoForm();
            listaAluno.Show(this);
        }

        private void EstatisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atualiza_Deleta_AlunoForm atualzaDeleta = new Atualiza_Deleta_AlunoForm();
            atualzaDeleta.Show(this);
        }

        private void MSFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PONTUAÇAOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

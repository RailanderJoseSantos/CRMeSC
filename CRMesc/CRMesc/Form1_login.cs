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
    }
}

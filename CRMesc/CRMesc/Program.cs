using CRMesc.APRESENTACAO;
using CRMesc.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CRMesc
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1_login());
            Form1_login flogin = new Form1_login();
            if (flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else {
                Application.Exit();
            }
        }
    }
}

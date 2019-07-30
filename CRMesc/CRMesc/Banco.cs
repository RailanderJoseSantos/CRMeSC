using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace CRMesc
{
    /*
     * Conexao com banco e aplicacao
     */
    class Banco
    {
        //CONEXAO
        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=12345;database=crmesc");
        // funcao para obter conexao
        public MySqlConnection getConnection {
            get{
                return con;
                
            }
        }

        // FUNCAO PARA ABRIR CONEXAO
        public void openConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        // FUNCAO PARA FECHAR CONEXAO
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

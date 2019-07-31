using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace CRMesc.DAL
{
    public class Banco {
        SqlConnection con = new SqlConnection();
        //construtor
        public Banco() {
            con.ConnectionString =
                @"Data Source=DESKTOP-NEHHM30\SQLEXPRESS;Initial Catalog=CRMESC;Integrated Security=True";
        }

        //conector
        public SqlConnection conectar() {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
             return con;
        }

        //desconector
        public void desconctar() {
             if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }

    }



using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CRMesc.DAL
{
    class LoginDaoComandos
    {
        Banco con = new Banco();
        SqlDataReader dr;
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();


        public bool VerificarLogin(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            //comando sql
            cmd.CommandText = "SELECT USUARIO FROM USUARIOS	WHERE USUARIO = @login AND SENHA = @senha";
            cmd.Parameters.AddWithValue("@login",login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }

       public String Cadastrar(String login, String senha, String confSenha)
        {
            //comandos pra inserir no banco
            return mensagem;
        }
    }
}

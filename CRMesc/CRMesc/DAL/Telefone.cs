using CRMesc.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CRMesc.DAL
{
    class Telefone
    {
        Banco db = new Banco();
        public bool inserirTelefone(String numero)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TELEFONE(NUMERO)" +
                "VALUES(@NUMERO)", db.conectar());

            cmd.Parameters.Add("@NUMERO", SqlDbType.VarChar).Value = numero; 
            db.conectar();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.desconectar();
                return true;
            }
            else
            {
                db.desconectar();
                return false;
            }

        }
        //funcai de inserir na grid
        public DataTable getAlunos(SqlCommand comand)
        {
            comand.Connection = db.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //funcao para atualizar aluno
        public bool AtualizaraTelefone(int idTelefone, String numero)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TELEFONE SET numero = @num WHERE IDTELEFONE = @id", db.conectar());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idTelefone;
            db.conectar();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.desconectar();
                return true;
            }
            else
            {
                db.desconectar();
                return false;
            }

        }
            public DataTable GetTelefone(SqlCommand comand)
            {
                comand.Connection = db.conectar();
                SqlDataAdapter adapter = new SqlDataAdapter(comand);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }

        public bool AssociaTelefoneResponsavel(int idResponsavel, int idTelefone)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO RESPONSAVEL_TELEFONE (IDRESPONSAVEL, IDTELEFONE)" +
                "VALUES(@IDRESP, @IDTEL)", db.conectar());

            cmd.Parameters.Add("@IDRESP", SqlDbType.VarChar).Value = idResponsavel;
            cmd.Parameters.Add("@IDTEL", SqlDbType.VarChar).Value = idTelefone;

            db.conectar();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.desconectar();
                return true;
            }
            else
            {
                db.desconectar();
                return false;
            }

        }

        internal int GetIdTelefone()
        {
            int tel = 0;
            SqlCommand cmd2 = new SqlCommand("SELECT MAX(IDTELEFONE) FROM TELEFONE", db.conectar());
            cmd2.CommandType = CommandType.Text;

            if (cmd2.ExecuteScalar().GetType() != typeof(DBNull))
            {
                tel = Convert.ToInt32(cmd2.ExecuteScalar());
            }
            else
            {
                tel = 1;
            }
            return tel;
        }


        //funcao para deletar aluno
        public bool DeletarTelefone(int idTelefone)
        {
            //mandar deletar endereco associado
            SqlCommand cmd = new SqlCommand("DELETE FROM TELEFONE WHERE IDTELEFONE = @id", db.conectar());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idTelefone;

            db.conectar();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.desconectar();
                return true;
            }
            else
            {
                db.desconectar();
                return false;
            }

        }
    }
}

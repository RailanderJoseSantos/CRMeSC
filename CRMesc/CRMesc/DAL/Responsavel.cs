using CRMesc.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CRMesc.DAL
{
    class Responsavel
    {
        Banco db = new Banco();
        public bool inserirResponsavel(String nome, int idAluno)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO RESPONSAVEL(nome, IDALUNO)" +
                "VALUES(@nm,@idal)", db.conectar());

            cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@idal", SqlDbType.Int).Value = idAluno;
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
        public DataTable getResponsavel(SqlCommand comand)
        {
            comand.Connection = db.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //funcao para atualizar aluno
        public bool AtualizarResponsavel( String nome)
        {
            SqlCommand cmd = new SqlCommand("UPDATE RESPONSAVEL SET nome = @nm WHERE ID = @id", db.conectar());
            cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = nome;

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

        internal int GetIdResponsavel()
        {
            int resp = 0;
            SqlCommand cmd2 = new SqlCommand("SELECT MAX(IDALUNO) FROM RESPONSAVEL", db.conectar());
            cmd2.CommandType = CommandType.Text;

            if (cmd2.ExecuteScalar().GetType() != typeof(DBNull))
            {
               resp = Convert.ToInt32(cmd2.ExecuteScalar());
            }
            else
            {
                resp = 1;
            }
            return resp;
        }


        //funcao para deletar aluno
        public bool DeletarResponsavel(int idResponsavel)
        {
            //mandar deletar endereco associado
            SqlCommand cmd = new SqlCommand("DELETE FROM RESPONSAVEL WHERE ID = @id", db.conectar());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idResponsavel;

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

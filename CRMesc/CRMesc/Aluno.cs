using CRMesc.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
namespace CRMesc
{
    class Aluno
    {
        //funcao paraadcionar novo aluno no banco
        Banco db = new Banco();
        public bool inserirAluno(String nome, DateTime nascimento, String genero, MemoryStream foto)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ALUNO( nome, nascimento, genero, foto)" +
                "VALUES(@nm,@nsc,@gnr,@fot)", db.conectar());
            
            cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@nsc", SqlDbType.Date).Value = nascimento;
            cmd.Parameters.Add("@gnr", SqlDbType.VarChar).Value = genero;
            cmd.Parameters.Add("@fot", SqlDbType.Image).Value = foto.ToArray();
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
        public bool atualizarAluno(int idAluno, String nome, DateTime nascimento, String telefone, String genero, MemoryStream foto, String cep, String rua, String bairro, int numero, String cidade, String estado)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ALUNO SET nome = @no, nascimento = @nsc, genero = @gnr WHERE ID = @id", db.conectar());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idAluno;
            cmd.Parameters.Add("@no", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@nsc", SqlDbType.Date).Value = nascimento;
            cmd.Parameters.Add("@gnr", SqlDbType.VarChar).Value = genero;
            cmd.Parameters.Add("@fot", SqlDbType.Image).Value = foto.ToArray();
         
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

        internal int getIdAluno()
        {
            int alun = 0;
            SqlCommand cmd2 = new SqlCommand("SELECT MAX(IDALUNO) FROM ALUNO", db.conectar());
            cmd2.CommandType = CommandType.Text;

            if (cmd2.ExecuteScalar().GetType() != typeof(DBNull))
            {
                alun = Convert.ToInt32(cmd2.ExecuteScalar());
            }
            return alun;
        }
        

        //funcao para deletar aluno
        public bool deletarAluno(int idAluno)
        {
            //mandar deletar endereco associado
            SqlCommand cmd = new SqlCommand("DELETE FROM ALUNO WHERE ID = @id", db.conectar());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idAluno;

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

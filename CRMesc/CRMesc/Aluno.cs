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
        public bool inserirAluno(String nome, DateTime nascimento, String telefone, String genero, int idEndereco, MemoryStream foto)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ALUNO( nome, nascimento, genero, telefone, foto, cep, rua, bairro, numero, cidade, uf)" +
                "VALUES(@nm,@nsc,@gnr,@tel,@fot, @cp, @ru, @ba, @nu, @ci, @uf)", db.conectar());
            cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@nsc", SqlDbType.Date).Value = nascimento;
            cmd.Parameters.Add("@gnr", SqlDbType.VarChar).Value = telefone;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = genero;
            cmd.Parameters.Add("@fot", SqlDbType.Image).Value = foto.ToArray();
            cmd.Parameters.Add("@cp", SqlDbType.VarChar).Value = cep;
            cmd.Parameters.Add("@ru", SqlDbType.VarChar).Value = rua;
            cmd.Parameters.Add("@ba", SqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@nu", SqlDbType.Int).Value = numero;
            cmd.Parameters.Add("@ci", SqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = uf;
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
        public bool atualizarAluno(int idAluno, String nome, DateTime nascimento, String telefone, String genero, int idEndereco, MemoryStream foto)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ALUNO SET nome = @nm, nascimento = @nsc, genero = @gnr, telefone = @tel,"+
                "endereco = @idEnd, foto = @fot) WHERE ID = @ID", db.conectar());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idAluno;
            cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@nsc", SqlDbType.Date).Value = nascimento;
            cmd.Parameters.Add("@gnr", SqlDbType.VarChar).Value = telefone;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = genero;
            cmd.Parameters.Add("@idEnd", SqlDbType.Int).Value = idEndereco;
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

        //funcao para deletar aluno
        public bool deletarAlumo(int idAluno)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ID = @ID", db.conectar());
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

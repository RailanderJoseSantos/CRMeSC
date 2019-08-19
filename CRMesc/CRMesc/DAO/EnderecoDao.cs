using CRMesc.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace CRMesc.DAO
{
    class EnderecoDao
    {
        //funcao paraadcionar novo aluno no banco
        Banco db = new Banco();
        public bool inserirEndereco(String cep, String rua, String bairro, int numero, String cidade, String estado)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ENDERECO (CEP, UF, CIDADE, BAIRRO, RUA, NUMERO)" +
                "VALUES(@CP, @UF, @CI, @BA, @RU, @NU)", db.conectar());
            int idEndereco = 0;
            cmd.Parameters.Add("@cp", SqlDbType.VarChar).Value = cep;
            cmd.Parameters.Add("@ru", SqlDbType.VarChar).Value = rua;
            cmd.Parameters.Add("@ba", SqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@nu", SqlDbType.Int).Value = numero;
            cmd.Parameters.Add("@ci", SqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = estado;
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

        public bool AssociaEnderResponsavel(int idResponsavel, int idEndereco)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO RESPONSAVEL_ENDERECO (IDENDERECO, IDRESPONSAVEL)" +
                "VALUES(@IDEND, @IDAL)", db.conectar());

            cmd.Parameters.Add("@IDEND", SqlDbType.VarChar).Value = idEndereco;
            cmd.Parameters.Add("@IDAL", SqlDbType.VarChar).Value = idResponsavel;

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
        public DataTable GetEndereco(SqlCommand comand)
        {
            comand.Connection = db.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            DataTable tableEnd = new DataTable();
            adapter.Fill(tableEnd);
            return tableEnd;
        }
        //funcao para atualizar endereco
        public bool AtualizarEndereco(int idAluno, String cep, String rua, String bairro, int numero, String cidade, String estado)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ENDERECO SET CEP = @cp, UF = @uf, CIDADE = @ci, BAIRRO = @ba, RUA = @ru, NUMERO = @nu WHERE ID =" + idAluno, db.conectar());
            int idEndereco = 0;
            cmd.Parameters.Add("@cp", SqlDbType.VarChar).Value = cep;
            cmd.Parameters.Add("@ru", SqlDbType.VarChar).Value = rua;
            cmd.Parameters.Add("@ba", SqlDbType.VarChar).Value = bairro;
            cmd.Parameters.Add("@nu", SqlDbType.Int).Value = numero;
            cmd.Parameters.Add("@ci", SqlDbType.VarChar).Value = cidade;
            cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = estado;
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
        public bool DeletarEndereco(int idEndereco)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ENDERECO WHERE IDENDERECO = @idEndereco", db.conectar());
            cmd.Parameters.Add("@idEndereco", SqlDbType.Int).Value = idEndereco;

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
        public int GetIdEndereco()
        {
            int end = 0;
            SqlCommand cmd2 = new SqlCommand("SELECT MAX(IDENDERECO) FROM ENDERECO", db.conectar());
            cmd2.CommandType = CommandType.Text;
            if (cmd2.ExecuteScalar().GetType() != typeof(DBNull))
            {
                end = Convert.ToInt32(cmd2.ExecuteScalar());
            }
            else
            {
                end = 1;
            }
            return end;
        }
    }
}

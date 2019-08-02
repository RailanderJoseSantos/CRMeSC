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
    class Endereco
    {

        //funcao paraadcionar novo endereco no banco
        public Banco db = new Banco();
        public bool inserirEndereco(String cep, String rua, String bairro, int numero, String cidade, String uf)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ENDERECO(cep, rua, bairro, numero, cidade, uf)" +
                "VALUES(@cp, @ru, @ba, @nu, @ci, @uf)", db.conectar());
            // SqlCommand cmd = new SqlCommand("EXEC PC_INSERE_ENDERECO @cp,@ru,@ba,@nu,@ci,@uf", db.conectar());

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
        public bool deletarEndereco(int idEndereco, bool ultimo_endereco)
        {
            SqlCommand cmd;
            SqlConnection c = new SqlConnection();
          
            if (ultimo_endereco)
            {
                cmd = new SqlCommand("EXEC PC_DELETA_ULTIMO_ENDERECO", db.conectar());
            }
            else
            {

                cmd = new SqlCommand("EXEC PC_DELETA_ENDERECO @id", db.conectar());
                cmd.Parameters.Add("@nu", SqlDbType.Int).Value = idEndereco;
            }
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
        /*

        public bool RollbackEndereco()
        {
            Banco dbs = new Banco();
            SqlCommand cmd;
            cmd = new SqlCommand("rollback transaction ins;", dbs.conectar());
            dbs.conectar();
            if (cmd.ExecuteNonQuery() == 1)
            {
                dbs.desconectar();
                return true;
            }
            else
            {
                db.desconectar();
                return false;
            }
        }*/
    }
}


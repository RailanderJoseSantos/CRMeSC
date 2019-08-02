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
        public bool inserirAluno(String nome, DateTime nascimento, String telefone, String genero, int idEndereco,  MemoryStream foto )
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ALUNO( nome, nascimento, genero, telefone, endereco, foto)" +
                "VALUES(@nm,@nsc,@gnr,@tel,@idEnd,@fot)",db.conectar());
            cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@nsc", SqlDbType.Date).Value = nascimento;
            cmd.Parameters.Add("@gnr", SqlDbType.VarChar).Value = telefone;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = genero;
            cmd.Parameters.Add("@idEnd", SqlDbType.Int).Value = idEndereco;
            cmd.Parameters.Add("@fot", SqlDbType.Image).Value = foto.ToArray();

            db.conectar();
            if(cmd.ExecuteNonQuery() == 1)
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

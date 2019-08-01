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
        public bool inserirAluno(String nome, DateTime nascimento, String telefone, String genero, String endereco,  MemoryStream foto )
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ALUNO( NOME,NASCIMENTO,GENERO,TELEFONE,ENDERECO,FOTO) " +
                "VALUES(@nm,@nsc,@gnr,@tel,@end,@fot)",db.conectar());
            cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@nsc", SqlDbType.DateTime).Value = nascimento;
            cmd.Parameters.Add("@gnr", SqlDbType.VarChar).Value = telefone;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = genero;
            cmd.Parameters.Add("@end", SqlDbType.Text).Value = endereco;
            cmd.Parameters.Add("@fot", SqlDbType.Image).Value = foto;


            return true; 
        }
    }
}

using CRMesc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRMesc
{
    public class LoginControle
    {
        public bool tem;
        public String mensagem = "";
        public bool verificarLogin(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            //comando sql
            tem = loginDao.VerificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

      /*  public String cadastrar(String login, String senha, String confSenha)
        {
            return;
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao;

namespace RmSoft.Bd
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar (string Login, String Senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.verificarLogin(Login, Senha);
            if(!LoginDao.mensagem.Equals(""))
                {
                this.mensagem = LoginDao.mensagem;
                }
            return tem;
        }
    }
}

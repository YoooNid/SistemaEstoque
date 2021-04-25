using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using RmSoft;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace Validacao
{
    class LoginDaoComandos

    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        
        
        
       
        
        
        public bool verificarLogin(String Usuario, String Senha)
        {
            
                cmd.CommandText = "select * from Funcionario where Usuario = @Usuario and senha = @Senha";
                                // select * from usuario where nome = 'rodrigo' and senha = '123'
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Senha", Senha);
           
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                
                if (dr.HasRows)
                {
                    tem = true;
                }
               
            
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se comunicar com o banco de dados (validacao)";
            }



            return tem;


        }
    }
}

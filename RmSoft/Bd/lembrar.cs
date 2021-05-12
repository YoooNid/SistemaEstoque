using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RmSoft;

namespace lembrar.Bd
{
    class Lembrar
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        String mensagem = "";
        public Lembrar(String Usuario)
        {
            cmd.CommandText = "update RmSoft..Funcionario set lembrar = 1 where Usuario = @Usuario";
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            
           
            try
            {

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException E)
            {
                this.mensagem = "Erro ao tentar se comunicar com o banco de dados";
            }




        }

    }
}

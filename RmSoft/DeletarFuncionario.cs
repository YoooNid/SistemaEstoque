using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace RmSoft
{
    class DeletarFuncionario
    
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            public String mensagem = "";
            public DeletarFuncionario(String Codigo, String Usuario)
            {

                cmd.CommandText = "delete from Funcionario where Codigo = @Codigo and Usuario = @Usuario ";
                           
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
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




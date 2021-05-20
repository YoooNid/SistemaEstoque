using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmSoft
{
    class DeletarProduto
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public DeletarProduto(int Codigo)
        {

            cmd.CommandText = "delete from RmSoft..Produtos where Codigo = @Codigo";
            cmd.Parameters.AddWithValue("@Codigo", Codigo);
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

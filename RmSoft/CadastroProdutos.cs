using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmSoft
{
    class CadastroProdutos
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public CadastroProdutos(String Desc, float preco)
        {
            cmd.CommandText = "insert into Rmsoft..produtos (descricao, preco) values (@descricao, "+preco+")";
            cmd.Parameters.AddWithValue("@descricao", Desc);
            
            try
            {

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();


            }
            catch (SqlException E)
            {
                this.mensagem = "Erro ao tentar se comunicar com o banco de dados" + E;
            }
        }
    }
}

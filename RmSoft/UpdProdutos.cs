using System;
using System.Data.SqlClient;


namespace RmSoft
{
    class UpdProdutos
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public UpdProdutos(int Codigo, String Descricao) // construtor (obriga a entrada de dados)
        {
            cmd.CommandText = "update RmSoft..Produtos set Descricao = @Descricao where codigo = @Codigo";
            cmd.Parameters.AddWithValue("@Codigo", Codigo);
            cmd.Parameters.AddWithValue("@Descricao", Descricao);
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

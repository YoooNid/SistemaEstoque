using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmSoft.upd
{
    class AtualizaEstoque
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public AtualizaEstoque(int Codigo, int QntEstoque) // construtor (obriga a entrada de dados)
        {
            cmd.CommandText = "update RmSoft..Produtos set Estoque = Estoque + @Estoque where codigo = @Codigo";
            cmd.Parameters.AddWithValue("@Codigo", Codigo);
            cmd.Parameters.AddWithValue("@Estoque", QntEstoque);
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
        public void RetiraEstoque(int Codigo, int QntEstoque)
        {
            cmd.CommandText = "update RmSoft..Produtos set Estoque = Estoque - @Estoque where codigo = @Codigo";
            cmd.Parameters.AddWithValue("@Codigo", Codigo);
            cmd.Parameters.AddWithValue("@Estoque", QntEstoque);
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
            return;
        }
    }
}

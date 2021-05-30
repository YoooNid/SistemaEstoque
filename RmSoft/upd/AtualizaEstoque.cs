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
        public AtualizaEstoque(int Codigo, int QntEstoque, int ent, String nome, int EstoqueAntigo, int entrSaid, String us) // construtor (obriga a entrada de dados)
        {
            int res;
            if (ent == 1) // caso for adicionar produtos 
            {
               res = EstoqueAntigo + entrSaid;
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
                //insere o tipo de movimento e usuario que fez a alteração e o horario 

                cmd.CommandText = "insert into Historico (cod_prod, prod_descricao, Estoque_anterior, Qnt_Entrada, Qnt_Saida, Qnt_Inventario, Saldo_atual, Usuario) values (@cod_prod, @prod_descricao, @Estoque_anterior, @Qnt_Entrada, '0', '',  @Saldo_Atual, @Usuario)";
                cmd.Parameters.AddWithValue("@cod_prod", Codigo);
                cmd.Parameters.AddWithValue("prod_descricao", nome);
                cmd.Parameters.AddWithValue("@Estoque_anterior", EstoqueAntigo);
                cmd.Parameters.AddWithValue("@Qnt_Entrada", entrSaid);
                cmd.Parameters.AddWithValue("@Usuario", us);
                cmd.Parameters.AddWithValue("@Saldo_Atual", res);




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
            else
            {
                res = EstoqueAntigo - entrSaid;
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


                cmd.CommandText = "insert into Historico (cod_prod,   prod_descricao,  Estoque_anterior, Qnt_Entrada, Qnt_Saida, Qnt_Inventario,Saldo_atual, Usuario) values " +
                                                        "(@cod_prod, @prod_descricao, @Estoque_anterior, '0', @Qnt_Saida, '', @Saldo_Atual, @Usuario)";
                cmd.Parameters.AddWithValue("@cod_prod", Codigo);
                cmd.Parameters.AddWithValue("prod_descricao", nome);
                cmd.Parameters.AddWithValue("@Estoque_anterior", EstoqueAntigo);
                cmd.Parameters.AddWithValue("@Qnt_Saida", entrSaid);
                cmd.Parameters.AddWithValue("@Usuario", us);
                cmd.Parameters.AddWithValue("@Saldo_Atual", res);





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
}

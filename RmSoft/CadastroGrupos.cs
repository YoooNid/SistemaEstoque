using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmSoft
{
    class CadastroGrupos
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public CadastroGrupos(int Codigo, string Desc, int Con)
        {

            if (Con == 1)
            {
                cmd.CommandText = "update Rmsoft..Grupos set Descricao = @Descricao where Cod_Grupo = @Codigo";
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.Parameters.AddWithValue("@Descricao", Desc);

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
                cmd.CommandText = "insert into Rmsoft..Grupos (Cod_Grupo, Descricao) values (@Codigo, @descricao)";
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.Parameters.AddWithValue("@Descricao", Desc);

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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace RmSoft
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public Cadastro(String Nome, String Usuario, String Senha, String Endereco, String Bairro,  string Cidade)
        {
            cmd.CommandText = "insert into Usuario (Nome, Usuario, Senha, Endereco, Bairro, Cidade) values (@Nome, @Usuario, @Senha, @Endereco, @Bairro, @Cidade)"; 
//            
            //cmd.Parameters.AddWithValue("@Codigo", Codigo);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@senha", Senha);
            cmd.Parameters.AddWithValue("@Endereco", Endereco);
            cmd.Parameters.AddWithValue("@Bairro", Bairro);
            cmd.Parameters.AddWithValue("@Cidade", Cidade);


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

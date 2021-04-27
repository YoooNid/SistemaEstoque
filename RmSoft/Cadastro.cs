using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace RmSoft
{
    public class CadastroFuncionario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public CadastroFuncionario(String Codigo, String Nome, String Sexo, String RG, String CPF, String Usuario, String Senha, String Endereco, String Bairro,  String Cidade, String OBS)
        {





            
            cmd.CommandText = "insert into Funcionario (Codigo, Nome, Sexo, RG, CPF, Usuario, Senha, Endereco, Bairro, Cidade, OBS) values (@Codigo, @Nome, @Sexo, @RG, @CPF, @Usuario, @Senha, @Endereco, @Bairro, @Cidade, @OBS)";
            //            
            
            cmd.Parameters.AddWithValue("@Codigo", Codigo);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@senha", Senha);
            cmd.Parameters.AddWithValue("@Endereco", Endereco);
            cmd.Parameters.AddWithValue("@Bairro", Bairro);
            cmd.Parameters.AddWithValue("@Cidade", Cidade);
            cmd.Parameters.AddWithValue("@RG", RG);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@OBS", OBS);


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

using System;
using System.Data.SqlClient;


namespace RmSoft
{
    class UpdFuncionario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public UpdFuncionario(String Codigo, String Nome, String Sexo, String RG, String CPF, String Usuario, String Senha, String Endereco, String Bairro, String Cidade, String OBS) // construtor (obriga a entrada de dados)
        {

            cmd.CommandText = "update funcionario set Nome = @nome, Sexo = @Sexo, rg = @RG, cpf = @CPF, Endereco = @Endereco, bairro = @Bairro, Cidade = @Cidade, Usuario = @Usuario, Senha = @Senha, Obs = @OBS where codigo = @Codigo";
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
                this.mensagem = "Erro ao tentar se comunicar com o banco de dados" + E;
            }



        }
    }
}

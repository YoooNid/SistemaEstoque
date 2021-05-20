﻿using System;
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
        public CadastroProdutos(int Codigo, String Desc, int Estoque)
        {
            cmd.CommandText = "insert into Rmsoft..produtos (Codigo, descricao, Estoque) values (@Codigo, @descricao, @Estoque)";
            cmd.Parameters.AddWithValue("@Codigo", Codigo);
            cmd.Parameters.AddWithValue("@Descricao", Desc);
            cmd.Parameters.AddWithValue("@Estoque",Estoque);

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

﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ArquivoIni;

namespace RmSoft
{
    public class Conexao

    {
        
        SqlConnection Con = new SqlConnection();

        public Conexao()
        {
            Con.ConnectionString = (@"Data Source=DESKTOP-MHRUPDK\SQL; Initial Catalog=RmSoft;Integrated Security=True"); //correto
        }

        public SqlConnection Conectar()
        {
            if (Con.State == System.Data.ConnectionState.Closed)
            {
                
                Con.Open();
            }
            return Con;
        }
        public void Desconectar()
        {
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }
    }
}

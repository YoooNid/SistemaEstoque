using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArquivoIni;
using lembrar.Bd;
using RmSoft;
using RmSoft.Bd;
using Validacao;
using Limpar.Bd;

namespace RmSoft
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        IniFiles ini = new IniFiles(@"C:\testes\Configuração.ini");

        public Login()
        {
            InitializeComponent();
        }
        public String usuario;

        private void Form1_Load(object sender, EventArgs e)

        {
            
            
            SqlConnection Con = new SqlConnection();

            try
            {
                Con.ConnectionString = (@"Data Source=" + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Initial Catalog=RmSoft;Integrated Security=True");
                Con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao conectar o banco de dados");
                Application.Exit();
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle();
            controle.acessar(Usuario.Text, Senha.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("bem vindo");

                    if (checkBox1.Checked)
                    {
                        Conexao conexao = new Conexao();
                        SqlCommand cmd = new SqlCommand();
                        String mensagem = "";

                        cmd.CommandText = "update Funcionario set marcado = '0'  ";
                        Lembrar lembrar = new Lembrar(Usuario.Text);


                        try
                        {

                            cmd.Connection = conexao.Conectar();
                            cmd.ExecuteNonQuery();
                            conexao.Desconectar();


                        }
                        catch (SqlException E)
                        {
                            mensagem = "Erro ao tentar se comunicar com o banco de dados";
                        }
                    }

                        
                    // comando para tirar o 1 do usuario logado antes 
                    // comando para gravar 1 no usuario logado no sistema 

                    this.Hide();
                    Principal f = new Principal();
                    f.Closed += (s, args) => this.Close();
                    f.usuario = Usuario.Text;
                    f.ShowDialog();
                    




                }
                else
                {

                    MessageBox.Show("nao encontrado");
                    Usuario.Text = "";
                    Senha.Text = "";
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.PerformClick();
            }
        }
        private void Check(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Senha.Focus();
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

    

      

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ArquivoIni;
using RmSoft;
using RmSoft.Bd;
using Validacao;
using System.Globalization;
using RmSoft.upd;

namespace RmSoft
{
    public partial class Principal : Form
    {
        IniFiles ini = new IniFiles(@"C:\testes\Configuração.ini");
        public string usuario { get; internal set; } // pegando o usuario que foi digitado na tela de login
        public int con;  //variavel de controle para saber se o usuario selecionou o item ou nao

        public Principal()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

            xtraTabControl1.SelectedTabPageIndex = 0;
            con = 0;
            textBox11.Text = "";
            textBox9.Text = "";
            textBox13.Text = "";
        }

        private void Principal_Load(object sender, EventArgs e)


        {
            
            label12.Visible = true;
            label12.Text = usuario;
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            xtraTabControl1.SelectedTabPageIndex = 2;
            label1.AutoEllipsis = true;
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            con = 0;
            Txt_NomeFuncionario.Text = "";
            textBox1.Text = "";
            Tb_UsuarioFuncionario.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "";
            Tb_CodFuncionario.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = 0;
            Txt_NomeFuncionario.Text = "";
            textBox1.Text = "";
            Tb_UsuarioFuncionario.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "";
            Tb_CodFuncionario.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con == 1)
            {
                if (Txt_NomeFuncionario.Text == "")
                {
                    MessageBox.Show("Campo 'NOME' Obrigatorio!");
                }
                else
                {
                    UpdFuncionario up = new UpdFuncionario(Tb_CodFuncionario.Text, Txt_NomeFuncionario.Text, comboBox1.Text, textBox8.Text, textBox1.Text, Tb_UsuarioFuncionario.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, richTextBox1.Text);
                    
                    MessageBox.Show("Alterado com sucesso");
                }


            }
            else
            {
                CadastroFuncionario cad = new CadastroFuncionario(Tb_CodFuncionario.Text, Txt_NomeFuncionario.Text, comboBox1.Text, textBox8.Text, textBox1.Text, Tb_UsuarioFuncionario.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, richTextBox1.Text);

                Txt_NomeFuncionario.Text = "";
                textBox1.Text = "";
                Tb_UsuarioFuncionario.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "";
                Tb_CodFuncionario.Text = "";
                MessageBox.Show("Cadastrado com sucesso");
            }

         }
            
        

      
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (Grid_Funcionario.Visible == false)
            {
                label19.Visible = false;
                Grid_Funcionario.Visible = true;

                SqlDataAdapter da;
                DataSet ds;
                SqlConnection con = new SqlConnection();
                ds = new DataSet();
                con.ConnectionString = (@"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Integrated Security = True");
                con.Open();
                da = new SqlDataAdapter("select * from rmsoft..Funcionario", con);
                da.Fill(ds, "all");
                Grid_Funcionario.DataSource = null;
                Grid_Funcionario.DataSource = ds.Tables["all"];
                con.Close();
            }
            else
            {
                Grid_Funcionario.Visible = false;
                label19.Visible = true;
            }





        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (con == 1)
            {
                
                    DeletarFuncionario del = new DeletarFuncionario(Tb_CodFuncionario.Text, Tb_UsuarioFuncionario.Text);
                    Txt_NomeFuncionario.Text = "";
                    textBox1.Text = "";
                    Tb_UsuarioFuncionario.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    richTextBox1.Text = "";
                    comboBox1.Text = "";
                    Tb_CodFuncionario.Text = "";
                    MessageBox.Show("deletado com sucesso");
                    con = 0;
            }
            else
                MessageBox.Show("selecione um Funcionario");

        }


        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString();
        }

        private void Hora_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            label14.Visible = false;

            SqlDataAdapter da;
            DataSet ds;
            SqlConnection con = new SqlConnection();
            ds = new DataSet();
            con.ConnectionString = (@"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Integrated Security = True");
            con.Open();
            da = new SqlDataAdapter("select * from rmsoft..produtos", con);
            da.Fill(ds, "all");
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ds.Tables["all"];
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int Codigo = int.Parse(textBox9.Text);
            int Estoque = int.Parse(textBox13.Text);
            if (con == 1)
            {
                UpdProdutos up = new UpdProdutos(Codigo, textBox11.Text);
                textBox11.Text = "";
                textBox9.Text = "";
                textBox13.Text = "";
                MessageBox.Show("Alterado com sucesso");
            }
            else
            {
                CadastroProdutos cadProd = new CadastroProdutos(Codigo, textBox11.Text, Estoque);
                textBox11.Text = "";
                textBox9.Text = "";
                textBox13.Text = "";
                MessageBox.Show("cadastrado com sucesso");

            }
            
            
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid_Funcionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // mostra a linha inteira selecionada quando clica em uma celula do datagrid
            con = 1;
            //carrega informações nos campos. 
            this.Tb_CodFuncionario.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["codigo"].Value);
            this.Txt_NomeFuncionario.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Nome"].Value);
            this.Tb_UsuarioFuncionario.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Usuario"].Value);
            this.textBox3.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Senha"].Value);
            this.textBox4.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Endereco"].Value);
            this.textBox5.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Bairro"].Value);
            this.textBox6.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Cidade"].Value);
            //this.textBox7.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Telefone"].Value);
            this.textBox8.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["RG"].Value);
            this.textBox1.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["CPF"].Value);
            this.comboBox1.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Sexo"].Value);
            this.richTextBox1.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["OBS"].Value);


            Grid_Funcionario.Visible = false;
            label19.Visible = true;

        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con = 1;
            Grid_Funcionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.textBox9.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["Codigo"].Value);
            this.textBox11.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["Descricao"].Value);
            this.textBox13.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["Estoque"].Value);
            dataGridView2.Visible = false;
            label14.Visible = true;
        }
        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.label30.Text = Convert.ToString(this.dataGridView3.CurrentRow.Cells["Codigo"].Value);
            this.label28.Text = Convert.ToString(this.dataGridView3.CurrentRow.Cells["Descricao"].Value);
            this.label29.Text = Convert.ToString(this.dataGridView3.CurrentRow.Cells["Estoque"].Value);
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;


        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            label14.Visible = true;
            con = 0;
            textBox11.Text = "";
            textBox9.Text = "";
            textBox13.Text = "";
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 4;
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (con == 1)
            {
                DeletarProduto del = new DeletarProduto(int.Parse(textBox9.Text));
                MessageBox.Show("deletado com sucesso");
                con = 0;
                textBox11.Text = "";
                textBox9.Text = "";
                textBox13.Text = "";
            }
            else
                MessageBox.Show("Selecione um produto");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Nome = label28.Text;
            int Cod = int.Parse(label30.Text);
            int Est = int.Parse(label29.Text);
            int EntradaSaida = int.Parse(textBox15.Text);
            int entrada;
            String User = label12.Text;

            if (radioButton1.Checked == true)
            {
                entrada = 1;
                AtualizaEstoque att = new AtualizaEstoque(int.Parse(label30.Text), int.Parse(textBox15.Text), entrada, Nome, Est, EntradaSaida, User);
                MessageBox.Show("atualizado com sucesso");
            }
            if (radioButton2.Checked == true)
            {
                entrada = 0;
                AtualizaEstoque att = new AtualizaEstoque(int.Parse(label30.Text), int.Parse(textBox15.Text), entrada, Nome, Est, EntradaSaida, User);
                MessageBox.Show("atualizado com sucesso");
            }

            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label30.Text = "";
            textBox15.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
           
            SqlDataAdapter da;
            DataSet ds;
            SqlConnection con = new SqlConnection();
            ds = new DataSet();
            con.ConnectionString = (@"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Integrated Security = True");
            con.Open();
            da = new SqlDataAdapter("select * from rmsoft..produtos", con);
            da.Fill(ds, "all");
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = ds.Tables["all"];
            con.Close();
        }

        
    }
}

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

namespace RmSoft
{
    public partial class Principal : Form
    {
        IniFiles ini = new IniFiles(@"C:\testes\Configuração.ini");
        public string usuario { get; internal set; }
        public int con;

        public Principal()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

            xtraTabControl1.SelectedTabPageIndex = 0;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = 0;
            Txt_Nome.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "";
            textBox10.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con == 1)
            {
                if (Txt_Nome.Text == "")
                {
                    MessageBox.Show("Campo 'NOME' Obrigatorio!");
                }
                else
                {
                    UpdFuncionario up = new UpdFuncionario(textBox10.Text, Txt_Nome.Text, comboBox1.Text, textBox8.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, richTextBox1.Text);
                    MessageBox.Show("Alterado com sucesso");
                }


            }
            else
            {
                CadastroFuncionario cad = new CadastroFuncionario(textBox10.Text, Txt_Nome.Text, comboBox1.Text, textBox8.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, richTextBox1.Text);

                Txt_Nome.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                richTextBox1.Text = "";
                comboBox1.Text = "";
                textBox10.Text = "";
                MessageBox.Show("Cadastrado com sucesso");
            }

         }
            
        

      
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Visible == false)
            {
                label19.Visible = false;
                dataGridView1.Visible = true;

                SqlDataAdapter da;
                DataSet ds;
                SqlConnection con = new SqlConnection();
                ds = new DataSet();
                con.ConnectionString = (@"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Integrated Security = True");
                con.Open();
                da = new SqlDataAdapter("select * from rmsoft..Funcionario", con);
                da.Fill(ds, "all");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds.Tables["all"];
                con.Close();
            }
            else
            {
                dataGridView1.Visible = false;
                label19.Visible = true;
            }





        }

        private void button5_Click(object sender, EventArgs e)
        {
            con = 0;
            DeletarFuncionario del = new DeletarFuncionario(textBox10.Text, textBox2.Text);
            Txt_Nome.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "";
            textBox10.Text = "";
            MessageBox.Show("deletado com sucesso");


        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // mostra a linha inteira selecionada quando clica em uma celula do datagrid
            con = 1;
            //carrega informações nos campos. 
            this.textBox10.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["codigo"].Value);
            this.Txt_Nome.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nome"].Value);
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Usuario"].Value);
            this.textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Senha"].Value);
            this.textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Endereco"].Value);
            this.textBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Bairro"].Value);
            this.textBox6.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Cidade"].Value);
            //this.textBox7.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Telefone"].Value);
            this.textBox8.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["RG"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CPF"].Value);
            this.comboBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Sexo"].Value);
            this.richTextBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["OBS"].Value);


            dataGridView1.Visible = false;
            label19.Visible = true;

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

            float preco = float.Parse (textBox9.Text);
            

            MessageBox.Show(preco.ToString());
            CadastroProdutos cadProd = new CadastroProdutos(textBox11.Text,preco);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con = 1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.textBox11.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["Descricao"].Value);
            this.textBox9.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["Preco"].Value);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con = 0;
            textBox11.Text = "";
            textBox9.Text = "";
        }

   
    }
}

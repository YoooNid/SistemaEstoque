using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RmSoft
{
    public partial class Principal : Form
    {
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
            // TODO: esta linha de código carrega dados na tabela 'rmSoftDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
           
            xtraTabControl1.SelectedTabPageIndex = 2;
            label1.AutoEllipsis = true;
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Txt_Nome.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (Txt_Nome.Text == "")
            {
                MessageBox.Show  ("Campo 'NOME' Obrigatorio!");
            }
            else
            {
                Cadastro cad = new Cadastro(Txt_Nome.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                Txt_Nome.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                MessageBox.Show("Cadastrado com sucesso");

            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                

                
                //Txt_Nome.Text = Me.dataGridView.CurrentRow.Cells["Nome", e.RowIndex].Value.ToString();
                //textBox2.Text = dataGridView1["Usuario"].Value.ToString();
                //textBox3.Text = dataGridView1["Senha"].Value.ToString();
                //textBox4.Text = dataGridView1["Endereco"].Value.ToString();
                //textBox5.Text = dataGridView1["Bairro"].Value.ToString();
                //textBox6.Text = dataGridView1["Cidade"].Value.ToString();



            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            
        }
    }
}

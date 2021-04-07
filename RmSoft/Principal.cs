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
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            xtraTabControl1.SelectedTabPageIndex = 2;

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            
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
    }
}

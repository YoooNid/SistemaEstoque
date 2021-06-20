using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ArquivoIni;
using RmSoft.upd;

namespace RmSoft
{
    public partial class Principal : Form
    {
        readonly IniFiles ini = new IniFiles(@"C:\testes\Configuração.ini");
        public string usuario { get; internal set; } // pegando o usuario que foi digitado na tela de login
        public int con;  //variavel de controle para saber se o usuario selecionou o item ou nao para ser alterado,  ou incluido no banco de dados 
        


        public Principal()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

            xtraTabControl1.SelectedTabPageIndex = 0;
            con = 0;
            Tb_descricaoProd.Text = "";
            Tb_codigoProd.Text = "";
            Tb_estoque.Text = "";
        }

        private void Principal_Load(object sender, EventArgs e)


        {

            Lb_usuarioIni.Visible = true;
            Lb_usuarioIni.Text = usuario;
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            xtraTabControl1.SelectedTabPageIndex = 2;
            label1.AutoEllipsis = true;
            xtraTab_Relatorio.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            Cb_Relatorios.SelectedIndex = 0;
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            con = 0;
            Txt_NomeFuncionario.Text = "";
            Tb_Cpf.Text = "";
            Tb_UsuarioFuncionario.Text = "";
            Tb_senha.Text = "";
            Tb_endereco.Text = "";
            Tb_bairro.Text = "";
            Tb_cidade.Text = "";
            Tb_telefone.Text = "";
            Tb_rg.Text = "";
            Rtb_obs.Text = "";
            Cb_sexo.Text = "";
            Tb_CodFuncionario.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = 0;
            label19.Visible = true;
            Grid_Funcionario.Visible = false;
            Txt_NomeFuncionario.Text = "";
            Tb_Cpf.Text = "";
            Tb_UsuarioFuncionario.Text = "";
            Tb_senha.Text = "";
            Tb_endereco.Text = "";
            Tb_bairro.Text = "";
            Tb_cidade.Text = "";
            Tb_telefone.Text = "";
            Tb_rg.Text = "";
            Rtb_obs.Text = "";
            Cb_sexo.Text = "";
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
                    UpdFuncionario up = new UpdFuncionario(Tb_CodFuncionario.Text, Txt_NomeFuncionario.Text, Cb_sexo.Text, Tb_rg.Text, Tb_Cpf.Text, Tb_UsuarioFuncionario.Text, Tb_senha.Text, Tb_endereco.Text, Tb_bairro.Text, Tb_cidade.Text, Rtb_obs.Text);

                    MessageBox.Show("Alterado com sucesso");
                }


            }
            else
            {
                CadastroFuncionario cad = new CadastroFuncionario(Tb_CodFuncionario.Text, Txt_NomeFuncionario.Text, Cb_sexo.Text, Tb_rg.Text, Tb_Cpf.Text, Tb_UsuarioFuncionario.Text, Tb_senha.Text, Tb_endereco.Text, Tb_bairro.Text, Tb_cidade.Text, Rtb_obs.Text);

                Txt_NomeFuncionario.Text = "";
                Tb_Cpf.Text = "";
                Tb_UsuarioFuncionario.Text = "";
                Tb_senha.Text = "";
                Tb_endereco.Text = "";
                Tb_bairro.Text = "";
                Tb_cidade.Text = "";
                Tb_telefone.Text = "";
                Tb_rg.Text = "";
                Rtb_obs.Text = "";
                Cb_sexo.Text = "";
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


                
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection();
                SqlDataAdapter da;
                con.ConnectionString = (@"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Integrated Security = True");
                con.Open();
                da = new SqlDataAdapter("select * from rmsoft..Funcionario",con);
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
                Tb_Cpf.Text = "";
                Tb_UsuarioFuncionario.Text = "";
                Tb_senha.Text = "";
                Tb_endereco.Text = "";
                Tb_bairro.Text = "";
                Tb_cidade.Text = "";
                Tb_telefone.Text = "";
                Tb_rg.Text = "";
                Rtb_obs.Text = "";
                Cb_sexo.Text = "";
                Tb_CodFuncionario.Text = "";
                MessageBox.Show("deletado com sucesso");
                con = 0;
            }
            else
                MessageBox.Show("selecione um Funcionario");

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            Lb_Hora.Text = DateTime.Now.ToString();
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

            int Codigo = int.Parse(Tb_codigoProd.Text);
            int Estoque = int.Parse(Tb_estoque.Text);
            if (con == 1)
            {
                UpdProdutos up = new UpdProdutos(Codigo, Tb_descricaoProd.Text);
                Tb_descricaoProd.Text = "";
                Tb_codigoProd.Text = "";
                Tb_estoque.Text = "";
                MessageBox.Show("Alterado com sucesso");
            }
            else
            {
                CadastroProdutos cadProd = new CadastroProdutos(Codigo, Tb_descricaoProd.Text, Estoque);
                Tb_descricaoProd.Text = "";
                Tb_codigoProd.Text = "";
                Tb_estoque.Text = "";
                MessageBox.Show("cadastrado com sucesso");

            }
            Bt_pesquisarProd.PerformClick();


        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid_Funcionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // mostra a linha inteira selecionada quando clica em uma celula do datagrid
            con = 1;
            //carrega informações nos campos. 
            this.Tb_CodFuncionario.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["codigo"].Value);
            this.Txt_NomeFuncionario.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Nome"].Value);
            this.Tb_UsuarioFuncionario.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Usuario"].Value);
            this.Tb_senha.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Senha"].Value);
            this.Tb_endereco.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Endereco"].Value);
            this.Tb_bairro.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Bairro"].Value);
            this.Tb_cidade.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Cidade"].Value);
            //this.textBox7.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Telefone"].Value);
            this.Tb_rg.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["RG"].Value);
            this.Tb_Cpf.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["CPF"].Value);
            this.Cb_sexo.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["Sexo"].Value);
            this.Rtb_obs.Text = Convert.ToString(this.Grid_Funcionario.CurrentRow.Cells["OBS"].Value);


            Grid_Funcionario.Visible = false;
            label19.Visible = true;

        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con = 1;
            Grid_Funcionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Tb_codigoProd.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["Codigo"].Value);
            this.Tb_descricaoProd.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["Descricao"].Value);
            this.Tb_estoque.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["Estoque"].Value);
            dataGridView2.Visible = false;
            label14.Visible = true;
        }
        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Lb_CodProd.Text = Convert.ToString(this.dataGridView3.CurrentRow.Cells["Codigo"].Value);
            this.Lb_DescProd.Text = Convert.ToString(this.dataGridView3.CurrentRow.Cells["Descricao"].Value);
            this.Lb_Qnt.Text = Convert.ToString(this.dataGridView3.CurrentRow.Cells["Estoque"].Value);
            Lb_DescProd.Visible = true;
            Lb_Qnt.Visible = true;
            Lb_CodProd.Visible = true;


        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            label14.Visible = true;
            con = 0;
            Tb_descricaoProd.Text = "";
            Tb_codigoProd.Text = "";
            Tb_estoque.Text = "";
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
                DeletarProduto del = new DeletarProduto(int.Parse(Tb_codigoProd.Text));
                MessageBox.Show("deletado com sucesso");
                con = 0;
                Tb_descricaoProd.Text = "";
                Tb_codigoProd.Text = "";
                Tb_estoque.Text = "";
            }
            else
                MessageBox.Show("Selecione um produto");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Nome = Lb_DescProd.Text;
            int Cod = int.Parse(Lb_CodProd.Text);
            int Est = int.Parse(Lb_Qnt.Text);
            int EntradaSaida = int.Parse(Tb_QntProdEst.Text);
            int entrada;
            String User = Lb_usuarioIni.Text;

            if (Rb_adicionar.Checked == true)
            {
                entrada = 1;
                AtualizaEstoque att = new AtualizaEstoque(int.Parse(Lb_CodProd.Text), int.Parse(Tb_QntProdEst.Text), entrada, Nome, Est, EntradaSaida, User);
                MessageBox.Show("atualizado com sucesso");
            }
            if (Rb_remover.Checked == true)
            {
                entrada = 0;
                AtualizaEstoque att = new AtualizaEstoque(int.Parse(Lb_CodProd.Text), int.Parse(Tb_QntProdEst.Text), entrada, Nome, Est, EntradaSaida, User);
                MessageBox.Show("atualizado com sucesso");
            }


            Lb_DescProd.Visible = false;
            Lb_Qnt.Visible = false;
            Lb_CodProd.Visible = false;
            Lb_CodProd.Text = "";
            Tb_QntProdEst.Text = "";
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

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 5;

        }

        private void Cb_Relatorios_SelectedIndexChanged(object sender, EventArgs e)
        {

            string rel = Cb_Relatorios.Text.Substring(0, 2);

            switch (rel)
            {
                case "01":
                    xtraTab_Relatorio.SelectedTabPageIndex = 0;
                    //classe de relatorios para listagem de produtos
                    break;

                case "02":
                    xtraTab_Relatorio.SelectedTabPageIndex = 1;
                    //classe de relatorios para listagem de funcionarios
                    break;
                case "03":
                    xtraTab_Relatorio.SelectedTabPageIndex = 2;
                    //classe para listagem de alterações feitas
                    break;


            }

        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 6;
        }

        private void Bt_PesquisarGrupo_Click(object sender, EventArgs e)
        {
            Grid_Grupos.Visible = true;

            SqlDataAdapter da;
            DataSet ds;
            SqlConnection con = new SqlConnection();
            ds = new DataSet();
            con.ConnectionString = (@"Data Source = " + ini.IniReadValue("DATABASE", "SERVIDOR") + "; Integrated Security = True");
            con.Open();
            da = new SqlDataAdapter("select * from rmsoft..Grupos", con);
            da.Fill(ds, "all");
            Grid_Grupos.DataSource = null;
            Grid_Grupos.DataSource = ds.Tables["all"];
            con.Close();
        }

        private void Bt_LimparGrupo_Click(object sender, EventArgs e)
        {
            con = 0;
            Tb_CodGrupo.Text = "";
            Tb_DescGrupo.Text = "";

        }

        private void Bt_SalvarGrupo_Click(object sender, EventArgs e)
        {

            CadastroGrupos cad = new CadastroGrupos(int.Parse(Tb_CodGrupo.Text), Tb_DescGrupo.Text, con);
            Tb_CodGrupo.Text = "";
            Tb_DescGrupo.Text = "";
            if (con == 1)
                MessageBox.Show("Alterado com sucesso");
            else
                MessageBox.Show("cadastrado com sucesso");
            Bt_PesquisarGrupo.PerformClick();

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            con = 1;
            Grid_Grupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Tb_CodGrupo.Text = Convert.ToString(this.Grid_Grupos.CurrentRow.Cells["Cod_grupo"].Value);
            this.Tb_DescGrupo.Text = Convert.ToString(this.Grid_Grupos.CurrentRow.Cells["Descricao"].Value);
            Grid_Grupos.Visible = false;
        }

        private void Bt_ExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (con == 1)
            {
                DeletarGrupo Del = new DeletarGrupo(int.Parse(Tb_CodGrupo.Text));
                Tb_CodGrupo.Text = "";
                Tb_DescGrupo.Text = "";
                MessageBox.Show("Grupo deletado com sucesso");
                con = 0;
                Bt_PesquisarGrupo.PerformClick();

            }
            else
                MessageBox.Show("Selecione um grupo");
        }

        private void Bt_ImprimirRelProd_Click(object sender, EventArgs e)
        {
            Relatorios.Frm_produtos rel = new Relatorios.Frm_produtos();
            rel.Show();
        }
    }
}

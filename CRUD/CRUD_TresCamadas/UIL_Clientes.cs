using System;
using System.Windows.Forms;

namespace CRUD_TresCamadas
{
    public partial class UIL_Clientes : Form
    {
        public UIL_Clientes()
        {
            InitializeComponent();
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            btPesquisar.Enabled = true;
            if (tbPesquisar.Text == "")
            {
                btPesquisar.Enabled = false;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            
            tbNome.Enabled = true;
            tbNome.Focus();
            tbPesquisar.Clear();

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Modelo_Cliente obj_cliente = new Modelo_Cliente();

            obj_cliente.Nome = tbNome.Text;

            try
            {
                BLL_Cliente bllCli = new BLL_Cliente();

                bllCli.GravaClienteDAL(obj_cliente);

                povoa_grade();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            tbNome.Enabled = false;
            tbNome.Clear();
            tbPesquisar.Enabled = true;
            tbPesquisar.Focus();
            btGravar.Enabled = false;
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            btGravar.Enabled = true;

            if (tbNome.Text == "")
            {
                btGravar.Enabled = false;
            }
        }

        private void btLeitura_Click(object sender, EventArgs e)
        {
            BLL_Cliente cliBll = null;

            try
            {
                cliBll= new BLL_Cliente();
                dgvListarDados.DataSource = cliBll.listaClienteDal();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na listagem de clientes: " + erro);
            }
        }

        private void UIL_Clientes_Load(object sender, EventArgs e)
        {
            povoa_grade();
        }

        public void povoa_grade()
        {
            try
            {
                BLL_Cliente cliBll = new BLL_Cliente();
                dgvListarDados.DataSource = cliBll.listaClienteDal();


            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Modelo_Cliente obj_cliente = new Modelo_Cliente();

            obj_cliente.Codigo = int.Parse(tbCodigo.Text);

            obj_cliente.Nome = tbNome.Text;

            try
            {
                BLL_Cliente bllCli = new BLL_Cliente();
                bllCli.AtualizarClienteDAL(obj_cliente);

                MessageBox.Show("Cliente Alterado com Sucesso!");
                povoa_grade();

            }
            catch (Exception erro)
            {

                throw erro;
            }

            povoa_grade();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Modelo_Cliente obj_cliente = new Modelo_Cliente();

            obj_cliente.Codigo = int.Parse(tbCodigo.Text);

            try
            {
                BLL_Cliente bllCli = new BLL_Cliente();
                bllCli.ExcluiClienteDAL(obj_cliente);

                povoa_grade();

            }
            catch (Exception erro)
            {

                throw erro;
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = tbPesquisar.Text;


            Modelo_Cliente obj_cliente = new Modelo_Cliente();

            try
            {
                BLL_Cliente bll_Cliente = new BLL_Cliente();
                obj_cliente = bll_Cliente.pesquisaClienteDal(pesquisa);

                tbCodigo.Text = obj_cliente.Codigo.ToString();
                tbNome.Text = obj_cliente.Nome;


            }
            catch (Exception erro)
            {

               MessageBox.Show("Erro ao pesquisar o cliente: " + erro);
            }
        }

        private void dgvListarDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           btGravar_Click(sender, e);
            povoa_grade();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btAtualizar_Click(sender, e);
            povoa_grade();
        }
    }
}

using System;
using System.Data;

namespace CRUD_TresCamadas
{
    class BLL_Cliente
    {
        DAL_Cliente dalcli = null;

        public DataTable listaClienteDal()
        {
            DataTable dt = new DataTable();

            try
            {
                dalcli = new DAL_Cliente();
                dt = dalcli.listaclientes();
            }
            catch (Exception erro)
            {

                throw erro;
            }

            return dt;
        }

        public void GravaClienteDAL(Modelo_Cliente cliente)
        {
            try
            {
                dalcli = new DAL_Cliente();
                dalcli.GravaCliente(cliente);

            }
            catch (Exception erro)
            {

                throw erro;
            }

        }

        public void ExcluiClienteDAL(Modelo_Cliente cliente)
        {
            try
            {
                dalcli = new DAL_Cliente();
                dalcli.excluiCliente(cliente);

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void AtualizarClienteDAL(Modelo_Cliente cliente)
        {
            try
            {
                dalcli = new DAL_Cliente();
                dalcli.atualizaCliente(cliente);

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }


        public Modelo_Cliente pesquisaClienteDal(string pesquisa)
        {
            try
            {
                dalcli = new DAL_Cliente();

                return dalcli.pesquisaCliente(pesquisa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

    }
}

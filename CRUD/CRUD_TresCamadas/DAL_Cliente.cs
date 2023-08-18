using System;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_TresCamadas
{
    internal class DAL_Cliente
    {
        string con_SQLServer = @"Data Source = .\SQLEXPRESS; Initial Catalog = Academia2023; User id = sa;
        pwd = sa;";

        SqlConnection conexao = null;

        public DataTable listaclientes()
        {
            try
            {
                conexao = new SqlConnection(con_SQLServer);
                SqlCommand sql = new SqlCommand("SELECT * FROM tbCliente", conexao);

                SqlDataAdapter daCliente = new SqlDataAdapter();

                daCliente.SelectCommand = sql;

                DataTable dtCliente = new DataTable();
                daCliente.Fill(dtCliente);
                return dtCliente;

            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally {
                conexao.Close();
            }
        }


        public void GravaCliente(Modelo_Cliente cliente) 
        {
            try
            {
                conexao= new SqlConnection(con_SQLServer);
                SqlCommand sql = new SqlCommand("INSERT INTO tbCliente values (@NomeCliente)", conexao);

                sql.Parameters.AddWithValue("@NomeCliente", cliente.Nome);

                conexao.Open();

                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void excluiCliente(Modelo_Cliente cliente)
        {
            try
            {
                conexao = new SqlConnection(con_SQLServer);
                SqlCommand sql = new SqlCommand("DELETE FROM tbCliente WHERE idCliente = @idCliente", conexao);

                sql.Parameters.AddWithValue("@idCliente", cliente.Codigo);

                conexao.Open();

                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void atualizaCliente(Modelo_Cliente cliente)
        {
            try
            {
                conexao = new SqlConnection(con_SQLServer);
                SqlCommand sql = new SqlCommand("UPDATE tbCliente SET nome = @NomeCliente WHERE idCliente = @idCliente", conexao);

                sql.Parameters.AddWithValue("@idCliente", cliente.Codigo);
                sql.Parameters.AddWithValue("@NomeCliente", cliente.Nome);

                conexao.Open();

                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public Modelo_Cliente pesquisaCliente(string pesquisa)
        {
            try
            {
                conexao = new SqlConnection(con_SQLServer);

                SqlCommand sql = new SqlCommand("SELECT * FROM tbCliente WHERE nome like '" + pesquisa +"%'", conexao);

                sql.Parameters.AddWithValue("@pesquisa", pesquisa);

                conexao.Open();

                SqlDataReader drPesquisa;

                Modelo_Cliente modCli = new Modelo_Cliente();

                drPesquisa= sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (drPesquisa.Read())
                {

                    modCli.Codigo = Convert.ToInt16(drPesquisa["idCliente"]);
                    modCli.Nome = drPesquisa["nome"].ToString();

                }

                return modCli;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}

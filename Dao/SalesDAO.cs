using MySql.Data.MySqlClient;
using ProjetoVendas.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVendas.Dao
{
    internal class SalesDAO
    {
        private MySqlConnection connection;

        public SalesDAO()
        {
            this.connection = new ConnectionCreation().getConnection();
        }

        public void createSale(Models.Sales sales)
        {
            try
            {;
                string sqlCommand = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                                    values(@customer_id, sales_date, total_sales, @details_sales)";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@customer_id", sales.cliente_id);
                executeCMD.Parameters.AddWithValue("@sales_date", sales.sale_date);
                executeCMD.Parameters.AddWithValue("@total_sales", sales.total_sales);
                executeCMD.Parameters.AddWithValue("@details_sales", sales.obs);

                connection.Open();
                executeCMD.ExecuteNonQuery();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }

        }

        public int returnLastId()
        {
            try
            {
                int lastId = 0;
                string sqlCommand = @"select max(id) id from tb_vendas";
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);


                connection.Open();
                
                MySqlDataReader reader = executeCMD.ExecuteReader();

                if (reader.Read())
                {
                    lastId = reader.GetInt32("id");
                }
                    return lastId;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                return 0;
            }
            finally {
                connection.Close();
            }
        }

        public DataTable showSalesPerPeriod(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tableHistory = new DataTable();
                string sqlCommand = @"select v.id as 'Código', 
                                    v.data_venda as 'Data da Venda', 
                                    c.nome as 'Cliente', 
                                    v.total_venda as 'Total', 
                                    v.observacoes as 'Obs' 
                                    from tb_vendas as v 
                                    join tb_clientes as c on (v.cliente_id = c.id)
                                    where v.data_venda between @datainicio and @datafim";
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@datainicio", datainicio);
                executeCMD.Parameters.AddWithValue("@datafim", datafim);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(executeCMD);
                adapter.Fill(tableHistory);
                return tableHistory;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable showAllSales()
        {
            try
            {
                DataTable tableHistory = new DataTable();
                string sqlCommand = @"select v.id as 'Código', 
                                    v.data_venda as 'Data da Venda', 
                                    c.nome as 'Cliente', 
                                    v.total_venda as 'Total', 
                                    v.observacoes as 'Obs' 
                                    from tb_vendas as v 
                                    join tb_clientes as c on (v.cliente_id = c.id)";
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(executeCMD);
                adapter.Fill(tableHistory);
                return tableHistory;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}

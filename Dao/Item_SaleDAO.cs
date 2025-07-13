using MySql.Data.MySqlClient;
using ProjetoVendas.Connection;
using ProjetoVendas.Models;
using ProjetoVendas.Screens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVendas.Dao
{
    internal class Item_SaleDAO
    {
        private MySqlConnection connection;

        public Item_SaleDAO()
        {
            this.connection = new ConnectionCreation().getConnection();
        }

        public void createNewItem(Models.SoldItems sale)
        {
            try
            {
                string sqlCommand = @"insert into tb_vendas (venda_id, produto_id, qtd, subtotal)
                                    values(@sale_id, @product_id, @quantity, @subtotal)";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@venda_id", sale.venda_id);
                executeCMD.Parameters.AddWithValue("@produto_id", sale.produto_id);
                executeCMD.Parameters.AddWithValue("@qtd", sale.qtd);
                executeCMD.Parameters.AddWithValue("@subtotal", sale.subtotal);

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

        public DataTable showAllItemsPerSales(int venda_id)
        {
            try
            {
                DataTable tableItems = new DataTable();
                string sqlCommand = @"select i.id as 'Código',
                                    p.descricao as 'Descrição',
                                    i.qtd as 'Quantidade',
                                    p.preco as 'Preço',
                                    i.subtotal as 'Subtotal'
                                    FROM tb_itensvendas as i join
                                    tb_produtos as p on (i.produto_id = p.id)
                                    where venda_id = @venda_id";                        
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@venda_id", venda_id);
                
                connection.Open();
                executeCMD.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(executeCMD);
                adapter.Fill(tableItems);
                return tableItems;
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

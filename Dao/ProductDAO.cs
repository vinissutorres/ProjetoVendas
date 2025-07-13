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
    internal class ProductDAO
    {
        private MySqlConnection connection;

        public ProductDAO()
        {
            this.connection = new ConnectionCreation().getConnection();
        }

        public void createProduct(Models.Products product)
        {
            try
            {
                string sqlCommand = @"INSERT INTO tb_produtos
                (descricao, preco, qtd_estoque, for_id) 
                VALUES (@description, @price, @quantity, @supplierID)";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("@description", product.Description);
                executeCMD.Parameters.AddWithValue("@price", product.Price);
                executeCMD.Parameters.AddWithValue("@quantity", product.Quantity);
                executeCMD.Parameters.AddWithValue("@supplierID", product.for_id);

                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso.");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                this.connection.Close();
            }
        }

        public DataTable showProducts()
        {
            try
            {
                //criou tabela
                DataTable productTable = new DataTable();
                string sqlCommand = @"select tb_produtos.id as 'Código', tb_produtos.descricao as 'Descrição', 
                                    tb_produtos.preco as 'Preço', tb_produtos.qtd_estoque as 'Qtde. Estoque', 
                                    tb_fornecedores.nome as 'Fornecedor' 
                                    from tb_produtos
                                    join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id)";

                //nao precisa passar parametros, chama o comando
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                //preenche os dados
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(productTable);

                return productTable;
            }
            catch (Exception Error)
            {

                MessageBox.Show("Erro:" + Error);
                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        public void updateProduct(Models.Products product)
        {
            try
            {
                string sqlCommand = @"UPDATE tb_produtos
                set descricao=@description, preco=@price, qtd_estoque=@quantity, for_id=@supplierID where id=@id";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("@description", product.Description);
                executeCMD.Parameters.AddWithValue("@price", product.Price);
                executeCMD.Parameters.AddWithValue("@quantity", product.Quantity);
                executeCMD.Parameters.AddWithValue("@supplierID", product.for_id);
                executeCMD.Parameters.AddWithValue("@id", product.Id);

                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Produto atualizado com sucesso.");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                this.connection.Close();
            }
        }

        public void deleteProduct(Models.Products product)
        {
            try
            {
                string sqlCommand = @"delete from tb_produtos where id=@id";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("@id", product.Id);

                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Produto removido com sucesso.");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                this.connection.Close();
            }
        }

        public DataTable showProductsByName(string nome)
        {
            try
            {
                //criou tabela
                DataTable productTable = new DataTable();
                string sqlCommand = @"select tb_produtos.id as 'Código', tb_produtos.descricao as 'Descrição', 
                                    tb_produtos.preco as 'Preço', tb_produtos.qtd_estoque as 'Qtde. Estoque', 
                                    tb_fornecedores.nome as 'Fornecedor' 
                                    from tb_produtos
                                    join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id) where tb_produtos.descricao like @nome";

                //nao precisa passar parametros, chama o comando
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@nome", nome);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                //preenche os dados
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(productTable);

                return productTable;
            }
            catch (Exception Error)
            {

                MessageBox.Show("Erro:" + Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable searchProductsByName(string nome)
        {
            try
            {
                //criou tabela
                DataTable productTable = new DataTable();
                string sqlCommand = @"select tb_produtos.id as 'Código', tb_produtos.descricao as 'Descrição', 
                                    tb_produtos.preco as 'Preço', tb_produtos.qtd_estoque as 'Qtde. Estoque', 
                                    tb_fornecedores.nome as 'Fornecedor' 
                                    from tb_produtos
                                    join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id) where tb_produtos.descricao = @nome";

                //nao precisa passar parametros, chama o comando
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@nome", nome);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                //preenche os dados
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(productTable);

                return productTable;
            }
            catch (Exception Error)
            {

                MessageBox.Show("Erro:" + Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public Models.Products searchProductsByCode(int id)
        {
            try
            {
                string sqlCommand = @"select * from tb_produtos where id=@id";
                MySqlCommand executeCmd = new MySqlCommand(sqlCommand, connection);
                executeCmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader reader = executeCmd.ExecuteReader();

                if (reader.Read())
                {
                    Models.Products products = new Models.Products();
                    products.Id = reader.GetInt32("id");
                    products.Description = reader.GetString("descricao");
                    products.Price = reader.GetDecimal("preco");
                    return products;

                }
                else
                {
                    MessageBox.Show("Nada foi encontrado");
                    return null;
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro);

                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        public void minusOneProduct(int idproduto, int qtde_estoque)
        {
            try
            {
                string sqlCommand = @"update tb_produtos set qtd_estoque=@qtd where id=@id";
                MySqlCommand executeCmd = new MySqlCommand(sqlCommand, connection);
                executeCmd.Parameters.AddWithValue("@qtd", qtde_estoque);
                executeCmd.Parameters.AddWithValue("@id", idproduto);
                connection.Open();
                executeCmd.ExecuteNonQuery();

            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.ToString());
            }
            finally
            {
                connection.Close();
            }

        }

        public int returnQuantityProducts(int idproduto)
        {
            try
            {
                string sqlCommand = "@select qtd_estoque from tb_produtos where id=@id";
                int qtd_estoque = 0;
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@id", idproduto);
                connection.Open();
                MySqlDataReader reader = executeCMD.ExecuteReader();
                if (reader.Read())
                {
                    qtd_estoque = reader.GetInt32("qtd_estoque");
                }
                return qtd_estoque;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
                return 0;

            }
            finally
            {
                connection.Close();
            }
        }
    }
}

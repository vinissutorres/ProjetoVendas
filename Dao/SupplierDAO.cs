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
    internal class SupplierDAO
    {

        private MySqlConnection connection;

        public SupplierDAO()
        {
            this.connection = new ConnectionCreation().getConnection();
        }

        public void createSupplier(Supplier supplier)
        {
            try
            {
                string sqlCommand = @"INSERT INTO tb_fornecedores
                (nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                VALUES 
                (@name, @cnpj, @email, @phone, @cellular, @zipcode, @address, @number, @details, @neighbourhood, @city, @state)";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("@name", supplier.Name);
                executeCMD.Parameters.AddWithValue("@cnpj", supplier.CNPJ);
                executeCMD.Parameters.AddWithValue("@email", supplier.Email);
                executeCMD.Parameters.AddWithValue("@phone", supplier.Phone);
                executeCMD.Parameters.AddWithValue("@cellular", supplier.cellPhone);
                executeCMD.Parameters.AddWithValue("@zipcode", supplier.zipCode);
                executeCMD.Parameters.AddWithValue("@address", supplier.Address);
                executeCMD.Parameters.AddWithValue("@number", supplier.houseNumber);
                executeCMD.Parameters.AddWithValue("@details", supplier.Details);
                executeCMD.Parameters.AddWithValue("@neighbourhood", supplier.Neighbourhood);
                executeCMD.Parameters.AddWithValue("@city", supplier.City);
                executeCMD.Parameters.AddWithValue("@state", supplier.State);

                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Fornecedor cadastrado com sucesso.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + error.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable showSuppliers()
        {
            try
            {
                //criou tabela
                DataTable dataGridSupplier = new DataTable();
                string sqlCommand = "select * from tb_fornecedores";

                //nao precisa passar parametros, chama o comando
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                //preenche os dados
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(dataGridSupplier);

                return dataGridSupplier;
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

        public void updateSupplier(Supplier supplier)
        {
            try
            {
                string sqlCommand = @"update tb_fornecedores set nome=@name, cnpj=@cnpj, email=@email, telefone=@phone, celular=@cellular, cep=@zipcode, endereco=@address, numero=@number, complemento=@details, bairro=@neighbourhood, cidade=@city, estado=@state where id = @id";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("id", supplier.Id);
                executeCMD.Parameters.AddWithValue("@name", supplier.Name);
                executeCMD.Parameters.AddWithValue("@cnpj", supplier.CNPJ);
                executeCMD.Parameters.AddWithValue("@email", supplier.Email);
                executeCMD.Parameters.AddWithValue("@phone", supplier.Phone);
                executeCMD.Parameters.AddWithValue("@cellular", supplier.cellPhone);
                executeCMD.Parameters.AddWithValue("@zipcode", supplier.zipCode);
                executeCMD.Parameters.AddWithValue("@address", supplier.Address);
                executeCMD.Parameters.AddWithValue("@number", supplier.houseNumber);
                executeCMD.Parameters.AddWithValue("@details", supplier.Details);
                executeCMD.Parameters.AddWithValue("@neighbourhood", supplier.Neighbourhood);
                executeCMD.Parameters.AddWithValue("@city", supplier.City);
                executeCMD.Parameters.AddWithValue("@state", supplier.State);

                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Fornecedor alterado.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + error.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void removeSupplier(Supplier supplier)
        {
            try
            {
                string sqlCommand = @"delete from tb_fornecedores where id = @id";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("id", supplier.Id);

                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Cliente removido.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao remover fornecedor: " + error.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable searchSuppliersByNameWhileTyping(string nome)
        {
            try
            {
       
                DataTable dataGridSupplier = new DataTable();
                string sqlCommand = "select * from tb_fornecedores where nome like @nome";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@nome", nome);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(dataGridSupplier);

                return dataGridSupplier;
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

        public DataTable searchSuppliersByName(string nome)
        {
            try
            {

                DataTable dataGridSupplier = new DataTable();
                string sqlCommand = "select * from tb_fornecedores where nome = @nome";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@nome", nome);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(dataGridSupplier);

                return dataGridSupplier;
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


    }
}

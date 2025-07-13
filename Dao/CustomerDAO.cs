using MySql.Data.MySqlClient;
using ProjetoVendas.Connection;
using ProjetoVendas.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoVendas.Dao
{
    public class CustomerDAO
    {
        private MySqlConnection connection;

        public CustomerDAO()
        {
            this.connection = new ConnectionCreation().getConnection();
        }

        public void createCustomer(Customer customer)
        {
            try
            {
                string sqlCommand = @"INSERT INTO tb_clientes 
                (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                VALUES 
                (@name, @rg, @cpf, @email, @phone, @cellular, @zipcode, @address, @number, @details, @neighbourhood, @city, @state)";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("@name", customer.Name);
                executeCMD.Parameters.AddWithValue("@rg", customer.RG);
                executeCMD.Parameters.AddWithValue("@cpf", customer.CPF);
                executeCMD.Parameters.AddWithValue("@email", customer.Email);
                executeCMD.Parameters.AddWithValue("@phone", customer.Phone);
                executeCMD.Parameters.AddWithValue("@cellular", customer.cellPhone);
                executeCMD.Parameters.AddWithValue("@zipcode", customer.zipCode);
                executeCMD.Parameters.AddWithValue("@address", customer.Address);
                executeCMD.Parameters.AddWithValue("@number", customer.houseNumber);
                executeCMD.Parameters.AddWithValue("@details", customer.Details);
                executeCMD.Parameters.AddWithValue("@neighbourhood", customer.Neighbourhood);
                executeCMD.Parameters.AddWithValue("@city", customer.City);
                executeCMD.Parameters.AddWithValue("@state", customer.State);

                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + error.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable showCustomers()
        {
            try
            {
                //criou tabela
                DataTable customerTable = new DataTable();
                string sqlCommand = "select * from tb_clientes";

                //nao precisa passar parametros, chama o comando
                MySqlCommand executeCMD =  new MySqlCommand(sqlCommand, connection);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                //preenche os dados
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(customerTable);

                return customerTable;
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

        public DataTable lookForCustomersByName(String name)
        {
            try
            {
                DataTable customerTable = new DataTable();
                string sqlCommand = "select * from tb_clientes where nome = @name";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@name", name);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(customerTable);

                return customerTable;
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


        public DataTable listCustomersByName(String name)
        {
            try
            {
                DataTable customerTable = new DataTable();
                string sqlCommand = "select * from tb_clientes where nome like @name";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@name", name);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(customerTable);

                return customerTable;
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


        public void updateCustomer(Customer customer)
        {
            try
            {
                string sqlCommand = @"update tb_clientes
                (nome=@name, rg=@rg, cpf=@cpf, email=@email, telefone=@phone, celular=@cellular, cep=@zipcode, endereco=@address, numero=@number, complemento=@details, bairro=@neighbourhood, cidade=@city, estado=@state)
                where id = @id";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("id", customer.Id);
                executeCMD.Parameters.AddWithValue("@name", customer.Name);
                executeCMD.Parameters.AddWithValue("@rg", customer.RG);
                executeCMD.Parameters.AddWithValue("@cpf", customer.CPF);
                executeCMD.Parameters.AddWithValue("@email", customer.Email);
                executeCMD.Parameters.AddWithValue("@phone", customer.Phone);
                executeCMD.Parameters.AddWithValue("@cellular", customer.cellPhone);
                executeCMD.Parameters.AddWithValue("@zipcode", customer.zipCode);
                executeCMD.Parameters.AddWithValue("@address", customer.Address);
                executeCMD.Parameters.AddWithValue("@number", customer.houseNumber);
                executeCMD.Parameters.AddWithValue("@details", customer.Details);
                executeCMD.Parameters.AddWithValue("@neighbourhood", customer.Neighbourhood);
                executeCMD.Parameters.AddWithValue("@city", customer.City);
                executeCMD.Parameters.AddWithValue("@state", customer.State);

                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + error.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void removeCustomer(Customer customer)
        {
            try
            {
                string sqlCommand = @"delete from tb_clientes where id = @id";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);

                executeCMD.Parameters.AddWithValue("id", customer.Id);
               
                connection.Open();
                executeCMD.ExecuteNonQuery();
                MessageBox.Show("Cliente removido.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao remover cliente: " + error.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public Customer searchCustomerByCPF(string cpf)
        {
            try
            {
                Customer customer = new Customer();
                string sqlCommand = @"select * from tb_clientes where cpf=@cpf";
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@cpf", cpf);
                connection.Open();
                MySqlDataReader reader = executeCMD.ExecuteReader();

                if (reader.Read())
                {
                    customer.Id = reader.GetInt32("id");
                    customer.Name = reader.GetString("nome");
                    return customer;
                }
                else
                {
                    MessageBox.Show("Não encontrado.");
                    return null;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: " + error);
                throw;
            }
            finally
            {
                connection.Close();
            }

        }



    }
}

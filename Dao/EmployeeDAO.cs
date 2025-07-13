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
    internal class EmployeeDAO
    {
        private MySqlConnection connection;

        public EmployeeDAO()
        {
            this.connection = new ConnectionCreation().getConnection();
        }

        public void createEmployee(Employee employee)
        {
            try
            {
                string sqlCommand = @"INSERT INTO tb_funcionarios
            (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
            VALUES
            (@name, @rg, @cpf, @email, @password, @occupation, @accesslevel, @phone, @cellphone, @zipcode, @address, @housenumber, @details, @neighbourhood, @city, @state)";

                using (MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection))
                {
                    executeCMD.Parameters.AddWithValue("@name", employee.Name);
                    executeCMD.Parameters.AddWithValue("@rg", employee.RG);
                    executeCMD.Parameters.AddWithValue("@cpf", employee.CPF);
                    executeCMD.Parameters.AddWithValue("@email", employee.Email);
                    executeCMD.Parameters.AddWithValue("@password", employee.Password);
                    executeCMD.Parameters.AddWithValue("@occupation", employee.Occupation);
                    executeCMD.Parameters.AddWithValue("@accesslevel", employee.AccessLevel);
                    executeCMD.Parameters.AddWithValue("@phone", employee.Phone);
                    executeCMD.Parameters.AddWithValue("@cellphone", employee.cellPhone);
                    executeCMD.Parameters.AddWithValue("@zipcode", employee.zipCode);
                    executeCMD.Parameters.AddWithValue("@address", employee.Address);
                    executeCMD.Parameters.AddWithValue("@housenumber", employee.houseNumber);
                    executeCMD.Parameters.AddWithValue("@details", employee.Details);
                    executeCMD.Parameters.AddWithValue("@neighbourhood", employee.Neighbourhood);
                    executeCMD.Parameters.AddWithValue("@city", employee.City);
                    executeCMD.Parameters.AddWithValue("@state", employee.State);

                    connection.Open();
                    executeCMD.ExecuteNonQuery();
                    MessageBox.Show("Colaborador cadastrado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar colaborador:\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable showEmployees()
        {
            try
            {
                //criou tabela
                DataTable dataGridEmployee = new DataTable();
                string sqlCommand = "select * from tb_funcionarios";

                //nao precisa passar parametros, chama o comando
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                //preenche os dados
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(dataGridEmployee);

                return dataGridEmployee;
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

        public void updateEmployees(Employee employee)
        {
            try
            {
                string sqlCommand = "update tb_funcionarios set nome=@name, rg=@rg, cpf=@cpf, email=@email, senha=@password, cargo=@occupation, nivel_acesso=@accesslevel, telefone=@phone, celular=@cellphone, cep=@zipcode, endereco=@address, numero=@housenumber, complemento=@details, bairro=@neighbourhood, cidade=@city, estado=@state where id = @id";

                using (MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection))
                {
                    executeCMD.Parameters.AddWithValue("@name", employee.Name);
                    executeCMD.Parameters.AddWithValue("@rg", employee.RG);
                    executeCMD.Parameters.AddWithValue("@cpf", employee.CPF);
                    executeCMD.Parameters.AddWithValue("@email", employee.Email);
                    executeCMD.Parameters.AddWithValue("@password", employee.Password);
                    executeCMD.Parameters.AddWithValue("@occupation", employee.Occupation);
                    executeCMD.Parameters.AddWithValue("@accesslevel", employee.AccessLevel);
                    executeCMD.Parameters.AddWithValue("@phone", employee.Phone);
                    executeCMD.Parameters.AddWithValue("@cellphone", employee.cellPhone);
                    executeCMD.Parameters.AddWithValue("@zipcode", employee.zipCode);
                    executeCMD.Parameters.AddWithValue("@address", employee.Address);
                    executeCMD.Parameters.AddWithValue("@housenumber", employee.houseNumber);
                    executeCMD.Parameters.AddWithValue("@details", employee.Details);
                    executeCMD.Parameters.AddWithValue("@neighbourhood", employee.Neighbourhood);
                    executeCMD.Parameters.AddWithValue("@city", employee.City);
                    executeCMD.Parameters.AddWithValue("@state", employee.State);
                    executeCMD.Parameters.AddWithValue("@id", employee.Id);

                    connection.Open();
                    executeCMD.ExecuteNonQuery();
                    MessageBox.Show("Colaborador atualizado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar colaborador:\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public void deleteEmployees(Employee employee)
        {
            try
            {
                string sqlCommand = "delete from tb_funcionarios where id = @id";

                using (MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection))
                {
                   
                    executeCMD.Parameters.AddWithValue("@id", employee.Id);

                    connection.Open();
                    executeCMD.ExecuteNonQuery();
                    MessageBox.Show("Colaborador removido com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover colaborador:\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable searchEmployeesByName(string Nome)
        {
            try
            {
                //criou tabela
                DataTable dataGridEmployee = new DataTable();
                string sqlCommand = "select * from tb_funcionarios where nome = @nome";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@nome", Nome);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                //preenche os dados
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(dataGridEmployee);

                return dataGridEmployee;
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

        public DataTable searchEmployeesByNameWhileTyping(string Nome)
        {
            try
            {
                //criou tabela
                DataTable dataGridEmployee = new DataTable();
                string sqlCommand = "select * from tb_funcionarios where nome like @nome";

                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@nome", Nome);
                connection.Open();
                executeCMD.ExecuteNonQuery();

                //preenche os dados
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executeCMD);
                dataAdapter.Fill(dataGridEmployee);

                return dataGridEmployee;
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

        public bool Login(string mail, string password)
        {
            try
            {
                string sqlCommand = @"select * from tb_funcionarios where email=@mail and senha=@password";
                MySqlCommand executeCMD = new MySqlCommand(sqlCommand, connection);
                executeCMD.Parameters.AddWithValue("@mail", mail);
                executeCMD.Parameters.AddWithValue("@password", password);

                connection.Open();
                MySqlDataReader reader = executeCMD.ExecuteReader();
                if (reader.Read()) {

                    Screens.MainMenu screen = new Screens.MainMenu();
                    string accessLevel = reader.GetString("nivel_acesso");
                    string name = reader.GetString("nome");
                    screen.currentUser.Text = name;

                    if (accessLevel.Equals("Administrador"))
                    {
                        screen.Show();
                    }
                    else if(accessLevel.Equals("Vendedor"))
                    {
                       screen.produtosToolStripMenuItem.Enabled = false;
                       screen.historyOption.Enabled = false;
                       screen.Show();
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos");
                    return false;

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro:" + error);
                return false;
            }
        }

    }
}

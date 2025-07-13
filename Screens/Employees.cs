using ProjetoVendas.Dao;
using ProjetoVendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVendas.Screens
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void comboAccess_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();

                employee.Name = textEmployeeName.Text;
                employee.Email = textEmployeeMail.Text;
                employee.RG = textEmployeeRG.Text;
                employee.CPF = textEmployeeCPF.Text;

                employee.Occupation = comboBoxOccupation.SelectedItem?.ToString() ?? "";
                employee.AccessLevel = comboAccess.SelectedItem?.ToString() ?? "";
                employee.State = comboEmployeeState.SelectedItem?.ToString() ?? "";

                employee.Password = textEmployeePassword.Text;
                employee.Phone = textEmployeePhone.Text;
                employee.cellPhone = textEmployeeCellPhone.Text;
                employee.zipCode = textEmployeeZipCode.Text;
                employee.Address = textEmployeeAddress.Text;
                employee.City = textEmployeeCity.Text;
                employee.Neighbourhood = textEmployeeNeighbourhood.Text;
                employee.Details = textEmployeeDetails.Text;

                if (!int.TryParse(textEmployeeHouseNumber.Text, out int houseNumber))
                {
                    MessageBox.Show("Número da casa inválido.");
                    return;
                }
                employee.houseNumber = houseNumber;

                EmployeeDAO employeeDAO = new EmployeeDAO();
                employeeDAO.createEmployee(employee);

                dataGridEmployee.DataSource = employeeDAO.showEmployees();

                Helpers helper = new Helpers();
                helper.cleanScreen(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar funcionário: " + ex.Message);
            }
        }

        private void dataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Employees_Load_1(object sender, EventArgs e)
        {
            dataGridEmployee.DefaultCellStyle.ForeColor = Color.Black;
            EmployeeDAO employeeDAO = new EmployeeDAO();
            dataGridEmployee.DataSource = employeeDAO.showEmployees();
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textEmployeeID.Text = dataGridEmployee.CurrentRow.Cells[0].Value.ToString();
            textEmployeeName.Text = dataGridEmployee.CurrentRow.Cells[1].Value.ToString();
            textEmployeeCPF.Text = dataGridEmployee.CurrentRow.Cells[3].Value.ToString();
            textEmployeeMail.Text = dataGridEmployee.CurrentRow.Cells[4].Value.ToString();
            textEmployeeRG.Text = dataGridEmployee.CurrentRow.Cells[2].Value.ToString();
            textEmployeePassword.Text = dataGridEmployee.CurrentRow.Cells[5].Value.ToString();
            comboBoxOccupation.Text = dataGridEmployee.CurrentRow.Cells[6].Value.ToString();
            comboAccess.Text = dataGridEmployee.CurrentRow.Cells[7].Value.ToString();
            textEmployeePhone.Text = dataGridEmployee.CurrentRow.Cells[8].Value.ToString();
            textEmployeeCellPhone.Text = dataGridEmployee.CurrentRow.Cells[9].Value.ToString();
            textEmployeeAddress.Text = dataGridEmployee.CurrentRow.Cells[11].Value.ToString();
            textEmployeeZipCode.Text = dataGridEmployee.CurrentRow.Cells[10].Value.ToString();
            textEmployeeHouseNumber.Text = dataGridEmployee.CurrentRow.Cells[12].Value.ToString();
            textEmployeeDetails.Text = dataGridEmployee.CurrentRow.Cells[13].Value.ToString();
            textEmployeeNeighbourhood.Text = dataGridEmployee.CurrentRow.Cells[14].Value.ToString();
            textEmployeeCity.Text = dataGridEmployee.CurrentRow.Cells[15].Value.ToString();
            comboEmployeeState.Text = dataGridEmployee.CurrentRow.Cells[16].Value.ToString();
            tabEmployees.SelectedTab = tabPage3;

        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = int.Parse(textEmployeeID.Text);
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.deleteEmployees(employee);
            dataGridEmployee.DataSource = employeeDAO.showEmployees();
            Helpers helper = new Helpers();
            helper.cleanScreen(this);

        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.Name = textEmployeeName.Text;
            employee.Email = textEmployeeMail.Text;
            employee.RG = textEmployeeRG.Text;
            employee.CPF = textEmployeeCPF.Text;

            // Proteção contra null em comboBox
            employee.Occupation = comboBoxOccupation.SelectedItem?.ToString() ?? "";
            employee.AccessLevel = comboAccess.SelectedItem?.ToString() ?? "";
            employee.State = comboEmployeeState.SelectedItem?.ToString() ?? "";

            employee.Password = textEmployeePassword.Text;
            employee.Phone = textEmployeePhone.Text;
            employee.cellPhone = textEmployeeCellPhone.Text;
            employee.zipCode = textEmployeeZipCode.Text;
            employee.Address = textEmployeeAddress.Text;
            employee.City = textEmployeeCity.Text;
            employee.Neighbourhood = textEmployeeNeighbourhood.Text;
            employee.Details = textEmployeeDetails.Text;
            employee.Id = int.Parse(textEmployeeID.Text);

            if (!int.TryParse(textEmployeeHouseNumber.Text, out int houseNumber))
            {
                MessageBox.Show("Número da casa inválido.");
                return;
            }
            employee.houseNumber = houseNumber;

            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.updateEmployees(employee);

        }

        private void buttonCheckZipCode_Click(object sender, EventArgs e)
        {
            try
            {
                String zipCode = textEmployeeZipCode.Text;
                String xml = "https://viacep.com.br/ws/" + zipCode + "/xml/";
                DataSet data = new DataSet();
                data.ReadXml(xml);

                textEmployeeAddress.Text = data.Tables[0].Rows[0]["logradouro"].ToString();
                textEmployeeNeighbourhood.Text = data.Tables[0].Rows[0]["bairro"].ToString();
                textEmployeeCity.Text = data.Tables[0].Rows[0]["localidade"].ToString();
                textEmployeeDetails.Text = data.Tables[0].Rows[0]["complemento"].ToString();
                comboEmployeeState.Text = data.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado.");
            }
        }

        private void comboEmployeeState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEmployeeSearch_Click(object sender, EventArgs e)
        {
            string nome = textEmployeeSearch.Text;
            EmployeeDAO employeeDAO = new EmployeeDAO();
            dataGridEmployee.DataSource = employeeDAO.searchEmployeesByName(nome);

            if (dataGridEmployee.Rows.Count == 0 || textEmployeeSearch.Text == string.Empty)
            {
                MessageBox.Show("Colaborador inexistente.");
                dataGridEmployee.DataSource = employeeDAO.showEmployees();
            }
        }

        private void textEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + textEmployeeSearch.Text + "%";
            EmployeeDAO employeeDAO = new EmployeeDAO();
            dataGridEmployee.DataSource = employeeDAO.searchEmployeesByNameWhileTyping(nome);

        }

        private void buttonCreateEmployee_Click(object sender, EventArgs e)
        {
            new Helpers().cleanScreen(this);
        }
    }
}

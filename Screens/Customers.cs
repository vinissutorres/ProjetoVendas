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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Helpers().cleanScreen(this);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(textHouseNumber.Text, out int houseNumber))
                {
                    MessageBox.Show("Número da casa inválido. Digite apenas números.");
                    return;
                }

                Customer customer = new Customer
                {
                    Name = textName.Text,
                    RG = textRG.Text,
                    CPF = textCPF.Text,
                    Email = textEmail.Text,
                    cellPhone = textCellPhone.Text,
                    Phone = textPhone.Text,
                    zipCode = textZipCode.Text,
                    Address = textAddress.Text,
                    houseNumber = houseNumber,
                    Details = textDetails.Text,
                    Neighbourhood = textNeighbourhood.Text,
                    City = textCity.Text,
                    State = comboBoxState.Text
                };

                CustomerDAO newCustomerDAO = new CustomerDAO();
                newCustomerDAO.createCustomer(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
            }
        }


        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String name = textReadingName.Text;
            CustomerDAO dao = new CustomerDAO();
            dataGridPeople.DataSource = dao.lookForCustomersByName(name);
            if(dataGridPeople.Rows.Count == 0)
            {
                dataGridPeople.DataSource = dao.showCustomers();
            }
        }

        private void textReadingName_KeyPress(object sender, KeyPressEventArgs e)
        {
            String name = "%" + textReadingName.Text + "%";
            CustomerDAO dao = new CustomerDAO();
            dataGridPeople.DataSource = dao.listCustomersByName(name);
            if (dataGridPeople.Rows.Count == 0)
            {
                dataGridPeople.DataSource = dao.showCustomers();
            }
        }


        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridPeople.DefaultCellStyle.ForeColor = Color.Black;
            CustomerDAO dao = new CustomerDAO();
            dataGridPeople.DataSource = dao.showCustomers();
        }

        private void dataGridPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridPeople.CurrentRow.Cells[0].Value.ToString();
            textName.Text = dataGridPeople.CurrentRow.Cells[1].Value.ToString();
            textRG.Text = dataGridPeople.CurrentRow.Cells[2].Value.ToString();
            textCPF.Text = dataGridPeople.CurrentRow.Cells[3].Value.ToString();
            textEmail.Text = dataGridPeople.CurrentRow.Cells[4].Value.ToString();
            textPhone.Text = dataGridPeople.CurrentRow.Cells[5].Value.ToString();
            textCellPhone.Text = dataGridPeople.CurrentRow.Cells[6].Value.ToString();
            textZipCode.Text = dataGridPeople.CurrentRow.Cells[7].Value.ToString();
            textAddress.Text = dataGridPeople.CurrentRow.Cells[8].Value.ToString();
            textHouseNumber.Text = dataGridPeople.CurrentRow.Cells[9].Value.ToString();
            textDetails.Text = dataGridPeople.CurrentRow.Cells[10].Value.ToString();
            textNeighbourhood.Text = dataGridPeople.CurrentRow.Cells[11].Value.ToString();
            textCity.Text = dataGridPeople.CurrentRow.Cells[12].Value.ToString();
            comboBoxState.Text = dataGridPeople.CurrentRow.Cells[13].Value.ToString();


            tabCadastro.SelectedTab = tabPage1;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.Id = int.Parse(textID.Text);
            CustomerDAO dao = new CustomerDAO();
            dao.removeCustomer(customer);

            dataGridPeople.DataSource = dao.showCustomers();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(textHouseNumber.Text, out int houseNumber))
                {
                    MessageBox.Show("Número da casa inválido. Digite apenas números.");
                    return;
                }

                Customer customer = new Customer
                {
                    Id = int.Parse(textID.Text),
                    Name = textName.Text,
                    RG = textRG.Text,
                    CPF = textCPF.Text,
                    Email = textEmail.Text,
                    cellPhone = textCellPhone.Text,
                    Phone = textPhone.Text,
                    zipCode = textZipCode.Text,
                    Address = textAddress.Text,
                    houseNumber = houseNumber,
                    Details = textDetails.Text,
                    Neighbourhood = textNeighbourhood.Text,
                    City = textCity.Text,
                    State = comboBoxState.Text

                };

                CustomerDAO newCustomerDAO = new CustomerDAO();
                newCustomerDAO.updateCustomer(customer);
                dataGridPeople.DataSource = newCustomerDAO.showCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
            }
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            try
            {
                String zipCode = textZipCode.Text;
                String xml = "https://viacep.com.br/ws/"+zipCode+"/xml/";
                DataSet data = new DataSet();
                data.ReadXml(xml);

                textAddress.Text = data.Tables[0].Rows[0]["logradouro"].ToString();
                textNeighbourhood.Text = data.Tables[0].Rows[0]["bairro"].ToString();
                textCity.Text = data.Tables[0].Rows[0]["localidade"].ToString();
                textDetails.Text = data.Tables[0].Rows[0]["complemento"].ToString();
                comboBoxState.Text = data.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado.");
            }

        }
    }
}

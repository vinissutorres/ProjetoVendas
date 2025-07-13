using ProjetoVendas.Dao;
using ProjetoVendas.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoVendas.Screens
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Suppliers_Load); 
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            loadSuppliers();
        }

        private void loadSuppliers()
        {
            SupplierDAO supplierDAO = new SupplierDAO();
            dataGridSupplier.DataSource = supplierDAO.showSuppliers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string zipCode = textSupplierZipCode.Text;
                string xml = "https://viacep.com.br/ws/" + zipCode + "/xml/";
                DataSet data = new DataSet();
                data.ReadXml(xml);

                textSupplierAddress.Text = data.Tables[0].Rows[0]["logradouro"].ToString();
                textSupplierNeighbourhood.Text = data.Tables[0].Rows[0]["bairro"].ToString();
                textSupplierCity.Text = data.Tables[0].Rows[0]["localidade"].ToString();
                textSupplierDetails.Text = data.Tables[0].Rows[0]["complemento"].ToString();
                comboSupplierState.Text = data.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado.");
            }
        }

        private void buttonNewSupplier_Click(object sender, EventArgs e)
        {
            new Helpers().cleanScreen(this);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textSupplierHouseNumber.Text, out int houseNumber))
                {
                    MessageBox.Show("Número da casa inválido. Digite apenas números.");
                    return;
                }

                Supplier supplier = new Supplier
                {
                    Name = textSupplierName.Text,
                    CNPJ = textSupplierCNPJ.Text,
                    Email = textSupplierMail.Text,
                    cellPhone = textSupplierCellPhone.Text,
                    Phone = textSupplierPhone.Text,
                    zipCode = textSupplierZipCode.Text,
                    Address = textSupplierAddress.Text,
                    houseNumber = houseNumber,
                    Details = textSupplierDetails.Text,
                    Neighbourhood = textSupplierNeighbourhood.Text,
                    City = textSupplierCity.Text,
                    State = comboSupplierState.Text
                };

                SupplierDAO newSupplierDAO = new SupplierDAO();
                newSupplierDAO.createSupplier(supplier);

                new Helpers().cleanScreen(this);
                loadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar fornecedor: " + ex.Message);
            }
        }

        private void dataGridSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textSupplierID.Text = dataGridSupplier.CurrentRow.Cells[0].Value.ToString();
            textSupplierName.Text = dataGridSupplier.CurrentRow.Cells[1].Value.ToString();
            textSupplierCNPJ.Text = dataGridSupplier.CurrentRow.Cells[2].Value.ToString();
            textSupplierMail.Text = dataGridSupplier.CurrentRow.Cells[3].Value.ToString();
            textSupplierPhone.Text = dataGridSupplier.CurrentRow.Cells[4].Value.ToString();
            textSupplierCellPhone.Text = dataGridSupplier.CurrentRow.Cells[5].Value.ToString();
            textSupplierZipCode.Text = dataGridSupplier.CurrentRow.Cells[6].Value.ToString();
            textSupplierAddress.Text = dataGridSupplier.CurrentRow.Cells[7].Value.ToString();
            textSupplierHouseNumber.Text = dataGridSupplier.CurrentRow.Cells[8].Value.ToString();
            textSupplierDetails.Text = dataGridSupplier.CurrentRow.Cells[9].Value.ToString();
            textSupplierNeighbourhood.Text = dataGridSupplier.CurrentRow.Cells[10].Value.ToString();
            textSupplierCity.Text = dataGridSupplier.CurrentRow.Cells[11].Value.ToString();
            comboSupplierState.Text = dataGridSupplier.CurrentRow.Cells[12].Value.ToString();


            tabSupplier.SelectedTab = tabSupplier2;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textSupplierHouseNumber.Text, out int houseNumber))
                {
                    MessageBox.Show("Número da casa inválido. Digite apenas números.");
                    return;
                }

                Supplier supplier = new Supplier
                {
                    Name = textSupplierName.Text,
                    CNPJ = textSupplierCNPJ.Text,
                    Email = textSupplierMail.Text,
                    cellPhone = textSupplierCellPhone.Text,
                    Phone = textSupplierPhone.Text,
                    zipCode = textSupplierZipCode.Text,
                    Address = textSupplierAddress.Text,
                    houseNumber = houseNumber,
                    Details = textSupplierDetails.Text,
                    Neighbourhood = textSupplierNeighbourhood.Text,
                    City = textSupplierCity.Text,
                    State = comboSupplierState.Text,
                    Id = int.Parse(textSupplierID.Text),
                };

                SupplierDAO newSupplierDAO = new SupplierDAO();
                newSupplierDAO.updateSupplier(supplier);

                loadSuppliers();
                new Helpers().cleanScreen(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar fornecedor: " + ex.Message);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textSupplierID.Text, out int supplierId))
                {
                    MessageBox.Show("ID inválido. Selecione um fornecedor da lista antes de excluir.");
                    return;
                }

                Supplier supplier = new Supplier
                {
                    Id = supplierId
                };

                SupplierDAO newSupplierDAO = new SupplierDAO();
                newSupplierDAO.removeSupplier(supplier);

                loadSuppliers();
                new Helpers().cleanScreen(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
            }
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            string nome = textSupplierSearch.Text;
            SupplierDAO supplierDAO = new SupplierDAO();

            dataGridSupplier.DataSource = supplierDAO.searchSuppliersByName(nome);

            if(dataGridSupplier.Rows.Count == 0)
            {
                dataGridSupplier.DataSource = supplierDAO.showSuppliers();
            }
        }

        private void textSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + textSupplierSearch.Text + "%";
            SupplierDAO supplierDAO = new SupplierDAO();
            dataGridSupplier.DataSource = supplierDAO.searchSuppliersByNameWhileTyping(nome);
        }
    }
}

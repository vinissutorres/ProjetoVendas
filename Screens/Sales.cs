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
    public partial class Sales : Form
    {
        Customer customer = new Customer();
        CustomerDAO customerDAO = new CustomerDAO();
        Models.Products products = new Models.Products();
        ProductDAO productDAO = new ProductDAO();

        int quantityObjects;
        decimal priceObjects;
        decimal subtotalObjects, totalObjects;

        DataTable shoppingCart = new DataTable();

        public Sales()
        {
            InitializeComponent();
            shoppingCart.Columns.Add("Codigo", typeof(int));
            shoppingCart.Columns.Add("Produto", typeof(string));
            shoppingCart.Columns.Add("Quantidade", typeof(int));
            shoppingCart.Columns.Add("Preço", typeof(decimal));
            shoppingCart.Columns.Add("Subtotal", typeof(decimal));

            dataGridSalesProducts.DataSource = shoppingCart;
        }

        private void textSalesCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                customer = customerDAO.searchCustomerByCPF(textSalesCPF.Text);

                if (customer != null && !string.IsNullOrEmpty(customer.Name))
                {
                    textSalesName.Text = customer.Name;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                    textSalesName.Clear();
                    textSalesCPF.Clear();
                    textSalesCPF.Focus();
                }
            }
        }


        private void textSalesID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    products = productDAO.searchProductsByCode(int.Parse(textSalesID.Text));

                    if (products != null && !string.IsNullOrEmpty(products.Description))
                    {
                        textSalesDescription.Text = products.Description;
                        textSalesPrice.Text = products.Price.ToString("F2");
                    }
                    else
                    {
                        textSalesDescription.Clear();
                        textSalesPrice.Clear();
                        textSalesID.Clear();
                        textSalesID.Focus();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Digite um código de produto válido.");
                }
            }
        }

        private void buttonSalesCreate_Click(object sender, EventArgs e)
        {
            try
            {
                quantityObjects = int.Parse(textSalesQuantity.Text);
                priceObjects = decimal.Parse(textSalesPrice.Text);

                subtotalObjects = quantityObjects * priceObjects;
                totalObjects += subtotalObjects;

                shoppingCart.Rows.Add(int.Parse(textSalesID.Text), textSalesDescription.Text, quantityObjects, priceObjects, subtotalObjects);


                textSalesTotal.Text = totalObjects.ToString();
                textSalesID.Clear();
                textSalesDescription.Clear();
                textSalesQuantity.Clear();
                textSalesPrice.Clear();

                textSalesID.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Digite o código do produto");
                throw;
            }
        }

        private void buttonSalesRemove_Click(object sender, EventArgs e)
        {
            decimal subproduct = decimal.Parse(dataGridSalesProducts.CurrentRow.Cells[4].Value.ToString());
            int tableIndex = dataGridSalesProducts.CurrentRow.Index;
            DataRow row = shoppingCart.Rows[tableIndex];
            shoppingCart.Rows.Remove(row);
            shoppingCart.AcceptChanges();
            totalObjects -= subproduct;
            textSalesTotal.Text = totalObjects.ToString();
            MessageBox.Show("Item removido!");
        }

        private void buttonPayment_Click(object sender, EventArgs e)


        {   DateTime currentDate = DateTime.Parse(textSalesDate.Text);
            Payment payment = new Payment(customer, shoppingCart, currentDate);
            payment.textPaymentTotal.Text = totalObjects.ToString(); 
            payment.ShowDialog();
        }

        private void dataGridSalesProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            textSalesDate.Text = DateTime.Now.ToShortDateString();

        }
    }
}

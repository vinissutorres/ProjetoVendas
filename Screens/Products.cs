using ProjetoVendas.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoVendas.Models;

namespace ProjetoVendas.Screens
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            SupplierDAO supplierDAO = new SupplierDAO();
            comboProductSupplier.DataSource = supplierDAO.showSuppliers();
            comboProductSupplier.DisplayMember = "nome";
            comboProductSupplier.ValueMember = "id";

            ProductDAO productsDAO = new ProductDAO();
            dataGridProduct.DataSource = productsDAO.showProducts();


        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            Models.Products products = new Models.Products();
            products.Description = textProductDescription.Text;
            products.Price = decimal.Parse(textProductPrice.Text);
            products.Quantity = int.Parse(textProductQuantity.Text);
            products.for_id = int.Parse(comboProductSupplier.SelectedValue.ToString());

            ProductDAO productDAO = new ProductDAO();
            productDAO.createProduct(products);

            new Helpers().cleanScreen(this);

            dataGridProduct.DataSource = productDAO.showProducts();

        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textProductID.Text = dataGridProduct.CurrentRow.Cells[0].Value.ToString();
            textProductDescription.Text = dataGridProduct.CurrentRow.Cells[1].Value.ToString();
            textProductPrice.Text = dataGridProduct.CurrentRow.Cells[2].Value.ToString();
            textProductQuantity.Text = dataGridProduct.CurrentRow.Cells[3].Value.ToString();
            comboProductSupplier.Text = dataGridProduct.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabProduto1;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Models.Products products = new Models.Products();
            products.Description = textProductDescription.Text;
            products.Price = decimal.Parse(textProductPrice.Text);
            products.Quantity = int.Parse(textProductQuantity.Text);
            products.for_id = int.Parse(comboProductSupplier.SelectedValue.ToString());
            products.Id = int.Parse(textProductID.Text);

            ProductDAO productDAO = new ProductDAO();
            productDAO.updateProduct(products);

            new Helpers().cleanScreen(this);

            dataGridProduct.DataSource = productDAO.showProducts();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Models.Products products = new Models.Products();
            products.Id = int.Parse(textProductID.Text);

            ProductDAO productDAO = new ProductDAO();
            productDAO.deleteProduct(products);

            new Helpers().cleanScreen(this);

            dataGridProduct.DataSource = productDAO.showProducts();
        }

        private void textReadingNameProduct_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + textReadingNameProduct.Text + "%";
            ProductDAO productDAO = new ProductDAO();
            dataGridProduct.DataSource = productDAO.showProductsByName(nome);
        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            string nome = textReadingNameProduct.Text;
            ProductDAO productDAO = new ProductDAO();
            dataGridProduct.DataSource = productDAO.searchProductsByName(nome);

            if (dataGridProduct.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontado.");
                dataGridProduct.DataSource = productDAO.showProducts();
            }
        }
    }
}

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
    public partial class Payment : Form
    {
        Models.Customer customer = new Models.Customer();
        DataTable shoppingCart = new DataTable();
        DateTime currentDate;
        public Payment(Models.Customer customer, DataTable shoppingCart, DateTime currentDate)
        {
            this.customer = customer;
            this.shoppingCart = shoppingCart;
            this.currentDate = currentDate;
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            textChange.Text = "0,00";
            textCard.Text = "0,00";
            textMoney.Text = "0,00";
        }

        private void textPaymentConclude_Click(object sender, EventArgs e)
        {
            try
            {
                decimal moneyValue, moneyCard, change, totalPaid, totalPayment;
                int qtd_estoque, qtd_comprada, qtd_atualizada;
                ProductDAO productDAO = new ProductDAO();

                moneyValue = decimal.Parse(textMoney.Text);
                moneyCard = decimal.Parse(textCard.Text);
                totalPayment = decimal.Parse(textPaymentTotal.Text);
                totalPaid = moneyCard + moneyValue;

                if(totalPaid < totalPayment)
                {
                    MessageBox.Show("Valor pago é menor que valor total da venda.");
                }

                change = totalPaid - totalPayment;

                Models.Sales sale = new Models.Sales();
                sale.cliente_id = customer.Id;
                sale.sale_date = currentDate;
                sale.total_sales = totalPayment;
                sale.obs = textPaymentObs.Text;

                SalesDAO salesDAO = new SalesDAO();
                textChange.Text = change.ToString();
                salesDAO.createSale(sale);

                foreach (DataRow row in shoppingCart.Rows)
                {
                    SoldItems soldItems = new SoldItems();
                    soldItems.venda_id = salesDAO.returnLastId();
                    soldItems.produto_id = int.Parse(row["Codigo"].ToString());
                    soldItems.qtd = int.Parse(row["Quantidade"].ToString());
                    soldItems.subtotal = decimal.Parse(row["Subtotal"].ToString());

                    qtd_estoque = productDAO.returnQuantityProducts(soldItems.produto_id);
                    qtd_comprada = soldItems.qtd;
                    qtd_atualizada = qtd_estoque - qtd_comprada;

                    productDAO.minusOneProduct(soldItems.produto_id, qtd_atualizada);


                    Item_SaleDAO item_SaleDAO = new Item_SaleDAO();
                    item_SaleDAO.createNewItem(soldItems);

                }
                MessageBox.Show("Venda finalizada com êxito");
                this.Dispose();
                this.Close();
                new Sales().ShowDialog();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

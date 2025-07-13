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

namespace ProjetoVendas.Screens
{
    public partial class Details : Form
    {
        int venda_id;
        public Details(int sales_id)
        {
            venda_id = sales_id;
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            Item_SaleDAO item_SaleDAO = new Item_SaleDAO();
            DetailsGrid.DataSource = item_SaleDAO.showAllItemsPerSales(venda_id);
            
        }
    }
}

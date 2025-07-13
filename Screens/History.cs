using ProjetoVendas.Dao;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoVendas.Screens
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            SalesDAO salesDAO = new SalesDAO();

            dataHistory.AutoGenerateColumns = true;
            dataHistory.Columns.Clear();

            dataHistory.DataSource = salesDAO.showAllSales();
            dataHistory.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void buttonSearchHistory_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dateBeginning.Value.Date;
            DateTime dataFim = dateEnding.Value.Date;

            SalesDAO salesDAO = new SalesDAO();

            dataHistory.AutoGenerateColumns = true;
            dataHistory.Columns.Clear();

            dataHistory.DataSource = salesDAO.showSalesPerPeriod(dataInicio, dataFim);
            dataHistory.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void dataHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sales_id = int.Parse(dataHistory.CurrentRow.Cells[0].Value.ToString());
            Details detailsScreen = new Details(sales_id);
            detailsScreen.ShowDialog();

            DateTime dataVenda = Convert.ToDateTime(dataHistory.CurrentRow.Cells[1].Value.ToString());

            detailsScreen.textDetailsCustomer.Text = dataHistory.CurrentRow.Cells[2].Value.ToString();
            detailsScreen.textDetailsDate.Text = dataVenda.ToString("dd/MM/yyyy");
            detailsScreen.textDetailsValue.Text = dataHistory.CurrentRow.Cells[3].Value.ToString();
            detailsScreen.textDetailsObs.Text = dataHistory.CurrentRow.Cells[4].Value.ToString();

            
        }
    }
}

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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            currentDate.Text = DateTime.Now.ToShortDateString();

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentHour.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customerScreen = new Customers();
            customerScreen.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customerScreen = new Customers();
            customerScreen.tabCadastro.SelectedTab = customerScreen.tabPage2;
            customerScreen.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employees screen = new Employees();
            screen.ShowDialog();
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Suppliers screen = new Suppliers();
            screen.ShowDialog();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Suppliers screen = new Suppliers();
            screen.tabSupplier.SelectedTab = screen.tabSupplier3;
            screen.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employees screen = new Employees();
            screen.tabEmployees.SelectedTab = screen.tabPage4;
            screen.ShowDialog();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales screen = new Sales();
            screen.ShowDialog();
        }

        private void historyOption_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }

        private void cadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Products products1 = new Products();
            products1.tabProdutos.SelectedTab = products1.tabProduto2;
            products1.ShowDialog();
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente trocar de usuário?", "Trocar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginScreen = new Login();
                loginScreen.ShowDialog(); 
                this.Close();
            }
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo sair do sistema?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string mail = textLoginEmail.Text;
            string password = textLoginPassword.Text;

            EmployeeDAO employeeDAO = new EmployeeDAO();
            if(employeeDAO.Login(mail, password))
            {
                

                this.Hide();
            }
        }
    }
}

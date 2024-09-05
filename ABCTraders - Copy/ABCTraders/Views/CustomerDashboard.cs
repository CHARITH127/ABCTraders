using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABCTraders
{
    public partial class CustomerDashboard : Form
    {

        private string userName;

        public CustomerDashboard(string username)
        {
            InitializeComponent(username);
            cust_userNameLbl.Text = username;
        }

        public void SetUsername(string username)
        {
            cust_userNameLbl.Text = username;
            this.userName = username;
        }

        private void customerPanel_placeOrderBtn_Click(object sender, EventArgs e)
        {
            orderManagment1.Visible = false;
            placeOrders1.Username = cust_userNameLbl.Text;
            placeOrders1.Visible = true;
        }

        private void customerPanel_mangeOrderBtn_Click(object sender, EventArgs e)
        {
            orderManagment1.refreshTheGrid();
            orderManagment1.Visible = true;
            placeOrders1.Visible = false;
            
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

            placeOrders1.Username = cust_userNameLbl.Text;
            placeOrders1.Visible = true;
            orderManagment1.Visible = false;
            
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                this.Close();

                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}

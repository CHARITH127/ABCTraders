using ABCTraders.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTraders
{
    public partial class ManageCustomers : UserControl
    {

        private UserService userService;

        public ManageCustomers()
        {
            InitializeComponent();
            userService = new UserService();
            LoadAllCustomers();
        }

        public void refreshGrid()
        {
            LoadAllCustomers();
        }

        private void LoadAllCustomers()
        {
            adminCustomerMng_gridView.DataSource = userService.GetAllCustomers();
        }

        private void adminMngCustomers_updateBtn_Click(object sender, EventArgs e)
        {
            if (adminCustomerMng_gridView.SelectedRows.Count > 0)
            {
                var selectedRow = adminCustomerMng_gridView.SelectedRows[0];
                int customerId = (int)selectedRow.Cells["UserID"].Value;
                string newPassword = adminMngCustomers_passwordInput.Text;

                userService.UpdateCustomerPassword(customerId, newPassword);
                LoadAllCustomers();
                clearAll();
            }
        }

        private void adminMngCustomers_searchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(adminMngCustomers_searchInput.Text, out int customerId))
            {
                var customerData = userService.GetCustomerByIdGrid(customerId);
                adminCustomerMng_gridView.DataSource = customerData;
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID.");
            }
        }

        private void adminCustomerMng_gridView_SelectionChanged(object sender, EventArgs e)
        {
            if (adminCustomerMng_gridView.SelectedRows.Count > 0)
            {
                var selectedRow = adminCustomerMng_gridView.SelectedRows[0];
                adminMngCustomers_nameInput.Text = selectedRow.Cells["Username"].Value.ToString();
                adminMngCustomers_passwordInput.Text = selectedRow.Cells["Password"].Value.ToString();
            }
        }

        private void clearAll()
        {
            adminMngCustomers_nameInput.Text = "";
            adminMngCustomers_passwordInput.Text = "";
            adminMngCustomers_searchInput.Text = "";

        }

        private void adminMngCustomers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (adminCustomerMng_gridView.SelectedRows.Count > 0)
            {
                var selectedRow = adminCustomerMng_gridView.SelectedRows[0];
                int customerId = (int)selectedRow.Cells["UserID"].Value;

                userService.DeleteUser(customerId);
                LoadAllCustomers();
            }
            else
            {
                MessageBox.Show("Please select the customer .");
            }
        }
    }
}

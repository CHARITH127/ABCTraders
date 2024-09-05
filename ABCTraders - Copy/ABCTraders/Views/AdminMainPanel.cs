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
    public partial class AdminMainPanel : Form
    {

        private ManageCustomers ManageCustomers;
        private ManageCarParts ManageCarParts;

        public AdminMainPanel()
        {
            InitializeComponent();
            ManageCustomers = new ManageCustomers();
            ManageCarParts = new ManageCarParts();
            // add the userControllers to the current form controllers
            this.Controls.Add(ManageCustomers);
            this.Controls.Add(ManageCarParts);
        }

        private void admin_MangeCarsBtn_Click(object sender, EventArgs e)
        {
            manageCars1.Visible = true;
            manageCarParts1.Visible = false;
            manageCustomers1.Visible = false;
            manageOrders1.Visible = false;
            reportGenaration1.Visible = false;
            adminDashboard1.Visible = false;
        }

        private void admin_MangeCarPartsBtn_Click(object sender, EventArgs e)
        {
            manageCars1.Visible = false;
            manageCarParts1.Visible = true;
            manageCustomers1.Visible = false;
            manageOrders1.Visible = false;
            reportGenaration1.Visible = false;
            adminDashboard1.Visible = false;
            ManageCarParts.refreshGrid();
        }

        private void admin_MangeCustomersBtn_Click(object sender, EventArgs e)
        {
            manageCustomers1.Visible = true;
            manageCars1.Visible = false;
            manageCarParts1.Visible = false;
            manageOrders1.Visible = false;
            reportGenaration1.Visible = false;
            adminDashboard1.Visible = false;
            ManageCustomers.refreshGrid();
        }

        private void admin_MangeOrdersBtn_Click(object sender, EventArgs e)
        {
            manageOrders1.Visible = true;
            manageCustomers1.Visible = false;
            manageCars1.Visible = false;
            manageCarParts1.Visible = false;
            reportGenaration1.Visible = false;
            adminDashboard1.Visible = false;
        }

        private void admin_GenerateReportBtn_Click(object sender, EventArgs e)
        {
            reportGenaration1.Visible = true;
            manageOrders1.Visible = false;
            manageCustomers1.Visible = false;
            manageCars1.Visible = false;
            manageCarParts1.Visible = false;
            adminDashboard1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            reportGenaration1.Visible = false;
            manageOrders1.Visible = false;
            manageCustomers1.Visible = false;
            manageCars1.Visible = false;
            manageCarParts1.Visible = false;
        }
    }
}

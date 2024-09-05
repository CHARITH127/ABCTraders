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
    public partial class adminDashboard : UserControl
    {

        private OrderService orderService;

        public adminDashboard()
        {
            InitializeComponent();
            orderService = new OrderService();
            LoadDashboardData();
        }

        public void refreshDashboard()
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // Load Shipped Orders Count
                adminDash_shippedOrdersLbl.Text = orderService.GetOrderCountByStatus("Shipped").ToString();

                // Load Canceled Orders Count
                adminDash_CancelOrdersLbl.Text = orderService.GetOrderCountByStatus("Cancel").ToString();

                // Load Total Income from Shipped Orders
                adminDash_TotalIncomeLbl.Text = orderService.GetTotalAmountByStatus("Shipped").ToString("C");

                // Load Total Loss from Canceled Orders
                adminDash_TotalIostLbl.Text = orderService.GetTotalAmountByStatus("Cancel").ToString("C");

                // Load Pending Orders Count
                adminDash_PndinglOrdersLbl.Text = orderService.GetOrderCountByStatus("Pending").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }
    }
}

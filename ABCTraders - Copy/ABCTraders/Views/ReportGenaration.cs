using ABCTraders.Models;
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
    public partial class ReportGenaration : UserControl
    {

        private OrderService orderService;
        private ReportService reportService;

        public ReportGenaration()
        {
            InitializeComponent();
            orderService = new OrderService();
            reportService = new ReportService();
        }

        private void admin_ReportSearchBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = admin_FromDatePicker.Value;
            DateTime toDate = admin_ToDatePicker.Value;

            List<OrderOut> orders = orderService.GetOrdersByDateRange(fromDate, toDate);

            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("No orders found within the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adminReport_gridView.DataSource = null;
            }
            else
            {
                adminReport_gridView.DataSource = orders;
            }
        }

        private void admin_ReportGenerateBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = admin_FromDatePicker.Value;
            DateTime toDate = admin_ToDatePicker.Value;

            List<OrderOut> orders = orderService.GetOrdersByDateRange(fromDate, toDate);

            // Validate if the list is empty
            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("No orders found in the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Display data in the grid
            adminReport_gridView.DataSource = orders;

            // Generate the Excel report
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                reportService.GenerateExcelReport(orders, saveFileDialog.FileName);
                MessageBox.Show("Report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

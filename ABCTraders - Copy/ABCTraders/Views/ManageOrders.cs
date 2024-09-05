using ABCTraders.Models;
using ABCTraders.Services;
using ABCTraders.Util;
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
    public partial class ManageOrders : UserControl
    {

        private OrderService orderService;

        public ManageOrders()
        {
            InitializeComponent();
            orderService = new OrderService();
            LoadAllOrders();
            adminMngOrders_statusCombo.Items.AddRange(new string[] { "Cancel", "Shipped" , "Pending"});
        }

        private void LoadAllOrders()
        {
            List<OrderOut> orders = orderService.GetAllOrders();
            adminOrderMng_gridView.DataSource = orders;
        }

        private void adminMngOrders_searchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(adminMngOrders_orderIdInput.Text, out int orderId))
            {
                OrderOut orderOut = orderService.GetOrderById(orderId);
                if (orderOut != null) {
                    adminOrderMng_gridView.DataSource = null;
                    adminOrderMng_gridView.DataSource = orderOut.OrderDetails.ToList();
                }
                else
                {
                    MessageBox.Show("Order not found.");
                    LoadAllOrders();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Order ID.");
                LoadAllOrders();
            }
        }

        private void adminMngOrders_updateBtn_Click(object sender, EventArgs e)
        {
            if (adminOrderMng_gridView.SelectedRows.Count > 0)
            {
                OrderOut selectedOrder = (OrderOut)adminOrderMng_gridView.SelectedRows[0].DataBoundItem;
               
                if(selectedOrder.Status == "Cancel")
                {
                    MessageBox.Show("Order is already cancel.");
                    return;
                }

                if (adminMngOrders_statusCombo.SelectedItem == null)
                {
                    MessageBox.Show("Please select a status before updating the order.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string status = adminMngOrders_statusCombo.SelectedItem.ToString();

                if (status == "Pending")
                {
                    MessageBox.Show("Status was not changed.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (status == "Cancel")
                {
                    string reason = Prompt.ShowDialog("Enter Reason for Cancellation", "Cancel Order");
                    if (!string.IsNullOrEmpty(reason))
                    {
                        selectedOrder.Status = "Cancel";
                        selectedOrder.Reason = reason;
                        orderService.UpdateOrderStatus(selectedOrder);
                        MessageBox.Show("Order updated to Cancel with reason.");
                        LoadAllOrders();
                    }
                    else
                    {
                        MessageBox.Show("Cancellation reason is required.");
                    }
                }
                else if (status == "Shipped")
                {
                    selectedOrder.Status = "Shipped";
                    orderService.UpdateOrderStatus(selectedOrder);
                    MessageBox.Show("Order status updated to Shipped.");
                    LoadAllOrders();
                }
            }
            else
            {
                MessageBox.Show("Please select an order to update.");
            }
        }

        private void adminOrderMng_gridView_SelectionChanged(object sender, EventArgs e)
        {
            // Ensure that a row is actually selected
            if (adminOrderMng_gridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = adminOrderMng_gridView.SelectedRows[0];

                // Retrieve the Order Date from the selected row
                string orderDate = selectedRow.Cells["OrderDate"].Value.ToString();

                // Retrieve the Status from the selected row
                string orderStatus = selectedRow.Cells["Status"].Value.ToString();

                // Load the Order Date into the TextBox
                adminMngOrders_orderDateInput.Text = orderDate;

                // Load the Status into the ComboBox
                adminMngOrders_statusCombo.SelectedItem = orderStatus;
            }
        }
    }
}

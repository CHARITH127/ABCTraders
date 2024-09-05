using ABCTraders.Models;
using ABCTraders.Services;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class OrderManagment : UserControl
    {

        private OrderService orderService;
        private UserService userService;
        public string userName;



        //this for before delete item check if it is order or orderDetail
        private bool isSearch;

        public OrderManagment()
        {
            InitializeComponent();
            orderService = new OrderService();
            userService = new UserService();
            LoadAllOrders();
        }
        public OrderManagment(string username)
        {
            InitializeComponent();
            this.userName = username;
            orderService = new OrderService();
            userService = new UserService();
            LoadAllOrders();
        }

        public void refreshTheGrid()
        {
            LoadAllOrders();
        }

        private void LoadAllOrders()
        {
            int userID = userService.GetUserIdByUsername(this.userName);
            List<OrderOut> orders = orderService.GetAllOrdersByUSerID(userID);
            //List<OrderOut> orders = orderService.GetAllOrders();
            customerOrderMng_gridView.DataSource = orders.Select(o => new
            {
                o.OrderID,
                o.UserID,
                o.OrderDate,
                o.Status,
                o.Reason,
                o.TotalAmount
            }).ToList();
        }

        private void cusOrderMgt_searchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(customerMngOrders_orderIDInput.Text, out int orderId))
            {
                isSearch = true;
                OrderOut order = orderService.GetOrderById(orderId);
                if (order != null)
                {

                    List<OrderDetailsOut> orderDetailsOuts = order.OrderDetails;
                    customerOrderMng_gridView.DataSource = orderDetailsOuts.ToList();

                }
                else
                {
                    MessageBox.Show("Order not found");
                }
            }
            else
            {
                isSearch = false;
                ClearGridView();
                LoadAllOrders();
            }
        }

        // Method to clear the grid view
        private void ClearGridView()
        {
            customerOrderMng_gridView.DataSource = null;
        }


        private void cusOrderMgt_deletBtn_Click(object sender, EventArgs e)
        {
            if (!isSearch)
            {
                if (customerOrderMng_gridView.SelectedRows.Count > 0)
                {
                    int selectedOrderID = (int)customerOrderMng_gridView.SelectedRows[0].Cells["OrderID"].Value;

                    if (orderService.GetOrderStatusById(selectedOrderID) == "Pending")
                    {
                        orderService.DeleteOrder(selectedOrderID);
                        LoadAllOrders();
                        MessageBox.Show("Successfully delete the order.");
                    }
                    else
                    {
                        MessageBox.Show("You can delete only pending orders.");
                    }

                    
                    
                }
                else
                {
                    MessageBox.Show("Please select row to update.");
                }
            }
            else
            {
                if (customerOrderMng_gridView.SelectedRows.Count > 0)
                {

                    int selectedOrderID = (int)customerOrderMng_gridView.SelectedRows[0].Cells["OrderID"].Value;

                    if (orderService.GetOrderStatusById(selectedOrderID) == "Pending")
                    {
                        int selectedOrderDetailID = (int)customerOrderMng_gridView.SelectedRows[0].Cells["OrderDetailID"].Value;
                        orderService.DeleteOrderDetail(selectedOrderID, selectedOrderDetailID);
                        LoadAllOrders();
                        MessageBox.Show("Successfully delete the order detail.");
                    }
                    else
                    {
                        MessageBox.Show("You can delete only pending orders.");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Please select row to update.");
                }
            }
            
        }

    }
}

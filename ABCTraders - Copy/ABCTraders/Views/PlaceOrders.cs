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
    public partial class PlaceOrders : UserControl
    {
        private UserService userService;
        public string Username { get; set; }

        public PlaceOrders()
        {
            InitializeComponent();
            InitializeDataGridView();
            userService = new UserService();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cus_placeOrderCarRbtn.Checked)
            {
                
                CarService carService = new CarService();
                List<string> brands = carService.GetCarBrands();
                cus_placeOrderBrandCombo.DataSource = brands;
                brandLbl.Text = "Brand :";
                modelLbl.Text = "Model :";
                

            }
            else if (cus_placeOrderCarPartRbtn.Checked)
            {
                CarPartsService carPartService = new CarPartsService();
                List<string> brands = carPartService.GetCarPartBrands();
                cus_placeOrderBrandCombo.DataSource = brands;
                brandLbl.Text = "Model :";
                modelLbl.Text = "Item :";

            }
        }

        private void cus_placeOrderAddBtn_Click(object sender, EventArgs e)
        {

            string type, model, name;
            string brand = null;
            decimal unitPrice;
            int qtyOnHand = 0;

            if (string.IsNullOrEmpty(cus_placeOrderQtyInput.Text) || !int.TryParse(cus_placeOrderQtyInput.Text, out int qty))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (cus_placeOrderCarRbtn.Checked)
            {
                type = "Car";
                brand = cus_placeOrderBrandCombo.SelectedItem.ToString();
                model = cus_placeOrderModelCombo.SelectedItem.ToString();

                CarService carService = new CarService();
                Car selectedCar = carService.GetCarByBrandAndModel(brand, model);

                if (selectedCar == null)
                {
                    MessageBox.Show("No car found with the selected brand and model.");
                    return;
                }

                name = selectedCar.BrandName;
                unitPrice = selectedCar.UnitPrice;
                qtyOnHand = selectedCar.Quantity;
            }
            else if (cus_placeOrderCarPartRbtn.Checked)
            {
                type = "CarPart";
                name = cus_placeOrderModelCombo.SelectedItem.ToString();
                model = cus_placeOrderBrandCombo.SelectedItem.ToString();

                CarPartsService carPartService = new CarPartsService();
                CarPart selectedCarPart = carPartService.GetCarPartByNameAndModel(name, model);

                if (selectedCarPart == null)
                {
                    MessageBox.Show("No car part found with the selected name and model.");
                    return;
                }

                name = selectedCarPart.Name;
                unitPrice = selectedCarPart.UnitPrice;
                qtyOnHand = selectedCarPart.Quantity;
            }
            else
            {
                MessageBox.Show("Please select Car or Car Part.");
                return;
            }


            //check the insert qty is low the quentity of the database
            if (qty > qtyOnHand)
            {
                MessageBox.Show("The entered quantity exceeds the available stock.");
                return;
            }

            decimal totalValue = qty * unitPrice;

            // Check if the item already exists
            foreach (DataGridViewRow row in customerPlaceOrder_gridView.Rows)
            {
                var typeCell = row.Cells["Type"].Value;
                var brandCell = row.Cells["Brand"].Value;
                var modelCell = row.Cells["Model"].Value;
                var nameCell = row.Cells["Name"].Value;

                if (typeCell != null && brandCell != null && modelCell != null && nameCell != null &&
                    typeCell.ToString() == type &&
                    brandCell.ToString() == brand &&
                    modelCell.ToString() == model &&
                    nameCell.ToString() == name)
                {
                    // Update quantity and total value
                    int existingQty = int.Parse(row.Cells["Qty"].Value.ToString());
                    row.Cells["Qty"].Value = existingQty + qty;
                    row.Cells["TotalValue"].Value = (existingQty + qty) * unitPrice;
                    UpdateTotalPrice();
                    return;
                }
            }

            // Add the data to the DataGridView
            customerPlaceOrder_gridView.Rows.Add(type, brand, model, name, qty, unitPrice, totalValue);

            // Update the total price
            UpdateTotalPrice();

        }

        private void cus_placeOrderDeleteBtn_Click(object sender, EventArgs e)
        {
            if (customerPlaceOrder_gridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in customerPlaceOrder_gridView.SelectedRows)
                {
                    customerPlaceOrder_gridView.Rows.Remove(row);
                }
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void cus_placeOrderBrandCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cus_placeOrderCarRbtn.Checked)
            {
                string selectedBrand = cus_placeOrderBrandCombo.SelectedItem.ToString();
                CarService carService = new CarService();
                List<string> models = carService.GetCarModelsByBrand(selectedBrand);
                cus_placeOrderModelCombo.DataSource = models;
            }
            else if (cus_placeOrderCarPartRbtn.Checked)
            {
                string selectedModel = cus_placeOrderBrandCombo.SelectedItem.ToString();
                CarPartsService carPartService = new CarPartsService();
                List<string> partNames = carPartService.GetCarPartNamesByModel(selectedModel);
                cus_placeOrderModelCombo.DataSource = partNames;
            }
        }

        private void cus_placeOrderModelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cus_placeOrderCarRbtn.Checked)
            {
                string selectedBrand = cus_placeOrderBrandCombo.SelectedItem.ToString();
                string selectedModel = cus_placeOrderModelCombo.SelectedItem.ToString();

                CarService carService = new CarService();
                Car selectedCar = carService.GetCarByBrandAndModel(selectedBrand, selectedModel);

                if (selectedCar != null)
                {
                    cus_placeOrderUnitPriceInput.Text = selectedCar.UnitPrice.ToString();
                }
                else
                {
                    MessageBox.Show("No car found with the selected brand and model.");
                }
            }
            else if (cus_placeOrderCarPartRbtn.Checked)
            {
                string selectedName = cus_placeOrderModelCombo.SelectedItem.ToString();
                string selectedModel = cus_placeOrderBrandCombo.SelectedItem.ToString();

                CarPartsService carPartService = new CarPartsService();
                CarPart selectedCarPart = carPartService.GetCarPartByNameAndModel(selectedName, selectedModel);

                if (selectedCarPart != null)
                {
                    cus_placeOrderUnitPriceInput.Text = selectedCarPart.UnitPrice.ToString();
                }
                else
                {
                    MessageBox.Show("No car part found with the selected name and model.");
                }
            }
        }

        private void InitializeDataGridView()
        {
            customerPlaceOrder_gridView.Columns.Add("Type", "Type");
            customerPlaceOrder_gridView.Columns.Add("Brand", "Brand");
            customerPlaceOrder_gridView.Columns.Add("Model", "Model");
            customerPlaceOrder_gridView.Columns.Add("Name", "Name");
            customerPlaceOrder_gridView.Columns.Add("Qty", "Quantity");
            customerPlaceOrder_gridView.Columns.Add("UnitPrice", "Unit Price");
            customerPlaceOrder_gridView.Columns.Add("TotalValue", "Total Value");
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in customerPlaceOrder_gridView.Rows)
            {
                // Check if the cell value is not null
                if (row.Cells["TotalValue"].Value != null &&
                    !string.IsNullOrEmpty(row.Cells["TotalValue"].Value.ToString()))
                {
                    totalPrice += decimal.Parse(row.Cells["TotalValue"].Value.ToString());
                }
            }

            cus_placeOrderTotalPriceLbl.Text = $"{totalPrice:C2}";
        }

        private void cus_placeOrderPlaceOrderBtn_Click(object sender, EventArgs e)
        {
            
            // Check if the grid is empty
            if (customerPlaceOrder_gridView.Rows.Count == 1)
            {
                MessageBox.Show("The order grid is empty. Please add items to the order before proceeding.");
                return;
            }

            try
            {

                int userID = userService.GetUserIdByUsername(Username);

                Order order = new Order
                {
                    UserID = userID,
                    OrderDate = DateTime.Now,
                    Status = "Pending",
                    Reason = string.Empty,
                    TotalAmount = decimal.Parse(cus_placeOrderTotalPriceLbl.Text.Replace("Total Price: ", "").Replace("$", ""))
                };

                List<OrderDetail> orderDetails = new List<OrderDetail>();

                //add details to the grid
                foreach (DataGridViewRow row in customerPlaceOrder_gridView.Rows)
                {
                    if (row.Cells["Type"].Value == null) continue;  // Skip empty rows

                    orderDetails.Add(new OrderDetail
                    {
                        Quantity = int.Parse(row.Cells["Qty"].Value.ToString()),
                        Type = row.Cells["Type"].Value.ToString(),
                        Brand = row.Cells["Brand"].Value?.ToString(),
                        Model = row.Cells["Model"].Value.ToString(),
                        Name = row.Cells["Name"].Value.ToString(),
                        UnitPrice = decimal.Parse(row.Cells["UnitPrice"].Value.ToString()),
                        TotalValue = decimal.Parse(row.Cells["TotalValue"].Value.ToString())
                    });
                }

                OrderService orderService = new OrderService();
                bool isSuccess = orderService.PlaceOrder(order, orderDetails);

                if (isSuccess)
                {
                    // clear the form or grid view after placing the order
                    customerPlaceOrder_gridView.Rows.Clear();

                    MessageBox.Show("Order placed successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to place the order.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

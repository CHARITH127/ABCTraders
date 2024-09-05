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
    public partial class ManageCars : UserControl
    {
        
        private CarService carService ;

        public ManageCars()
        {
            InitializeComponent();
            carService = new CarService();
            adminCarMng_gridView.SelectionChanged += AdminCarMng_gridView_SelectionChanged;
            LoadData();
        }

        public void refereshTheGrid()
        {
            LoadData();
        }

        private void LoadData()
        {
            List<Car> carList = carService.GetAllCars();
            adminCarMng_gridView.DataSource = null;
            adminCarMng_gridView.DataSource = carList;
        }

        private void adminMngCars_saveBtn_Click(object sender, EventArgs e)
        {
            Car newCar = new Car()
            {
                BrandName = adminMngCars_brandNameInput.Text,
                Model = adminMngCars_modelInput.Text,
                UnitPrice = decimal.Parse(adminMngCars_untiPriceInput.Text),
                Quantity = int.Parse(adminMngCars_qtyInput.Text)
            };

            carService.AddCar(newCar);
            LoadData(); // Refresh the grid view

            MessageBox.Show("Record successfully saved.");


            // Clear inputs after adding
            adminMngCars_brandNameInput.Text = "";
            adminMngCars_modelInput.Text = "";
            adminMngCars_untiPriceInput.Text = "";
            adminMngCars_qtyInput.Text = "";
        }

        private void adminMngCars_updateBtn_Click(object sender, EventArgs e)
        {
            if (adminCarMng_gridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)adminCarMng_gridView.SelectedRows[0].Cells["Id"].Value;
                Car updatedCar = new Car()
                {
                    Id = selectedId,
                    BrandName = adminMngCars_brandNameInput.Text,
                    Model = adminMngCars_modelInput.Text,
                    UnitPrice = decimal.Parse(adminMngCars_untiPriceInput.Text),
                    Quantity = int.Parse(adminMngCars_qtyInput.Text)
                };

                carService.UpdateCar(updatedCar);
                LoadData(); // Refresh the grid view

                MessageBox.Show("Record successfully updated.");

                // Clear inputs after adding
                adminMngCars_brandNameInput.Text = "";
                adminMngCars_modelInput.Text = "";
                adminMngCars_untiPriceInput.Text = "";
                adminMngCars_qtyInput.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a car to update.");
            }
        }

        private void adminMngCars_deleteBtn_Click(object sender, EventArgs e)
        {
            if (adminCarMng_gridView.SelectedRows.Count > 0)
            {
                int selectedId = (int)adminCarMng_gridView.SelectedRows[0].Cells["Id"].Value;
                carService.DeleteCar(selectedId);
                LoadData(); // Refresh the grid view

                MessageBox.Show("Record successfully deleted.");

                // Clear inputs after adding
                adminMngCars_brandNameInput.Text = "";
                adminMngCars_modelInput.Text = "";
                adminMngCars_untiPriceInput.Text = "";
                adminMngCars_qtyInput.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }

        private void ManageCars_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AdminCarMng_gridView_SelectionChanged(object sender, EventArgs e)
        {
            if (adminCarMng_gridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = adminCarMng_gridView.SelectedRows[0];

                // Assuming the DataGridView is bound to a list of Car objects
                Car selectedCar = selectedRow.DataBoundItem as Car;

                if (selectedCar != null)
                {
                    // Populate the input fields with the selected car's details
                    adminMngCars_brandNameInput.Text = selectedCar.BrandName;
                    adminMngCars_modelInput.Text = selectedCar.Model;
                    adminMngCars_qtyInput.Text = selectedCar.Quantity.ToString();
                    adminMngCars_untiPriceInput.Text = selectedCar.UnitPrice.ToString("F2"); // Format price as currency
                }
            }
        }
    }
}

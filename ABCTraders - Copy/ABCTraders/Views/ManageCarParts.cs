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
    public partial class ManageCarParts : UserControl
    {

        private CarPartsService carPartsService;
        private int selectedCarPartId = 0;

        public ManageCarParts()
        {
            InitializeComponent();
            this.carPartsService = new CarPartsService();
            LoadCarParts();
        }

        public void refreshGrid()
        {
            LoadCarParts();
        }

        private void LoadCarParts()
        {
            List<CarPart> carParts = carPartsService.GetAllCarParts();
            adminCarPartsMng_gridView.DataSource = carParts;
        }

        private void adminMngCarParts_saveBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(adminMngCarParts_nameInput.Text))
            {
                MessageBox.Show("Name field cannot be empty.");
                return; 
            }

            if (string.IsNullOrWhiteSpace(adminMngCarParts_modelInput.Text))
            {
                MessageBox.Show("Model field cannot be empty.");
                return;
            }

            if (!decimal.TryParse(adminMngCarParts_unitPriceInput.Text, out decimal result))
            {
                MessageBox.Show("Unit Price field cannot be empty.");
                return;
            }

            if (!int.TryParse(adminMngCarParts_qtyInput.Text, out int resultInt))
            {
                MessageBox.Show("Unit Price field cannot be empty.");
                return;
            }


            CarPart carPart = new CarPart
            {
                Name = adminMngCarParts_nameInput.Text,
                Model = adminMngCarParts_modelInput.Text,
                UnitPrice = Convert.ToDecimal(adminMngCarParts_unitPriceInput.Text),
                Quantity = Convert.ToInt32(adminMngCarParts_qtyInput.Text)
            };

            if (carPartsService.InsertCarPart(carPart))
            {
                MessageBox.Show("Car part added successfully!");
                LoadCarParts();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Failed to add car part.");
            }
        }

        private void ClearInputs()
        {
            adminMngCarParts_nameInput.Text = "";
            adminMngCarParts_modelInput.Text = "";
            adminMngCarParts_unitPriceInput.Text = "";
            adminMngCarParts_qtyInput.Text = "";
            selectedCarPartId = 0;
        }

        private void adminMngCarParts_updateBtn_Click(object sender, EventArgs e)
        {
            CarPart carPart = new CarPart
            {
                Id = selectedCarPartId,
                Name = adminMngCarParts_nameInput.Text,
                Model = adminMngCarParts_modelInput.Text,
                UnitPrice = Convert.ToDecimal(adminMngCarParts_unitPriceInput.Text),
                Quantity = Convert.ToInt32(adminMngCarParts_qtyInput.Text)
            };

            if (carPartsService.UpdateCarPart(carPart))
            {
                MessageBox.Show("Car part updated successfully!");
                LoadCarParts();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Failed to update car part.");
            }
        }

        private void adminMngCarParts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedCarPartId > 0)
            {
                if (carPartsService.DeleteCarPart(selectedCarPartId))
                {
                    MessageBox.Show("Car part deleted successfully!");
                    LoadCarParts();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Failed to delete car part.");
                }
            }
            else
            {
                MessageBox.Show("Please select a car part to delete.");
            }
        }

        private void adminCarPartsMng_gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = adminCarPartsMng_gridView.Rows[e.RowIndex];
                selectedCarPartId = Convert.ToInt32(row.Cells["Id"].Value);
                adminMngCarParts_nameInput.Text = row.Cells["Name"].Value.ToString();
                adminMngCarParts_modelInput.Text = row.Cells["Model"].Value.ToString();
                adminMngCarParts_unitPriceInput.Text = row.Cells["UnitPrice"].Value.ToString();
                adminMngCarParts_qtyInput.Text = row.Cells["Quantity"].Value.ToString();
            }
        }
    }
}

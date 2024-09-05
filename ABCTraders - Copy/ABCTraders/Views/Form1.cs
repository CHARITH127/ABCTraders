using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABCTraders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["CarTraderDB"].ConnectionString;

            string userName = login_username.Text;
            string password = login_password.Text;

            string selectQuery = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@Username", userName);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string role = reader["Role"].ToString();

                                if (role == "admin")
                                {
                                    // Display a success message and open the appropriate form
                                    MessageBox.Show($"Login successful! Welcome, {role}.");

                                    // Navigate to the admin panel
                                    AdminMainPanel adminMainPanel = new AdminMainPanel();
                                    adminMainPanel.Show();
                                    this.Hide();

                                }
                                else if (role == "customer")
                                {

                                    // Display a success message and open the appropriate form
                                    MessageBox.Show($"Login successful! Welcome, {role}.");

                                    // Navigate to the customer panel
                                    CustomerDashboard customerDashboard = new CustomerDashboard(userName);
                                    customerDashboard.SetUsername(userName);
                                    customerDashboard.Show(); 
                                    
                                    

                                    this.Hide();
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            
        }

        private void login_registerNavBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

    }
}

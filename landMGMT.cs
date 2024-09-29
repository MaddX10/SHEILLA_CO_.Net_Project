using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SHEILLA_COMPANY
{
    public partial class landMGMT : Form
    {
        public landMGMT()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveLandDetails_Click(object sender, EventArgs e)
        {
            // Connection string to the database
            SqlConnection conn = new SqlConnection("Data Source = RRA-HQ-ITD-7LK6\\SQLEXPRESS; Initial Catalog = SHEILLA_DB; Integrated Security = True; Encrypt = True; TrustServerCertificate = True");

            // Get the data from the textboxes
            string upi = LandUPITxt.Text;
            string type = LandTypeTxt.Text;
            string size = LandSizeTxt.Text;
            string location = LandLocationTxt.Text;
            string description = LandDescriptionTxt.Text;

            try
            {
                // Open the connection
                conn.Open();

                // Validate size input
                if (!float.TryParse(size, out float sizeNum))
                {
                    MessageBox.Show("Size must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // SQL Insert Query with Parameters
                    string query = "INSERT INTO LAND (UPI, type, size, location, description) VALUES (@upi, @type, @size, @location, @description)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@upi", upi);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@size", sizeNum); // Use the float value
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@description", description);

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error saving data.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

    }
}

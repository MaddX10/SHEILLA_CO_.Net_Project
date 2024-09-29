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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Credentials
            string emailAddress = emailTxt.Text.Trim();
            string userPassword = passwordTxt.Text.Trim();

            // Hash the input password to compare with the hashed password in the database
            string hashedPassword = HashPassword(userPassword);

            // Connection string to the database
            using (SqlConnection conn = new SqlConnection("Data Source=RRA-HQ-ITD-7LK6\\SQLEXPRESS; Initial Catalog=SHEILLA_DB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True"))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // SQL Query to check for valid credentials
                    string query = "SELECT COUNT(*) FROM USERS WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", emailAddress);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    // Execute the command
                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Redirect to land MGMT
                        landMGMT landPage = new landMGMT();
                        landPage.Show();
                        this.Hide(); // Optionally hide the current form
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hashing method to hash the password using SHA-256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the password
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //redirect to Signup
            Signup signUpPage = new Signup();
            signUpPage.Show();
        }
    }
}

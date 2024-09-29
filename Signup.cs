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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void SignUp_Click(object sender, EventArgs e)
        {
            // Connection string to the database
            SqlConnection conn = new SqlConnection("Data Source=RRA-HQ-ITD-7LK6\\SQLEXPRESS; Initial Catalog=SHEILLA_DB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");

            // Get the data from the textboxes
            string firstName = FirstNameTxt.Text;
            string lastName = LastNameTxt.Text;
            string gender = GenderTxt.Text;
            string address = AddressTxt.Text;
            string email = EmailTxt.Text;
            string phone = PhoneTxt.Text;
            string password = PasswordTxt.Text;
            string confirmPassword = ConfirmPasswordTxt.Text;

            try
            {
                // Open the connection
                conn.Open();

                // Validate that the phone number is numeric
                if (!int.TryParse(phone, out int PhoneNum))
                {
                    MessageBox.Show("Phone must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate that password and confirm password match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hash the password before saving it to the database
                string hashedPassword = HashPassword(password);

                // SQL Insert Query with Parameters
                string query = "INSERT INTO USERS (FirstName, LastName, Address, Gender, Email, Phone, Password) VALUES (@firstName, @lastName, @gender, @address, @email, @phone, @password)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", PhoneNum); // Use the integer value for phone
                cmd.Parameters.AddWithValue("@password", hashedPassword); // Use the hashed password

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account created successfully!");
                }
                else
                {
                    MessageBox.Show("Error creating account.");
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
    }
}

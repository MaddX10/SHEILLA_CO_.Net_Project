using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            // credentials
            string emailAddress = emailTxt.Text.Trim();
            string userPassword = passwordTxt.Text.Trim();

            // validate credentials
            if (emailAddress == "admin@sheilla.com" && userPassword == "123")
            {
                //redirect to land MGMT
                landMGMT landPage = new landMGMT();
                landPage.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
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

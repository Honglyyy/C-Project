using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Return
{
    public partial class loginForm : Form
    {
        public static string username;   
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string password = passwordTxt.Text;
            username = usernameTxt.Text;

            if ((username == "admin" || username == "manager") && password == "123")
            {
                this.DialogResult = DialogResult.OK; // Success
                this.Close(); // Close login
            }
            else
            {
                MessageBox.Show("Invalid Identity", "Error");
            }

        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

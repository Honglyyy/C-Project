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
        
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username, password;
            username = usernameTxt.Text;
            password = passwordTxt.Text;

            if (username == "admin" || username == "Admin" && password == "123") { 
                MainMenuForm form = new MainMenuForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid Identity","Error");
            }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

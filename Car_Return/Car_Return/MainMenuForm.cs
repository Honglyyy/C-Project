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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            uC_Cover1.BringToFront();
        }
        private void customerBtn_Click(object sender, EventArgs e)
        {
            uC_Customer1.BringToFront();
        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            uC_Car1.BringToFront();
        }
    }
}

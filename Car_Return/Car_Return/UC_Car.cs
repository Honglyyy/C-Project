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
    public partial class UC_Car : UserControl
    {
        public UC_Car()
        {
            InitializeComponent();
        }

        private void priusBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Prius_Full;
        }

        private void lexusBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Lexus_Full;
        }

        private void hondaBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Civic_Full;
        }

        private void hyundaiBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Hyundai_full;
        }

        private void nissanBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Nissan_Full;
        }

        private void toyotaBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Corolla_FUll;
        }

        private void fordBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Ford_Full;
        }

        private void audiBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Audi_Full;
        }

        private void alphardBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Car_Return.Properties.Resources.Alphard_Full;
        }
    }
}

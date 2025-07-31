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
    public partial class UC_Return : UserControl
    {
        private int rent = 0;

        
        int[] rentPrices = {
        52, 50, 48, 45, 90, 85, 80, 78, 66, 62,
        58, 55, 58, 55, 52, 50, 65, 63, 60, 58,
        72, 70, 69, 65, 80, 75, 72, 70, 95, 90,
        85, 82, 130, 122, 120, 114
    };

        double[] damageRates = { 0.0, 0.3, 0.5, 1.0 };

        public UC_Return()
        {
            InitializeComponent();
            cmbDamage.SelectedIndex = 0;
        }

        private void CmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CmbCar.SelectedIndex;

            if (index >= 0 && index < rentPrices.Length)
            {
                rent = rentPrices[index];
                TxtRent.Text = rent.ToString("C2");
            }
            else
            {
                MessageBox.Show("Invalid car selection.");
                rent = 0;
                TxtRent.Text = "";
            }
        }

        private void totalBtn_Click(object sender, EventArgs e)
        {
            string cusName = TxtCustomerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(cusName))
            {
                MessageBox.Show("Please enter the customer's name.", "Missing Information");
                return;
            }

            if (CmbCar.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car.", "Missing Information");
                return;
            }

            if (!int.TryParse(TxtLate.Text, out int lateDays) || lateDays < 0)
            {
                MessageBox.Show("Please enter a valid number of late days.", "Input Error");
                return;
            }

            if (cmbDamage.SelectedIndex < 0 || cmbDamage.SelectedIndex >= damageRates.Length)
            {
                MessageBox.Show("Please select a valid damage option.", "Invalid Selection");
                return;
            }

            double lateFee = lateDays * rent * 0.1;
            double damageFee = rent * damageRates[cmbDamage.SelectedIndex];
            double total = rent + lateFee + damageFee;

            txtBasicFee.Text = rent.ToString("C2");
            txtLateFee.Text = lateFee.ToString("C2");
            txtDamageFee.Text = damageFee.ToString("C2");
            txtTotalFee.Text = total.ToString("C2");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            TxtCustomerName.Text = "";
            CmbCar.SelectedIndex = -1;
            TxtRent.Text = "";
            TxtLate.Text = "";
            cmbDamage.SelectedIndex = 0;
            txtBasicFee.Text = "";
            txtLateFee.Text = "";
            txtDamageFee.Text = "";
            txtTotalFee.Text = "";
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            string customerName = TxtCustomerName.Text;
            string carName = CmbCar.SelectedItem?.ToString() ?? "N/A";
            string rentFee = txtBasicFee.Text;
            string lateFee = txtLateFee.Text;
            string damageFee = txtDamageFee.Text;
            string totalFee = txtTotalFee.Text;
            string lateDays = TxtLate.Text + " days";
            string damageStatus = cmbDamage.SelectedItem?.ToString() ?? "N/A";

            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("----- Car Return Receipt -----");
            receipt.AppendLine($"Customer Name: {customerName}");
            receipt.AppendLine($"Car: {carName}");
            receipt.AppendLine($"Rent Fee: {rentFee}");
            receipt.AppendLine($"Late Days: {lateDays}");
            receipt.AppendLine($"Late Fee: {lateFee}");
            receipt.AppendLine($"Damage Status: {damageStatus}");
            receipt.AppendLine($"Damage Fee: {damageFee}");
            receipt.AppendLine("------------------------------");
            receipt.AppendLine($"Total Fee: {totalFee}");
            receipt.AppendLine("------------------------------");
            receipt.AppendLine("Thank you for using our service!");

            MessageBox.Show(receipt.ToString(), "Receipt");
        }
    }

}

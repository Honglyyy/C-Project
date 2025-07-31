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

        public UC_Return()
        {
            InitializeComponent();
            cmbDamage.SelectedIndex = 0;
        }

        private void CmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCarIndex = CmbCar.SelectedIndex;
            switch (selectedCarIndex)
            {
                case 0: rent = 52; break;
                case 1: rent = 50; break;
                case 2: rent = 48; break;
                case 3: rent = 45; break;
                case 4: rent = 90; break;
                case 5: rent = 85; break;
                case 6: rent = 80; break;
                case 7: rent = 78; break;
                case 8: rent = 66; break;
                case 9: rent = 62; break;
                case 10: rent = 58; break;
                case 11: rent = 55; break;
                case 12: rent = 58; break;
                case 13: rent = 55; break;
                case 14: rent = 52; break;
                case 15: rent = 50; break;
                case 16: rent = 65; break;
                case 17: rent = 63; break;
                case 18: rent = 60; break;
                case 19: rent = 58; break;
                case 20: rent = 72; break;
                case 21: rent = 70; break;
                case 22: rent = 69; break;
                case 23: rent = 65; break;
                case 24: rent = 80; break;
                case 25: rent = 75; break;
                case 26: rent = 72; break;
                case 27: rent = 70; break;
                case 28: rent = 95; break;
                case 29: rent = 90; break;
                case 30: rent = 85; break;
                case 31: rent = 82; break;
                case 32: rent = 130; break;
                case 33: rent = 122; break;
                case 34: rent = 120; break;
                case 35: rent = 114; break;
                default:
                    MessageBox.Show("Invalid selection.");
                    rent = 0;
                    break;
            }
            TxtRent.Text = rent.ToString("C2");
        }

        private void totalBtn_Click(object sender, EventArgs e)
        {
            string cusName = TxtCustomerName.Text.Trim();

            // Validate required fields
            if (string.IsNullOrWhiteSpace(cusName))
            {
                MessageBox.Show("Please enter the customer's name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbCar.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TxtLate.Text, out int lateDays) || lateDays < 0)
            {
                MessageBox.Show("Please enter a valid number of late days.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double lateFee = lateDays * rent * 0.1;
            double damageFee = 0;
            double total = 0;

            switch (cmbDamage.SelectedIndex)
            {
                case 0: // No damage
                    damageFee = 0;
                    break;
                case 1: // Minor damage
                    damageFee = rent * 0.3;
                    break;
                case 2: // Major damage
                    damageFee = rent * 0.5;
                    break;
                case 3: // Total loss
                    damageFee = rent * 1.0;
                    break;
                default:
                    MessageBox.Show("Please select a valid damage option.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            total = rent + lateFee + damageFee;

            // Display results
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

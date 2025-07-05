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
        public string carName, plateNum, year, status, dailyRates;


        private void priusBtn_Click(object sender, EventArgs e)
        {
            carName = "Toyota Prius";
            modelNameTxt.Text = carName.ToString();

            // Clear previous data
            dataGridView1.Rows.Clear();

            // Add multiple records with alternating status
            dataGridView1.Rows.Add("Toyota Prius", "ABC1234", "2020", "Available", "$50");
            dataGridView1.Rows.Add("Toyota Prius", "ABC1235", "2021", "Not Available", "$52");
            dataGridView1.Rows.Add("Toyota Prius", "ABC1236", "2019", "Available", "$48");
            dataGridView1.Rows.Add("Toyota Prius", "ABC1237", "2022", "Not Available", "$55");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Prius_Full;
        }

        private void lexusBtn_Click(object sender, EventArgs e)
        {
            carName = "Lexus RX 350";
            modelNameTxt.Text = carName.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Lexus RX 350", "XYZ5678", "2021", "Available", "$80");
            dataGridView1.Rows.Add("Lexus RX 350", "XYZ5679", "2020", "Not Available", "$78");
            dataGridView1.Rows.Add("Lexus RX 350", "XYZ5680", "2022", "Available", "$85");
            dataGridView1.Rows.Add("Lexus RX 350", "XYZ5681", "2023", "Not Available", "$90");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Lexus_Full;
        }

        private void hondaBtn_Click(object sender, EventArgs e)
        {
            carName = "Honda Civic";
            modelNameTxt.Text = carName.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Honda Civic", "LMN9012", "2019", "Available", "$60");
            dataGridView1.Rows.Add("Honda Civic", "LMN9013", "2020", "Not Available", "$62");
            dataGridView1.Rows.Add("Honda Civic", "LMN9014", "2021", "Available", "$65");
            dataGridView1.Rows.Add("Honda Civic", "LMN9015", "2018", "Not Available", "$58");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Civic_Full;
        }

        private void hyundaiBtn_Click(object sender, EventArgs e)
        {
            carName = "Hyundai Elantra";
            modelNameTxt.Text = carName.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Hyundai Elantra", "QRS3456", "2022", "Available", "$55");
            dataGridView1.Rows.Add("Hyundai Elantra", "QRS3457", "2021", "Not Available", "$53");
            dataGridView1.Rows.Add("Hyundai Elantra", "QRS3458", "2020", "Available", "$52");
            dataGridView1.Rows.Add("Hyundai Elantra", "QRS3459", "2023", "Not Available", "$58");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Hyundai_full;
        }

        private void nissanBtn_Click(object sender, EventArgs e)
        {
            carName = "Nissan Altima";
            modelNameTxt.Text = carName.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Nissan Altima", "TUV7890", "2023", "Not Available", "$65");
            dataGridView1.Rows.Add("Nissan Altima", "TUV7891", "2022", "Available", "$63");
            dataGridView1.Rows.Add("Nissan Altima", "TUV7892", "2021", "Not Available", "$60");
            dataGridView1.Rows.Add("Nissan Altima", "TUV7893", "2020", "Available", "$58");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Nissan_Full;
        }

        private void UC_Car_Load(object sender, EventArgs e)
        {

        }

        private void toyotaBtn_Click(object sender, EventArgs e)
        {
            carName = "Toyota Corolla";
            modelNameTxt.Text = carName.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Toyota Corolla", "WXY1234", "2021", "Available", "$70");
            dataGridView1.Rows.Add("Toyota Corolla", "WXY1235", "2020", "Available", "$68");
            dataGridView1.Rows.Add("Toyota Corolla", "WXY1236", "2022", "Not Available", "$72");
            dataGridView1.Rows.Add("Toyota Corolla", "WXY1237", "2019", "Available", "$65");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Corolla_FUll;
        }

        private void fordBtn_Click(object sender, EventArgs e)
        {
            carName = "Ford Focus";
            modelNameTxt.Text = carName.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Ford Focus", "ZAB5678", "2020", "Not Available", "$75");
            dataGridView1.Rows.Add("Ford Focus", "ZAB5679", "2021", "Available", "$78");
            dataGridView1.Rows.Add("Ford Focus", "ZAB5680", "2019", "Not Available", "$72");
            dataGridView1.Rows.Add("Ford Focus", "ZAB5681", "2022", "Available", "$80");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Ford_Full;
        }

        private void audiBtn_Click(object sender, EventArgs e)
        {
            carName = "Audi A4";
            modelNameTxt.Text = carName.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Audi A4", "CDE9012", "2022", "Not Available", "$90");
            dataGridView1.Rows.Add("Audi A4", "CDE9013", "2021", "Available", "$88");
            dataGridView1.Rows.Add("Audi A4", "CDE9014", "2023", "Available", "$95");
            dataGridView1.Rows.Add("Audi A4", "CDE9015", "2020", "Available", "$85");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Audi_Full;
        }

        private void alphardBtn_Click(object sender, EventArgs e)
        {
            carName = "Toyota Alphard";
            modelNameTxt.Text = carName.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Toyota Alphard", "FGH3456", "2023", "Available", "$120");
            dataGridView1.Rows.Add("Toyota Alphard", "FGH3457", "2022", "Not Available", "$122");
            dataGridView1.Rows.Add("Toyota Alphard", "FGH3458", "2021", "Not Available", "$125");
            dataGridView1.Rows.Add("Toyota Alphard", "FGH3459", "2020", "Not Available", "$130");

            pictureBox1.Image = global::Car_Return.Properties.Resources.Alphard_Full;
        }
    }
}

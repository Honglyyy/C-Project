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
    public partial class UC_Customer : UserControl
    {
        string fullName, id, phoneNumber, emailAddress;
        bool isEditMode = false;

        public UC_Customer()
        {
            InitializeComponent();
            LoadDefaultData(); // Load default data when the control is initialized
        }

        // Method to load default customer data
        private void LoadDefaultData()
        {
            // Clear any existing data first
            dataGridView1.Rows.Clear();

            // Add sample customers
            dataGridView1.Rows.Add("John Smith", "C001", "555-0123", "john.smith@email.com");
            dataGridView1.Rows.Add("Sarah Johnson", "C002", "555-0456", "sarah.johnson@email.com");
            dataGridView1.Rows.Add("Michael Brown", "C003", "555-0789", "michael.brown@email.com");
            dataGridView1.Rows.Add("Emily Davis", "C004", "555-0321", "emily.davis@email.com");
            dataGridView1.Rows.Add("David Wilson", "C005", "555-0654", "david.wilson@email.com");
            dataGridView1.Rows.Add("Lisa Anderson", "C006", "555-0987", "lisa.anderson@email.com");
            dataGridView1.Rows.Add("Robert Taylor", "C007", "555-0147", "robert.taylor@email.com");
            dataGridView1.Rows.Add("Jennifer Martinez", "C008", "555-0258", "jennifer.martinez@email.com");
            dataGridView1.Rows.Add("Christopher Lee", "C009", "555-0369", "christopher.lee@email.com");
            dataGridView1.Rows.Add("Amanda White", "C010", "555-0741", "amanda.white@email.com");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            fullName = txtFullName.Text.Trim();
            id = txtId.Text.Trim();
            phoneNumber = txtPhoneNumber.Text.Trim();
            emailAddress = txtEmailAddress.Text.Trim();

            if (fullName == "" || id == "" || phoneNumber == "" || emailAddress == "")
            {
                MessageBox.Show("Input all the information", "Warning");
            }
            else
            {
                dataGridView1.Rows.Add(fullName, id, phoneNumber, emailAddress);
                if (isEditMode)
                {
                    isEditMode = false;
                    btnAdd.Text = "Add";
                    MessageBox.Show("Customer updated successfully!", "Updated");
                }
                else
                {
                    MessageBox.Show("Customer added successfully!", "Added");
                }
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtId.Clear();
            txtPhoneNumber.Clear();
            txtEmailAddress.Clear();
            txtSearch.Clear();

            if (isEditMode)
            {
                isEditMode = false;
                btnAdd.Text = "Add";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter something to search for.");
                return;
            }

            bool found = false;

            // Clear previous highlights
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            // Search and highlight matches
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString().ToLower().Contains(searchTerm.ToLower()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow; // Highlight
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("No results found.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Fill the text boxes with the selected row data
                txtFullName.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                txtId.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                txtPhoneNumber.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                txtEmailAddress.Text = selectedRow.Cells[3].Value?.ToString() ?? "";

                // Remove the selected row so user can add it back with modifications
                dataGridView1.Rows.RemoveAt(selectedRow.Index);

                // Set edit mode and change button text
                isEditMode = true;
                btnAdd.Text = "Update";


            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the selected row
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Customer deleted successfully!", "Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Optional: Method to reset data to default (you can call this from a button if needed)
        public void ResetToDefaultData()
        {
            LoadDefaultData();
        }
    }
}
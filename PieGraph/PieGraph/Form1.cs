using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PieGraph
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            // Subscribe to the KeyPress event for the txtValue TextBox
            txtValue.KeyPress += new KeyPressEventHandler(txtValue_KeyPress);
        }

        // Event handler for the Generate Chart button click
        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            List<float> values = new List<float>(); // List to store values for the pie chart
            List<string> labels = new List<string>(); // List to store labels corresponding to the values

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if both the label and value cells are not null
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string label = row.Cells[0].Value.ToString(); // Get the label from the first cell
                    // Try to parse the value from the second cell and check if it is positive
                    if (float.TryParse(row.Cells[1].Value.ToString(), out float value) && value > 0)
                    {
                        labels.Add(label); // Add the label to the labels list
                        values.Add(value); // Add the value to the values list
                    }
                    else
                    {
                        // Show warning if the value is not a valid positive number
                        MessageBox.Show("Please enter a valid positive number for all values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if the input is invalid
                    }
                }
            }

            // Check if the number of labels matches the number of values
            if (labels.Count != values.Count)
            {
                // Show warning if there is a mismatch
                MessageBox.Show("Each label must have a corresponding valid value.", "Mismatched Labels and Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if there is a mismatch
            }

            // Assign the collected values and labels to the pie chart control
            pieChartControl1.Values = values;
            pieChartControl1.Labels = labels;
            pieChartControl1.Invalidate(); // Refreshes the pie chart to display updated data
        }

        // Event handler for the Add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView already has 15 rows
            if (dataGridView1.Rows.Count >= 15)
            {
                // Show warning if the maximum number of entries is reached
                MessageBox.Show("You can only add up to 15 values.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the limit is reached
            }

            string label = txtLabel.Text; // Get the label text
            // Try to parse the value from txtValue and ensure the label is not empty
            if (float.TryParse(txtValue.Text, out float value) && !string.IsNullOrEmpty(label))
            {
                // Add the new label and value to the DataGridView
                dataGridView1.Rows.Add(label, value);
                txtLabel.Clear(); // Clear the label input field
                txtValue.Clear(); // Clear the value input field
            }
            else
            {
                // Show warning if the input is invalid
                MessageBox.Show("Please enter a valid label and positive value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for the Reset button click
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView
            dataGridView1.Rows.Clear();

            // Clear the input text fields
            txtLabel.Clear();
            txtValue.Clear();

            // Clear the pie chart values and labels
            pieChartControl1.Values.Clear();
            pieChartControl1.Labels.Clear();
            pieChartControl1.Invalidate(); // Refresh the pie chart to show no data
        }

        // Event handler for KeyPress event in the txtValue TextBox
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace)
            if (char.IsControl(e.KeyChar))
            {
                return; // Allow the control character
            }

            // Allow digits
            if (char.IsDigit(e.KeyChar))
            {
                return; // Allow digit input
            }

            // Allow one decimal point
            if (e.KeyChar == '.' && !txtValue.Text.Contains("."))
            {
                return; // Allow decimal point if not already present
            }

            // If none of the conditions above are met, suppress the key press
            e.Handled = true;
        }
    }
}

using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace UI
{
    public partial class TransactionRecording : Form
    {
        public TransactionRecording()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransactionRecording_Load(object sender, EventArgs e)
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var products = context.Products.ToList();
                cmbProductSelection.DataSource = products;
                cmbProductSelection.DisplayMember = "ProductName";  // Name to display in the combo box
                cmbProductSelection.ValueMember = "ProductId";      // Value to use in the transaction
            }
        }

        private bool ValidateTransactionInputs()
        {
            if (cmbProductSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbTransactionType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a transaction type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearTransactionInputs()
        {
            cmbProductSelection.SelectedIndex = -1;
            txtQuantity.Clear();
            cmbTransactionType.SelectedIndex = -1; // Or clear radio buttons
            dateTimePicker1.Value = DateTime.Now;
            txtNotes.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateTransactionInputs())
            {
                try
                {
                    var transaction = new Transaction
                    {
                        ProductId = (int)cmbProductSelection.SelectedValue,
                        Quantity = int.Parse(txtQuantity.Text),
                        TransactionType = cmbTransactionType.Text == "Sale" ? 'S' : 'P',
                        Notes = txtNotes.Text
                    };

                    using (var context = new InventoryManagementSystemContext())
                    {
                        context.Transactions.Add(transaction);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Transaction recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optionally, clear the inputs after saving
                    ClearTransactionInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

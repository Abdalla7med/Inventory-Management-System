using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            using (var context = new InventoryManagementSystemContext())
            {

                // Bind the ComboBox to the category list
                cmbCatogries.DataSource = context.Products.ToList() ;
                cmbCatogries.DisplayMember = "CategoryName";  // The property to display
                cmbCatogries.ValueMember = "CategoryId";      // The property to use as the actual value
            }

            cmbCatogries.SelectedIndex = 0; // default 
            InitializeComponent();
            using (var context = new InventoryManagementSystemContext())
            {
                var products = context.Products.ToList();
                dataGridView1.DataSource = products;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedCategory = cmbCatogries.SelectedValue;

            if (selectedCategory != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int productId = (int)dataGridView1.SelectedRows[0].Cells["ProductId"].Value;

                    using (var context = new InventoryManagementSystemContext())
                    {
                        var product = context.Products.Find(productId);
                        if (product != null)
                        {
                            context.Products.Remove(product);
                            context.SaveChanges();
                        }
                    }

                    LoadProducts(); // Refresh the product list
                    ClearFormFields(); // Clear input fields after deleting
                }
            }
            else
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearFormFields()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                // Add more cases if you have other types of controls to clear
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadProducts()
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var products = context.Products
                    .Include(p => p.Category)
                    .Select(p => new
                    {
                        p.ProductId,
                        p.Name,
                        p.price,
                        CategoryName = p.Category.CategoryName, // Assuming Category has a Name property
                        p.Description
                    })
                    .ToList();

                dataGridView1.DataSource = products;
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var selectedCategory = cmbCatogries.SelectedValue;

            if (selectedCategory != null)
            {
                int productId = (int)dataGridView1.SelectedRows[0].Cells["ProductId"].Value;

                using (var context = new InventoryManagementSystemContext())
                {
                    var product = context.Products.Find(productId);
                    if (product != null)
                    {
                        product.Name = txtProductName.Text;
                        product.price = decimal.Parse(txtProductPrice.Text);
                        product.Description = txtProductDescription.Text;
                        product.Category.CategoryName = txtProductCatogry.Text;
                        context.SaveChanges();
                    }
                }

                LoadProducts(); // Refresh the product list
                ClearFormFields(); // Clear input fields after editing
            }
            else
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ValidateProductInputs()
        {
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtProductPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            var selectedCategory = cmbCatogries.SelectedValue;

            if (selectedCategory != null)
            {
                try
                {
                    // Create a new product object
                    var newProduct = new Product
                    {
                        Name = txtProductName.Text,
                        price = decimal.Parse(txtProductPrice.Text),
                        Description = txtProductDescription.Text,
                        // Add other necessary fields
                    };

                    // Add the new product to the database (Entity Framework Core example)
                    using (var context = new InventoryManagementSystemContext())
                    {
                        context.Products.Add(newProduct);
                        context.SaveChanges(); // Save changes to the database
                    }

                    // Update the UI - refresh the product list
                    LoadProducts();

                    // Clear the input fields
                    ClearFormFields();

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
            var selectedCategory = cmbCatogries.SelectedItem as Category;

            if (selectedCategory != null)
            {
                MessageBox.Show($"You selected: {selectedCategory.CategoryName}");

                // You can now use selectedCategory.CategoryId or selectedCategory.CategoryName as needed
            }
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}

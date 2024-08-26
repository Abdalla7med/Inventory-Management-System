using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // Populate Category ComboBox
            using (var context = new InventoryManagementSystemContext())
            {
                var categories = context.Categories.Select(c => c.CategoryName).ToList();
                cmbCategory.Items.AddRange(categories.ToArray());
                cmbCategory.Items.Insert(0, "All"); // Option to search all categories
                cmbCategory.SelectedIndex = 0;
            }

            // Set default dates
            dtpDateAddedFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateAddedTo.Value = DateTime.Now;
        }

        private void SearchScreen_Load(object sender, EventArgs e)
        {
            // Populate Category ComboBox
            using (var context = new InventoryManagementSystemContext())
            {
                var categories = context.Categories.Select(c => c.CategoryName).ToList();
                cmbCategory.Items.AddRange(categories.ToArray());
                cmbCategory.Items.Insert(0, "All"); // Option to search all categories
                cmbCategory.SelectedIndex = 0;
            }

            // Set default dates
            dtpDateAddedFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateAddedTo.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var query = context.Products.AsQueryable();

                // Filter by Product Name
                if (!string.IsNullOrEmpty(txtProductName.Text))
                {
                    query = query.Where(p => p.Name.Contains(txtProductName.Text));
                }

                // Filter by Category
                if (cmbCategory.SelectedIndex > 0)
                {
                    string selectedCategory = cmbCategory.SelectedItem.ToString();
                    query = query.Where(p => p.Category.CategoryName == selectedCategory);
                }

                // Filter by Price Range
                if (decimal.TryParse(txtPriceMin.Text, out decimal minPrice))
                {
                    query = query.Where(p => p.price >= minPrice);
                }
                if (decimal.TryParse(txtPriceMax.Text, out decimal maxPrice))
                {
                    query = query.Where(p => p.price <= maxPrice);
                }


                // Execute query and display results
                var results = query.ToList();
                dataGridView1.DataSource = results;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtProductName.Clear();
            txtPriceMin.Clear();
            txtPriceMax.Clear();
            cmbCategory.SelectedIndex = 0;
            dtpDateAddedFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateAddedTo.Value = DateTime.Now;

            // Clear DataGridView
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

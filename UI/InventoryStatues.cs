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
    public partial class InventoryStatues : Form
    {
        public InventoryStatues()
        {
            InitializeComponent();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void PopulateCategoryFilter()
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var categories = context.Products.Select(p => p.Category).Distinct().ToList();
                cmbCategory.Items.AddRange(categories.ToArray());
                cmbCategory.Items.Insert(0, "All"); // To show all products by default
                cmbCategory.SelectedIndex = 0; // Select "All" by default
            }
        }

        private void LoadInventoryData()
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var products = context.Products.ToList();
                dataGridView1.DataSource = products.Select(p => new
                {
                    p.Name,
                    p.Category,
                    p.price
                }).ToList();

                var inventories = context.Inventory.ToList();

                dataGridView1.DataSource = inventories.Select(I => new
                {
                    I.Quantity
                }
               ).ToList();
            }

        }

        private void ApplyFilters()
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var query = context.Products.AsQueryable();
                var query2 = context.Inventory.AsQueryable();

                // Filter by CategoryNAME
                if (cmbCategory.SelectedItem.ToString() != "All")
                {
                    query = query.Where(p => p.Category.CategoryName == cmbCategory.SelectedItem.ToString());
                }

                // Search by Name 
                if (!string.IsNullOrEmpty(txtSearchProduct.Text))
                {
                    query = query.Where(p => p.Name.Contains(txtSearchProduct.Text));
                }

                // Filter by Low Stock
                if (checkBox1.Checked)
                {
                    query2 = query2.Where(p => p.Quantity < 10); // Or any other threshold
                }

                dataGridView1.DataSource = query.Select(p => new
                {
                    p.Name,
                    p.Category,

                }).ToList();

                dataGridView1.DataSource = query2.Select(I => new { I.Quantity }).ToList();
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void InventoryStatues_Load(object sender, EventArgs e)
        {
            PopulateCategoryFilter();
            LoadInventoryData();

        }
    }
}

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
    public partial class CatogryManagement : Form
    {
        public CatogryManagement()
        {
            InitializeComponent();
        }

        private void CatogryManagement_Load(object sender, EventArgs e)
        {
            Load_Categories();
        }
        private void Load_Categories()
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var categories = context.Categories.Select(c => new
                {
                    c.CategoryName,
                }).ToList();

                dataGridView1.DataSource = categories;
            }
        }
        private void ClearInputFields()
        {
            //clear input text
            txtCateogryName.Text = string.Empty;
        }

        private void btnAddCateogry_Click(object sender, EventArgs e)
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var Cateogry = new Category
                {
                    CategoryName = txtCateogryName.Text
                };
                context.Categories.Add(Cateogry);
                context.SaveChanges();
            }
            Load_Categories();//Refresh the list
            ClearInputFields();
        }
        private void btnEditCateogry_Click(object sender, EventArgs e)
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var selectedCategoryName = dataGridView1.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                var category = context.Categories.FirstOrDefault(c => c.CategoryName == selectedCategoryName);

                if (category != null)
                {
                    category.CategoryName = txtCateogryName.Text;
                    context.SaveChanges();
                }
            }
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (var context = new InventoryManagementSystemContext())
                {
                    var selectedCategoryName = dataGridView1.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                    var category = context.Categories.FirstOrDefault(c => c.CategoryName == selectedCategoryName);

                    if (category != null)
                    {
                        context.Categories.Remove(category);
                        context.SaveChanges();
                    }
                }

                Load_Categories(); // Refresh the list of categories
                ClearInputFields(); // Clear the input fields after deleting a category
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedrow = dataGridView1.SelectedRows[0];
                txtCateogryName.Text = selectedrow.Cells["CategoryName"].Value.ToString();
            }
        }

        private void txtCateogryName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

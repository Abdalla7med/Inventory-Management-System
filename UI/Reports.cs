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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }





        //Populate ComboBoxes Programmatically


        private void Reports_Load(object sender, EventArgs e)
        {
            ReportsScreen_Load();
        }
        private void PopulateCategoryFilter()
        {
            using (var context = new InventoryManagementSystemContext())
            {
                var categories = context.Categories.Select(c => c.CategoryName).ToList();
                cmbCateogryFilter.Items.AddRange(categories.ToArray());
                cmbCateogryFilter.Items.Insert(0, "All");
                cmbCateogryFilter.SelectedIndex = 0;
            }
        }

        private void ReportsScreen_Load()
        {
            PopulateCategoryFilter();
            cmbReportType.Items.AddRange(new string[]
            {
        "Current Inventory Status",
        "Transaction History",
        "Category-wise Balance and Value Report"
            });
            cmbReportType.SelectedIndex = 0;
        }


        //Handle Button Click Events
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedReport = cmbReportType.SelectedItem.ToString();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string selectedCategory = cmbCateogryFilter.SelectedItem.ToString();

            // Example logic for fetching report data based on selected filters
            using (var context = new InventoryManagementSystemContext())
            {
                var reportData = new List<object>();

                if (selectedReport == "Transaction History")
                {
                    reportData = context.Transactions
                        .Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate)
                        .ToList<object>();
                }
                else if (selectedReport == "Current Inventory Status")
                {
                    reportData = context.Products
                        .Where(p => selectedCategory == "All" || p.Category.CategoryName == selectedCategory)
                        .ToList<object>();
                }


                dataGridView1.DataSource = reportData;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PDF Files|*.pdf|Excel Files|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                // Logic to export dgvReportResults to the chosen file format
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // Logic to preview the report data (could involve displaying a PrintPreviewDialog)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

namespace UI
{
    partial class InventoryStatues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbCategory = new ComboBox();
            txtSearchProduct = new TextBox();
            lblSearchProduct = new Label();
            checkBox1 = new CheckBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-8, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(932, 303);
            dataGridView1.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.BurlyWood;
            cmbCategory.ForeColor = SystemColors.InactiveCaptionText;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(472, 40);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 1;
            cmbCategory.Text = "Cateogry";
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(141, 40);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(120, 27);
            txtSearchProduct.TabIndex = 2;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.BackColor = Color.BurlyWood;
            lblSearchProduct.Location = new Point(12, 40);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(111, 20);
            lblSearchProduct.TabIndex = 3;
            lblSearchProduct.Text = "ProductName : ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.BurlyWood;
            checkBox1.Location = new Point(12, 114);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(166, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "ShowLowStockItems";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.BurlyWood;
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(710, 80);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(158, 41);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // InventoryStatues
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(915, 476);
            Controls.Add(btnRefresh);
            Controls.Add(checkBox1);
            Controls.Add(lblSearchProduct);
            Controls.Add(txtSearchProduct);
            Controls.Add(cmbCategory);
            Controls.Add(dataGridView1);
            Name = "InventoryStatues";
            Text = "InventoryStatues";
            Load += InventoryStatues_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbCategory;
        private TextBox txtSearchProduct;
        private Label lblSearchProduct;
        private CheckBox checkBox1;
        private Button btnRefresh;
    }
}
namespace UI
{
    partial class ProductManagement
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
            lblProductName = new Label();
            lblProductPrice = new Label();
            lblProductDescription = new Label();
            lblProductCatogry = new Label();
            txtProductName = new TextBox();
            txtProductCatogry = new TextBox();
            txtProductDescription = new TextBox();
            txtProductPrice = new TextBox();
            btn_AddProduct = new Button();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            cmbCatogries = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.BurlyWood;
            lblProductName.Location = new Point(12, 39);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(107, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "ProductName :";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.BackColor = Color.BurlyWood;
            lblProductPrice.Location = new Point(292, 39);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(99, 20);
            lblProductPrice.TabIndex = 1;
            lblProductPrice.Text = "ProductPrice :";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.BackColor = Color.BurlyWood;
            lblProductDescription.Location = new Point(12, 89);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(143, 20);
            lblProductDescription.TabIndex = 2;
            lblProductDescription.Text = "ProductDescription :";
            // 
            // lblProductCatogry
            // 
            lblProductCatogry.AutoSize = true;
            lblProductCatogry.BackColor = Color.BurlyWood;
            lblProductCatogry.Location = new Point(559, 39);
            lblProductCatogry.Name = "lblProductCatogry";
            lblProductCatogry.Size = new Size(119, 20);
            lblProductCatogry.TabIndex = 3;
            lblProductCatogry.Text = "ProductCatogry :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(161, 32);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 4;
            // 
            // txtProductCatogry
            // 
            txtProductCatogry.Location = new Point(713, 32);
            txtProductCatogry.Name = "txtProductCatogry";
            txtProductCatogry.Size = new Size(125, 27);
            txtProductCatogry.TabIndex = 5;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(161, 89);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(677, 27);
            txtProductDescription.TabIndex = 6;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(414, 32);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(125, 27);
            txtProductPrice.TabIndex = 7;
            txtProductPrice.TextChanged += textBox4_TextChanged;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.BackColor = Color.BurlyWood;
            btn_AddProduct.Location = new Point(930, 192);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(150, 38);
            btn_AddProduct.TabIndex = 8;
            btn_AddProduct.Text = "AddProduct";
            btn_AddProduct.UseVisualStyleBackColor = false;
            btn_AddProduct.Click += btn_AddProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.BurlyWood;
            btnEditProduct.Location = new Point(930, 109);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(150, 38);
            btnEditProduct.TabIndex = 9;
            btnEditProduct.Text = "EditProduct";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.BurlyWood;
            btnDeleteProduct.Location = new Point(930, 32);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(150, 38);
            btnDeleteProduct.TabIndex = 10;
            btnDeleteProduct.Text = "DeleteProduct";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // cmbCatogries
            // 
            cmbCatogries.BackColor = Color.BurlyWood;
            cmbCatogries.FormattingEnabled = true;
            cmbCatogries.Location = new Point(929, 260);
            cmbCatogries.Name = "cmbCatogries";
            cmbCatogries.Size = new Size(151, 28);
            cmbCatogries.TabIndex = 11;
            cmbCatogries.Text = "Category";
            cmbCatogries.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(840, 243);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1101, 409);
            Controls.Add(dataGridView1);
            Controls.Add(cmbCatogries);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btn_AddProduct);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductDescription);
            Controls.Add(txtProductCatogry);
            Controls.Add(txtProductName);
            Controls.Add(lblProductCatogry);
            Controls.Add(lblProductDescription);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductName);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "ProductManagement";
            Text = "ProductManagement";
            Load += ProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblProductPrice;
        private Label lblProductDescription;
        private Label lblProductCatogry;
        private TextBox txtProductName;
        private TextBox txtProductCatogry;
        private TextBox txtProductDescription;
        private TextBox txtProductPrice;
        private Button btn_AddProduct;
        private Button btnEditProduct;
        private Button btnDeleteProduct;
        private ComboBox cmbCatogries;
        private DataGridView dataGridView1;
    }
}
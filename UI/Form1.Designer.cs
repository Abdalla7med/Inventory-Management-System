namespace UI
{
    partial class InventoryManagementSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_ProductManagement = new Button();
            btn_TransactionRecording = new Button();
            btn_InventoryStatus = new Button();
            btn_Reports = new Button();
            lbl_TotalProducts = new Label();
            label4 = new Label();
            lbl_TotalInventoryvalue = new Label();
            txt_TotalProducts = new TextBox();
            txtTotalInventoryvalue = new TextBox();
            btnCategoryManagement = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BurlyWood;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 19);
            label1.Name = "label1";
            label1.Size = new Size(521, 44);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            label1.Click += label1_Click;
            // 
            // btn_ProductManagement
            // 
            btn_ProductManagement.BackColor = Color.BurlyWood;
            btn_ProductManagement.Location = new Point(697, 373);
            btn_ProductManagement.Name = "btn_ProductManagement";
            btn_ProductManagement.Size = new Size(188, 37);
            btn_ProductManagement.TabIndex = 1;
            btn_ProductManagement.Text = "Product Management";
            btn_ProductManagement.UseVisualStyleBackColor = false;
            btn_ProductManagement.Click += btn_ProductManagement_Click;
            // 
            // btn_TransactionRecording
            // 
            btn_TransactionRecording.BackColor = Color.BurlyWood;
            btn_TransactionRecording.Location = new Point(697, 275);
            btn_TransactionRecording.Name = "btn_TransactionRecording";
            btn_TransactionRecording.Size = new Size(188, 37);
            btn_TransactionRecording.TabIndex = 2;
            btn_TransactionRecording.Text = "Transaction Recording";
            btn_TransactionRecording.UseVisualStyleBackColor = false;
            btn_TransactionRecording.Click += btn_TransactionRecording_Click;
            // 
            // btn_InventoryStatus
            // 
            btn_InventoryStatus.BackColor = Color.BurlyWood;
            btn_InventoryStatus.Location = new Point(558, 99);
            btn_InventoryStatus.Name = "btn_InventoryStatus";
            btn_InventoryStatus.Size = new Size(144, 37);
            btn_InventoryStatus.TabIndex = 3;
            btn_InventoryStatus.Text = "Inventory Status";
            btn_InventoryStatus.UseVisualStyleBackColor = false;
            btn_InventoryStatus.Click += btn_InventoryStatus_Click;
            // 
            // btn_Reports
            // 
            btn_Reports.BackColor = Color.BurlyWood;
            btn_Reports.Location = new Point(867, 99);
            btn_Reports.Name = "btn_Reports";
            btn_Reports.Size = new Size(173, 37);
            btn_Reports.TabIndex = 4;
            btn_Reports.Text = "Reports";
            btn_Reports.UseVisualStyleBackColor = false;
            btn_Reports.Click += button4_Click;
            // 
            // lbl_TotalProducts
            // 
            lbl_TotalProducts.AutoSize = true;
            lbl_TotalProducts.BackColor = Color.BurlyWood;
            lbl_TotalProducts.Location = new Point(39, 207);
            lbl_TotalProducts.Name = "lbl_TotalProducts";
            lbl_TotalProducts.Size = new Size(114, 20);
            lbl_TotalProducts.TabIndex = 5;
            lbl_TotalProducts.Text = "Total Products : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 413);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // lbl_TotalInventoryvalue
            // 
            lbl_TotalInventoryvalue.AutoSize = true;
            lbl_TotalInventoryvalue.BackColor = Color.BurlyWood;
            lbl_TotalInventoryvalue.Location = new Point(39, 257);
            lbl_TotalInventoryvalue.Name = "lbl_TotalInventoryvalue";
            lbl_TotalInventoryvalue.Size = new Size(158, 20);
            lbl_TotalInventoryvalue.TabIndex = 9;
            lbl_TotalInventoryvalue.Text = "Total Inventory Value : ";
            // 
            // txt_TotalProducts
            // 
            txt_TotalProducts.Location = new Point(217, 200);
            txt_TotalProducts.Name = "txt_TotalProducts";
            txt_TotalProducts.Size = new Size(271, 27);
            txt_TotalProducts.TabIndex = 10;
            // 
            // txtTotalInventoryvalue
            // 
            txtTotalInventoryvalue.Location = new Point(217, 257);
            txtTotalInventoryvalue.Name = "txtTotalInventoryvalue";
            txtTotalInventoryvalue.Size = new Size(271, 27);
            txtTotalInventoryvalue.TabIndex = 14;
            // 
            // btnCategoryManagement
            // 
            btnCategoryManagement.BackColor = Color.BurlyWood;
            btnCategoryManagement.Location = new Point(867, 186);
            btnCategoryManagement.Name = "btnCategoryManagement";
            btnCategoryManagement.Size = new Size(173, 37);
            btnCategoryManagement.TabIndex = 16;
            btnCategoryManagement.Text = "CategoryManagement";
            btnCategoryManagement.UseVisualStyleBackColor = false;
            btnCategoryManagement.Click += btnCategoryManagement_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.BurlyWood;
            btnSearch.Location = new Point(558, 195);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 37);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += lblSearch_Click;
            // 
            // InventoryManagementSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1145, 447);
            Controls.Add(btnSearch);
            Controls.Add(btnCategoryManagement);
            Controls.Add(txtTotalInventoryvalue);
            Controls.Add(txt_TotalProducts);
            Controls.Add(lbl_TotalInventoryvalue);
            Controls.Add(label4);
            Controls.Add(lbl_TotalProducts);
            Controls.Add(btn_Reports);
            Controls.Add(btn_InventoryStatus);
            Controls.Add(btn_TransactionRecording);
            Controls.Add(btn_ProductManagement);
            Controls.Add(label1);
            Name = "InventoryManagementSystem";
            Text = "Form1";
            Load += InventoryManagementSystem_Load;
            Click += InventoryManagementSystem_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_ProductManagement;
        private Button btn_TransactionRecording;
        private Button btn_InventoryStatus;
        private Button btn_Reports;
        private Label lbl_TotalProducts;
        private Label label4;
        private Label lbl_TotalInventoryvalue;
        private TextBox txt_TotalProducts;
        private TextBox txtTotalInventoryvalue;
        private Button btnCategoryManagement;
        private Button btnSearch;
    }
}

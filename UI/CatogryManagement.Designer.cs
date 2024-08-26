namespace UI
{
    partial class CatogryManagement
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
            txtCateogryName = new TextBox();
            lblCateogryName = new Label();
            btnAddCateogry = new Button();
            btnEditCateogry = new Button();
            btnDeleteCateogry = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCateogryName
            // 
            txtCateogryName.Location = new Point(148, 53);
            txtCateogryName.Name = "txtCateogryName";
            txtCateogryName.Size = new Size(208, 27);
            txtCateogryName.TabIndex = 0;
      
            // lblCateogryName
            // 
            lblCateogryName.AutoSize = true;
            lblCateogryName.BackColor = Color.BurlyWood;
            lblCateogryName.Location = new Point(12, 56);
            lblCateogryName.Name = "lblCateogryName";
            lblCateogryName.Size = new Size(120, 20);
            lblCateogryName.TabIndex = 1;
            lblCateogryName.Text = "CateogryName : ";
            // 
            // btnAddCateogry
            // 
            btnAddCateogry.BackColor = Color.BurlyWood;
            btnAddCateogry.ForeColor = SystemColors.ActiveCaptionText;
            btnAddCateogry.Location = new Point(634, 23);
            btnAddCateogry.Name = "btnAddCateogry";
            btnAddCateogry.Size = new Size(133, 39);
            btnAddCateogry.TabIndex = 2;
            btnAddCateogry.Text = "AddCateogry";
            btnAddCateogry.UseVisualStyleBackColor = false;
            btnAddCateogry.Click += btnAddCateogry_Click;
            // 
            // btnEditCateogry
            // 
            btnEditCateogry.BackColor = Color.BurlyWood;
            btnEditCateogry.Location = new Point(449, 23);
            btnEditCateogry.Name = "btnEditCateogry";
            btnEditCateogry.Size = new Size(130, 39);
            btnEditCateogry.TabIndex = 3;
            btnEditCateogry.Text = "EditCateogry";
            btnEditCateogry.UseVisualStyleBackColor = false;
            btnEditCateogry.Click += btnEditCateogry_Click;
            // 
            // btnDeleteCateogry
            // 
            btnDeleteCateogry.BackColor = Color.BurlyWood;
            btnDeleteCateogry.Location = new Point(548, 84);
            btnDeleteCateogry.Name = "btnDeleteCateogry";
            btnDeleteCateogry.Size = new Size(128, 42);
            btnDeleteCateogry.TabIndex = 4;
            btnDeleteCateogry.Text = "DeleteCateogry";
            btnDeleteCateogry.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(777, 211);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CatogryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(779, 375);
            Controls.Add(dataGridView1);
            Controls.Add(btnDeleteCateogry);
            Controls.Add(btnEditCateogry);
            Controls.Add(btnAddCateogry);
            Controls.Add(lblCateogryName);
            Controls.Add(txtCateogryName);
            Name = "CatogryManagement";
            Text = "CatogryManagement";
            Load += CatogryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCateogryName;
        private Label lblCateogryName;
        private Button btnAddCateogry;
        private Button btnEditCateogry;
        private Button btnDeleteCateogry;
        private DataGridView dataGridView1;
    }
}
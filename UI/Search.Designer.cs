namespace UI
{
    partial class Search
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProductName = new TextBox();
            txtPriceMax = new TextBox();
            txtPriceMin = new TextBox();
            cmbCategory = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dtpDateAddedFrom = new DateTimePicker();
            dtpDateAddedTo = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BurlyWood;
            label1.Location = new Point(61, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "ProductName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BurlyWood;
            label2.Location = new Point(60, 113);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Category : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.BurlyWood;
            label3.Location = new Point(301, 27);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "PriceRange : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.BurlyWood;
            label4.Location = new Point(60, 186);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "DateAdded : ";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(60, 59);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 5;
            // 
            // txtPriceMax
            // 
            txtPriceMax.Location = new Point(364, 59);
            txtPriceMax.Name = "txtPriceMax";
            txtPriceMax.Size = new Size(125, 27);
            txtPriceMax.TabIndex = 6;
            // 
            // txtPriceMin
            // 
            txtPriceMin.Location = new Point(222, 59);
            txtPriceMin.Name = "txtPriceMin";
            txtPriceMin.Size = new Size(125, 27);
            txtPriceMin.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(166, 113);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // dtpDateAddedFrom
            // 
            dtpDateAddedFrom.Location = new Point(61, 263);
            dtpDateAddedFrom.Name = "dtpDateAddedFrom";
            dtpDateAddedFrom.Size = new Size(250, 27);
            dtpDateAddedFrom.TabIndex = 10;
            // 
            // dtpDateAddedTo
            // 
            dtpDateAddedTo.Location = new Point(347, 263);
            dtpDateAddedTo.Name = "dtpDateAddedTo";
            dtpDateAddedTo.Size = new Size(250, 27);
            dtpDateAddedTo.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.Location = new Point(322, 350);
            button1.Name = "button1";
            button1.Size = new Size(147, 42);
            button1.TabIndex = 12;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.BurlyWood;
            button2.Location = new Point(128, 350);
            button2.Name = "button2";
            button2.Size = new Size(132, 42);
            button2.TabIndex = 13;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(645, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(492, 395);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.BurlyWood;
            label5.Location = new Point(849, 27);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 15;
            label5.Text = "Search Results : ";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1137, 470);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpDateAddedTo);
            Controls.Add(dtpDateAddedFrom);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbCategory);
            Controls.Add(txtPriceMin);
            Controls.Add(txtPriceMax);
            Controls.Add(txtProductName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProductName;
        private TextBox txtPriceMax;
        private TextBox txtPriceMin;
        private ComboBox cmbCategory;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpDateAddedFrom;
        private DateTimePicker dtpDateAddedTo;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
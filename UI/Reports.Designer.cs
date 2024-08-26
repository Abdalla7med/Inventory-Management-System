namespace UI
{
    partial class Reports
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
            lblReportType = new Label();
            lblReportResults = new Label();
            cmbCateogryFilter = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbReportType = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnPreview = new Button();
            btnExport = new Button();
            btnGenerateReport = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.BackColor = Color.BurlyWood;
            lblReportType.ForeColor = SystemColors.ActiveCaptionText;
            lblReportType.Location = new Point(184, 9);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(140, 20);
            lblReportType.TabIndex = 0;
            lblReportType.Text = "Select ReportType : ";
            // 
            // lblReportResults
            // 
            lblReportResults.AutoSize = true;
            lblReportResults.BackColor = Color.BurlyWood;
            lblReportResults.ForeColor = SystemColors.ActiveCaptionText;
            lblReportResults.Location = new Point(849, 108);
            lblReportResults.Name = "lblReportResults";
            lblReportResults.Size = new Size(111, 20);
            lblReportResults.TabIndex = 3;
            lblReportResults.Text = "ReportResults : ";
            // 
            // cmbCateogryFilter
            // 
            cmbCateogryFilter.BackColor = Color.BurlyWood;
            cmbCateogryFilter.FormattingEnabled = true;
            cmbCateogryFilter.Location = new Point(429, 59);
            cmbCateogryFilter.Name = "cmbCateogryFilter";
            cmbCateogryFilter.Size = new Size(151, 28);
            cmbCateogryFilter.TabIndex = 4;
            cmbCateogryFilter.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BurlyWood;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(443, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 9;
            label2.Text = "Filter by Category : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.BurlyWood;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(818, 9);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 10;
            label3.Text = "Select Date Range : ";
            // 
            // cmbReportType
            // 
            cmbReportType.BackColor = Color.BurlyWood;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(173, 59);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(151, 28);
            cmbReportType.TabIndex = 11;
            cmbReportType.Text = "ReportType";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(611, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(944, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(497, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 325);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.BurlyWood;
            btnPreview.ForeColor = SystemColors.ActiveCaptionText;
            btnPreview.Location = new Point(115, 253);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(152, 44);
            btnPreview.TabIndex = 15;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.BurlyWood;
            btnExport.ForeColor = SystemColors.ActiveCaptionText;
            btnExport.Location = new Point(115, 339);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(152, 43);
            btnExport.TabIndex = 16;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.BurlyWood;
            btnGenerateReport.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerateReport.Location = new Point(115, 173);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(152, 45);
            btnGenerateReport.TabIndex = 17;
            btnGenerateReport.Text = "Generate Report ";
            btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1300, 470);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnExport);
            Controls.Add(btnPreview);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbReportType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCateogryFilter);
            Controls.Add(lblReportResults);
            Controls.Add(lblReportType);
            ForeColor = SystemColors.ControlLight;
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportType;
        private Label lblReportResults;
        private ComboBox cmbCateogryFilter;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ComboBox cmbReportType;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button btnPreview;
        private Button btnExport;
        private Button btnGenerateReport;
        private SaveFileDialog saveFileDialog1;
    }
}
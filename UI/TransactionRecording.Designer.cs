namespace UI
{
    partial class TransactionRecording
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
            cmbProductSelection = new ComboBox();
            txtQuantity = new TextBox();
            lblQunatity = new Label();
            cmbTransactionType = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cmbProductSelection
            // 
            cmbProductSelection.BackColor = Color.BurlyWood;
            cmbProductSelection.FormattingEnabled = true;
            cmbProductSelection.Location = new Point(392, 113);
            cmbProductSelection.Name = "cmbProductSelection";
            cmbProductSelection.Size = new Size(151, 28);
            cmbProductSelection.TabIndex = 0;
            cmbProductSelection.Text = "Product";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(367, 56);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 1;
            txtQuantity.TextChanged += textBox1_TextChanged;
            // 
            // lblQunatity
            // 
            lblQunatity.AutoSize = true;
            lblQunatity.BackColor = Color.BurlyWood;
            lblQunatity.Location = new Point(285, 56);
            lblQunatity.Name = "lblQunatity";
            lblQunatity.Size = new Size(76, 20);
            lblQunatity.TabIndex = 2;
            lblQunatity.Text = "Quantity : ";
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.BackColor = Color.BurlyWood;
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Location = new Point(611, 113);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(151, 28);
            cmbTransactionType.TabIndex = 3;
            cmbTransactionType.Text = "Transaction";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ButtonFace;
            dateTimePicker1.Location = new Point(50, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.BackColor = Color.BurlyWood;
            lblNotes.Location = new Point(50, 217);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(59, 20);
            lblNotes.TabIndex = 5;
            lblNotes.Text = "Notes : ";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(116, 217);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(662, 27);
            txtNotes.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.BurlyWood;
            btnSave.Location = new Point(334, 318);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(192, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // TransactionRecording
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(904, 416);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbTransactionType);
            Controls.Add(lblQunatity);
            Controls.Add(txtQuantity);
            Controls.Add(cmbProductSelection);
            Name = "TransactionRecording";
            Text = "TransactionRecording";
            Load += TransactionRecording_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProductSelection;
        private TextBox txtQuantity;
        private Label lblQunatity;
        private ComboBox cmbTransactionType;
        private DateTimePicker dateTimePicker1;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnSave;
    }
}
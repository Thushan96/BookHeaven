namespace BookHeaven2.UI
{
    partial class AdminDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblDashboard = new Label();
            splitter1 = new Splitter();
            btnSummary = new Button();
            btnBestSelling = new Button();
            Inventory = new Button();
            btnBestcustomer = new Button();
            btnToday = new Button();
            btnWeek = new Button();
            btnMonth = new Button();
            dgvReports = new DataGridView();
            label1 = new Label();
            btnBack = new Button();
            btnDownload = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(716, 20);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(114, 28);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.Info;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(239, 551);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(65, 127);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(112, 40);
            btnSummary.TabIndex = 2;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // btnBestSelling
            // 
            btnBestSelling.Location = new Point(65, 203);
            btnBestSelling.Name = "btnBestSelling";
            btnBestSelling.Size = new Size(112, 46);
            btnBestSelling.TabIndex = 3;
            btnBestSelling.Text = "Best Selling";
            btnBestSelling.UseVisualStyleBackColor = true;
            btnBestSelling.Click += btnBestSelling_Click;
            // 
            // Inventory
            // 
            Inventory.Location = new Point(65, 281);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(112, 43);
            Inventory.TabIndex = 4;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // btnBestcustomer
            // 
            btnBestcustomer.Location = new Point(65, 352);
            btnBestcustomer.Name = "btnBestcustomer";
            btnBestcustomer.Size = new Size(112, 48);
            btnBestcustomer.TabIndex = 5;
            btnBestcustomer.Text = "Best Customer";
            btnBestcustomer.UseVisualStyleBackColor = true;
            btnBestcustomer.Click += btnBestcustomer_Click;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(263, 142);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(94, 41);
            btnToday.TabIndex = 6;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Visible = false;
            btnToday.Click += btnToday_Click;
            // 
            // btnWeek
            // 
            btnWeek.Location = new Point(263, 216);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(94, 41);
            btnWeek.TabIndex = 7;
            btnWeek.Text = "Week";
            btnWeek.UseVisualStyleBackColor = true;
            btnWeek.Visible = false;
            btnWeek.Click += btnWeek_Click;
            // 
            // btnMonth
            // 
            btnMonth.Location = new Point(263, 283);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(94, 41);
            btnMonth.TabIndex = 8;
            btnMonth.Text = "Month";
            btnMonth.UseVisualStyleBackColor = true;
            btnMonth.Visible = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // dgvReports
            // 
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReports.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReports.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReports.Location = new Point(413, 88);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.RowTemplate.Height = 30;
            dgvReports.Size = new Size(773, 368);
            dgvReports.TabIndex = 9;
            dgvReports.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 43);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 10;
            label1.Text = "Reports";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientInactiveCaption;
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1129, 487);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 37);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = SystemColors.ScrollBar;
            btnDownload.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(959, 487);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(107, 37);
            btnDownload.TabIndex = 12;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 551);
            Controls.Add(btnDownload);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dgvReports);
            Controls.Add(btnMonth);
            Controls.Add(btnWeek);
            Controls.Add(btnToday);
            Controls.Add(btnBestcustomer);
            Controls.Add(Inventory);
            Controls.Add(btnBestSelling);
            Controls.Add(btnSummary);
            Controls.Add(splitter1);
            Controls.Add(lblDashboard);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboard;
        private Splitter splitter1;
        private Button btnSummary;
        private Button btnBestSelling;
        private Button Inventory;
        private Button btnBestcustomer;
        private Button btnToday;
        private Button btnWeek;
        private Button btnMonth;
        private DataGridView dgvReports;
        private Label label1;
        private Button btnBack;
        private Button btnDownload;
    }
}
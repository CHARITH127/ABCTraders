namespace ABCTraders
{
    partial class ReportGenaration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_ReportGenerateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminReport_gridView = new System.Windows.Forms.DataGridView();
            this.admin_ReportSearchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminReport_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.admin_ReportSearchBtn);
            this.panel1.Controls.Add(this.admin_ToDatePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.admin_FromDatePicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.admin_ReportGenerateBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 198);
            this.panel1.TabIndex = 4;
            // 
            // admin_ToDatePicker
            // 
            this.admin_ToDatePicker.Location = new System.Drawing.Point(498, 73);
            this.admin_ToDatePicker.Name = "admin_ToDatePicker";
            this.admin_ToDatePicker.Size = new System.Drawing.Size(231, 22);
            this.admin_ToDatePicker.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "To Date : ";
            // 
            // admin_FromDatePicker
            // 
            this.admin_FromDatePicker.Location = new System.Drawing.Point(132, 73);
            this.admin_FromDatePicker.Name = "admin_FromDatePicker";
            this.admin_FromDatePicker.Size = new System.Drawing.Size(231, 22);
            this.admin_FromDatePicker.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Report Generation";
            // 
            // admin_ReportGenerateBtn
            // 
            this.admin_ReportGenerateBtn.Location = new System.Drawing.Point(192, 131);
            this.admin_ReportGenerateBtn.Name = "admin_ReportGenerateBtn";
            this.admin_ReportGenerateBtn.Size = new System.Drawing.Size(156, 35);
            this.admin_ReportGenerateBtn.TabIndex = 12;
            this.admin_ReportGenerateBtn.Text = "Generate Report";
            this.admin_ReportGenerateBtn.UseVisualStyleBackColor = true;
            this.admin_ReportGenerateBtn.Click += new System.EventHandler(this.admin_ReportGenerateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date : ";
            // 
            // adminReport_gridView
            // 
            this.adminReport_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminReport_gridView.Location = new System.Drawing.Point(15, 228);
            this.adminReport_gridView.Name = "adminReport_gridView";
            this.adminReport_gridView.RowHeadersWidth = 51;
            this.adminReport_gridView.RowTemplate.Height = 24;
            this.adminReport_gridView.Size = new System.Drawing.Size(826, 267);
            this.adminReport_gridView.TabIndex = 21;
            // 
            // admin_ReportSearchBtn
            // 
            this.admin_ReportSearchBtn.Location = new System.Drawing.Point(18, 130);
            this.admin_ReportSearchBtn.Name = "admin_ReportSearchBtn";
            this.admin_ReportSearchBtn.Size = new System.Drawing.Size(156, 35);
            this.admin_ReportSearchBtn.TabIndex = 21;
            this.admin_ReportSearchBtn.Text = "SEARCH";
            this.admin_ReportSearchBtn.UseVisualStyleBackColor = true;
            this.admin_ReportSearchBtn.Click += new System.EventHandler(this.admin_ReportSearchBtn_Click);
            // 
            // ReportGenaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminReport_gridView);
            this.Controls.Add(this.panel1);
            this.Name = "ReportGenaration";
            this.Size = new System.Drawing.Size(857, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminReport_gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button admin_ReportGenerateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker admin_FromDatePicker;
        private System.Windows.Forms.DateTimePicker admin_ToDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView adminReport_gridView;
        private System.Windows.Forms.Button admin_ReportSearchBtn;
    }
}

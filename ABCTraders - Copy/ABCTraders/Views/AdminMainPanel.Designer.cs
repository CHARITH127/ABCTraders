namespace ABCTraders
{
    partial class AdminMainPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.admin_GenerateReportBtn = new System.Windows.Forms.Button();
            this.admin_MangeOrdersBtn = new System.Windows.Forms.Button();
            this.admin_MangeCustomersBtn = new System.Windows.Forms.Button();
            this.admin_MangeCarPartsBtn = new System.Windows.Forms.Button();
            this.admin_MangeCarsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportGenaration1 = new ABCTraders.ReportGenaration();
            this.manageOrders1 = new ABCTraders.ManageOrders();
            this.manageCustomers1 = new ABCTraders.ManageCustomers();
            this.manageCarParts1 = new ABCTraders.ManageCarParts();
            this.manageCars1 = new ABCTraders.ManageCars();
            this.adminDashboard1 = new ABCTraders.adminDashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin management panel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.admin_GenerateReportBtn);
            this.panel2.Controls.Add(this.admin_MangeOrdersBtn);
            this.panel2.Controls.Add(this.admin_MangeCustomersBtn);
            this.panel2.Controls.Add(this.admin_MangeCarPartsBtn);
            this.panel2.Controls.Add(this.admin_MangeCarsBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 512);
            this.panel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(17, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // admin_GenerateReportBtn
            // 
            this.admin_GenerateReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.admin_GenerateReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_GenerateReportBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_GenerateReportBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.admin_GenerateReportBtn.Location = new System.Drawing.Point(17, 286);
            this.admin_GenerateReportBtn.Name = "admin_GenerateReportBtn";
            this.admin_GenerateReportBtn.Size = new System.Drawing.Size(188, 38);
            this.admin_GenerateReportBtn.TabIndex = 4;
            this.admin_GenerateReportBtn.Text = "Generate Reports";
            this.admin_GenerateReportBtn.UseVisualStyleBackColor = false;
            this.admin_GenerateReportBtn.Click += new System.EventHandler(this.admin_GenerateReportBtn_Click);
            // 
            // admin_MangeOrdersBtn
            // 
            this.admin_MangeOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.admin_MangeOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_MangeOrdersBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_MangeOrdersBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.admin_MangeOrdersBtn.Location = new System.Drawing.Point(17, 349);
            this.admin_MangeOrdersBtn.Name = "admin_MangeOrdersBtn";
            this.admin_MangeOrdersBtn.Size = new System.Drawing.Size(188, 44);
            this.admin_MangeOrdersBtn.TabIndex = 3;
            this.admin_MangeOrdersBtn.Text = "Manage Orders";
            this.admin_MangeOrdersBtn.UseVisualStyleBackColor = false;
            this.admin_MangeOrdersBtn.Click += new System.EventHandler(this.admin_MangeOrdersBtn_Click);
            // 
            // admin_MangeCustomersBtn
            // 
            this.admin_MangeCustomersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.admin_MangeCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_MangeCustomersBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_MangeCustomersBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.admin_MangeCustomersBtn.Location = new System.Drawing.Point(16, 226);
            this.admin_MangeCustomersBtn.Name = "admin_MangeCustomersBtn";
            this.admin_MangeCustomersBtn.Size = new System.Drawing.Size(189, 38);
            this.admin_MangeCustomersBtn.TabIndex = 2;
            this.admin_MangeCustomersBtn.Text = "Manage Customers";
            this.admin_MangeCustomersBtn.UseVisualStyleBackColor = false;
            this.admin_MangeCustomersBtn.Click += new System.EventHandler(this.admin_MangeCustomersBtn_Click);
            // 
            // admin_MangeCarPartsBtn
            // 
            this.admin_MangeCarPartsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.admin_MangeCarPartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_MangeCarPartsBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_MangeCarPartsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.admin_MangeCarPartsBtn.Location = new System.Drawing.Point(17, 169);
            this.admin_MangeCarPartsBtn.Name = "admin_MangeCarPartsBtn";
            this.admin_MangeCarPartsBtn.Size = new System.Drawing.Size(188, 38);
            this.admin_MangeCarPartsBtn.TabIndex = 1;
            this.admin_MangeCarPartsBtn.Text = "Manage Car Parts";
            this.admin_MangeCarPartsBtn.UseVisualStyleBackColor = false;
            this.admin_MangeCarPartsBtn.Click += new System.EventHandler(this.admin_MangeCarPartsBtn_Click);
            // 
            // admin_MangeCarsBtn
            // 
            this.admin_MangeCarsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.admin_MangeCarsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_MangeCarsBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_MangeCarsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.admin_MangeCarsBtn.Location = new System.Drawing.Point(17, 109);
            this.admin_MangeCarsBtn.Name = "admin_MangeCarsBtn";
            this.admin_MangeCarsBtn.Size = new System.Drawing.Size(188, 38);
            this.admin_MangeCarsBtn.TabIndex = 0;
            this.admin_MangeCarsBtn.Text = "Manage Car";
            this.admin_MangeCarsBtn.UseVisualStyleBackColor = false;
            this.admin_MangeCarsBtn.Click += new System.EventHandler(this.admin_MangeCarsBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.reportGenaration1);
            this.panel3.Controls.Add(this.manageOrders1);
            this.panel3.Controls.Add(this.manageCustomers1);
            this.panel3.Controls.Add(this.manageCarParts1);
            this.panel3.Controls.Add(this.manageCars1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 512);
            this.panel3.TabIndex = 2;
            // 
            // reportGenaration1
            // 
            this.reportGenaration1.Location = new System.Drawing.Point(0, 0);
            this.reportGenaration1.Name = "reportGenaration1";
            this.reportGenaration1.Size = new System.Drawing.Size(857, 512);
            this.reportGenaration1.TabIndex = 4;
            // 
            // manageOrders1
            // 
            this.manageOrders1.Location = new System.Drawing.Point(0, 0);
            this.manageOrders1.Name = "manageOrders1";
            this.manageOrders1.Size = new System.Drawing.Size(857, 512);
            this.manageOrders1.TabIndex = 3;
            // 
            // manageCustomers1
            // 
            this.manageCustomers1.Location = new System.Drawing.Point(0, 0);
            this.manageCustomers1.Name = "manageCustomers1";
            this.manageCustomers1.Size = new System.Drawing.Size(857, 512);
            this.manageCustomers1.TabIndex = 2;
            // 
            // manageCarParts1
            // 
            this.manageCarParts1.Location = new System.Drawing.Point(0, 0);
            this.manageCarParts1.Name = "manageCarParts1";
            this.manageCarParts1.Size = new System.Drawing.Size(857, 512);
            this.manageCarParts1.TabIndex = 1;
            // 
            // manageCars1
            // 
            this.manageCars1.Location = new System.Drawing.Point(0, 0);
            this.manageCars1.Name = "manageCars1";
            this.manageCars1.Size = new System.Drawing.Size(857, 512);
            this.manageCars1.TabIndex = 0;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(857, 512);
            this.adminDashboard1.TabIndex = 5;
            // 
            // AdminMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button admin_MangeCarsBtn;
        private System.Windows.Forms.Button admin_GenerateReportBtn;
        private System.Windows.Forms.Button admin_MangeOrdersBtn;
        private System.Windows.Forms.Button admin_MangeCustomersBtn;
        private System.Windows.Forms.Button admin_MangeCarPartsBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private ManageCars manageCars1;
        private ManageCarParts manageCarParts1;
        private ManageCustomers manageCustomers1;
        private ManageOrders manageOrders1;
        private ReportGenaration reportGenaration1;
        private adminDashboard adminDashboard1;
    }
}
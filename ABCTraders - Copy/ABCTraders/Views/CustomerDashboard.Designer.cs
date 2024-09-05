namespace ABCTraders
{
    partial class CustomerDashboard
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
        private void InitializeComponent(string userName)
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cust_userNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.customerPanel_mangeOrderBtn = new System.Windows.Forms.Button();
            this.customerPanel_placeOrderBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.orderManagment1 = new ABCTraders.OrderManagment(userName);
            this.placeOrders1 = new ABCTraders.PlaceOrders();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.placeOrders1);
            this.panel3.Controls.Add(this.orderManagment1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 512);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cust_userNameLbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.customerPanel_mangeOrderBtn);
            this.panel2.Controls.Add(this.customerPanel_placeOrderBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 512);
            this.panel2.TabIndex = 4;
            // 
            // cust_userNameLbl
            // 
            this.cust_userNameLbl.AutoSize = true;
            this.cust_userNameLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_userNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cust_userNameLbl.Location = new System.Drawing.Point(73, 106);
            this.cust_userNameLbl.Name = "cust_userNameLbl";
            this.cust_userNameLbl.Size = new System.Drawing.Size(68, 24);
            this.cust_userNameLbl.TabIndex = 4;
            this.cust_userNameLbl.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Red;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutBtn.Location = new System.Drawing.Point(11, 449);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(74, 38);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // customerPanel_mangeOrderBtn
            // 
            this.customerPanel_mangeOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.customerPanel_mangeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerPanel_mangeOrderBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPanel_mangeOrderBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customerPanel_mangeOrderBtn.Location = new System.Drawing.Point(19, 343);
            this.customerPanel_mangeOrderBtn.Name = "customerPanel_mangeOrderBtn";
            this.customerPanel_mangeOrderBtn.Size = new System.Drawing.Size(188, 38);
            this.customerPanel_mangeOrderBtn.TabIndex = 1;
            this.customerPanel_mangeOrderBtn.Text = "Manage Orders";
            this.customerPanel_mangeOrderBtn.UseVisualStyleBackColor = false;
            this.customerPanel_mangeOrderBtn.Click += new System.EventHandler(this.customerPanel_mangeOrderBtn_Click);
            // 
            // customerPanel_placeOrderBtn
            // 
            this.customerPanel_placeOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.customerPanel_placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerPanel_placeOrderBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPanel_placeOrderBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customerPanel_placeOrderBtn.Location = new System.Drawing.Point(18, 268);
            this.customerPanel_placeOrderBtn.Name = "customerPanel_placeOrderBtn";
            this.customerPanel_placeOrderBtn.Size = new System.Drawing.Size(188, 38);
            this.customerPanel_placeOrderBtn.TabIndex = 0;
            this.customerPanel_placeOrderBtn.Text = "Place Order";
            this.customerPanel_placeOrderBtn.UseVisualStyleBackColor = false;
            this.customerPanel_placeOrderBtn.Click += new System.EventHandler(this.customerPanel_placeOrderBtn_Click);
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
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer management panel";
            // 
            // orderManagment1
            // 
            this.orderManagment1.Location = new System.Drawing.Point(0, 0);
            this.orderManagment1.Name = "orderManagment1";
            this.orderManagment1.Size = new System.Drawing.Size(857, 512);
            this.orderManagment1.TabIndex = 0;
            // 
            // placeOrders1
            // 
            this.placeOrders1.Location = new System.Drawing.Point(0, 0);
            this.placeOrders1.Name = "placeOrders1";
            this.placeOrders1.Size = new System.Drawing.Size(857, 512);
            this.placeOrders1.TabIndex = 1;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button customerPanel_mangeOrderBtn;
        private System.Windows.Forms.Button customerPanel_placeOrderBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cust_userNameLbl;
        private PlaceOrders placeOrders1;
        private OrderManagment orderManagment1;
    }
}
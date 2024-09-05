namespace ABCTraders
{
    partial class ManageOrders
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
            this.adminMngOrders_statusCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminMngOrders_updateBtn = new System.Windows.Forms.Button();
            this.adminMngOrders_searchBtn = new System.Windows.Forms.Button();
            this.adminMngOrders_orderIdInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminMngOrders_orderDateInput = new System.Windows.Forms.TextBox();
            this.adminOrderMng_gridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminOrderMng_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.adminMngOrders_statusCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.adminMngOrders_updateBtn);
            this.panel1.Controls.Add(this.adminMngOrders_searchBtn);
            this.panel1.Controls.Add(this.adminMngOrders_orderIdInput);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.adminMngOrders_orderDateInput);
            this.panel1.Location = new System.Drawing.Point(15, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 146);
            this.panel1.TabIndex = 7;
            // 
            // adminMngOrders_statusCombo
            // 
            this.adminMngOrders_statusCombo.FormattingEnabled = true;
            this.adminMngOrders_statusCombo.Location = new System.Drawing.Point(471, 64);
            this.adminMngOrders_statusCombo.Name = "adminMngOrders_statusCombo";
            this.adminMngOrders_statusCombo.Size = new System.Drawing.Size(138, 24);
            this.adminMngOrders_statusCombo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Status : ";
            // 
            // adminMngOrders_updateBtn
            // 
            this.adminMngOrders_updateBtn.Location = new System.Drawing.Point(685, 97);
            this.adminMngOrders_updateBtn.Name = "adminMngOrders_updateBtn";
            this.adminMngOrders_updateBtn.Size = new System.Drawing.Size(118, 35);
            this.adminMngOrders_updateBtn.TabIndex = 14;
            this.adminMngOrders_updateBtn.Text = "UPDATE";
            this.adminMngOrders_updateBtn.UseVisualStyleBackColor = true;
            this.adminMngOrders_updateBtn.Click += new System.EventHandler(this.adminMngOrders_updateBtn_Click);
            // 
            // adminMngOrders_searchBtn
            // 
            this.adminMngOrders_searchBtn.Location = new System.Drawing.Point(685, 14);
            this.adminMngOrders_searchBtn.Name = "adminMngOrders_searchBtn";
            this.adminMngOrders_searchBtn.Size = new System.Drawing.Size(118, 30);
            this.adminMngOrders_searchBtn.TabIndex = 12;
            this.adminMngOrders_searchBtn.Text = "SEARCH";
            this.adminMngOrders_searchBtn.UseVisualStyleBackColor = true;
            this.adminMngOrders_searchBtn.Click += new System.EventHandler(this.adminMngOrders_searchBtn_Click);
            // 
            // adminMngOrders_orderIdInput
            // 
            this.adminMngOrders_orderIdInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminMngOrders_orderIdInput.Location = new System.Drawing.Point(545, 14);
            this.adminMngOrders_orderIdInput.Name = "adminMngOrders_orderIdInput";
            this.adminMngOrders_orderIdInput.Size = new System.Drawing.Size(120, 26);
            this.adminMngOrders_orderIdInput.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "OrderID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Order Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Order Date : ";
            // 
            // adminMngOrders_orderDateInput
            // 
            this.adminMngOrders_orderDateInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminMngOrders_orderDateInput.Location = new System.Drawing.Point(144, 61);
            this.adminMngOrders_orderDateInput.Name = "adminMngOrders_orderDateInput";
            this.adminMngOrders_orderDateInput.Size = new System.Drawing.Size(229, 26);
            this.adminMngOrders_orderDateInput.TabIndex = 1;
            // 
            // adminOrderMng_gridView
            // 
            this.adminOrderMng_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminOrderMng_gridView.Location = new System.Drawing.Point(15, 172);
            this.adminOrderMng_gridView.Name = "adminOrderMng_gridView";
            this.adminOrderMng_gridView.RowHeadersWidth = 51;
            this.adminOrderMng_gridView.RowTemplate.Height = 24;
            this.adminOrderMng_gridView.Size = new System.Drawing.Size(826, 307);
            this.adminOrderMng_gridView.TabIndex = 10;
            adminOrderMng_gridView.SelectionChanged += adminOrderMng_gridView_SelectionChanged;
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminOrderMng_gridView);
            this.Controls.Add(this.panel1);
            this.Name = "ManageOrders";
            this.Size = new System.Drawing.Size(857, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminOrderMng_gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adminMngOrders_updateBtn;
        private System.Windows.Forms.Button adminMngOrders_searchBtn;
        private System.Windows.Forms.TextBox adminMngOrders_orderIdInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminMngOrders_orderDateInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox adminMngOrders_statusCombo;
        private System.Windows.Forms.DataGridView adminOrderMng_gridView;
    }
}

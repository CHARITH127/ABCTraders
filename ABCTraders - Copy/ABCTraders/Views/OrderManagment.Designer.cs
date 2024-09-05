namespace ABCTraders
{
    partial class OrderManagment
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
            this.cusOrderMgt_deletBtn = new System.Windows.Forms.Button();
            this.cusOrderMgt_searchBtn = new System.Windows.Forms.Button();
            this.customerMngOrders_orderIDInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerOrderMng_gridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderMng_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cusOrderMgt_deletBtn);
            this.panel1.Controls.Add(this.cusOrderMgt_searchBtn);
            this.panel1.Controls.Add(this.customerMngOrders_orderIDInput);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 127);
            this.panel1.TabIndex = 4;
            // 
            // cusOrderMgt_deletBtn
            // 
            this.cusOrderMgt_deletBtn.Location = new System.Drawing.Point(685, 62);
            this.cusOrderMgt_deletBtn.Name = "cusOrderMgt_deletBtn";
            this.cusOrderMgt_deletBtn.Size = new System.Drawing.Size(117, 35);
            this.cusOrderMgt_deletBtn.TabIndex = 13;
            this.cusOrderMgt_deletBtn.Text = "DELETE";
            this.cusOrderMgt_deletBtn.UseVisualStyleBackColor = true;
            this.cusOrderMgt_deletBtn.Click += new System.EventHandler(this.cusOrderMgt_deletBtn_Click);
            // 
            // cusOrderMgt_searchBtn
            // 
            this.cusOrderMgt_searchBtn.Location = new System.Drawing.Point(545, 62);
            this.cusOrderMgt_searchBtn.Name = "cusOrderMgt_searchBtn";
            this.cusOrderMgt_searchBtn.Size = new System.Drawing.Size(117, 35);
            this.cusOrderMgt_searchBtn.TabIndex = 12;
            this.cusOrderMgt_searchBtn.Text = "SEARCH";
            this.cusOrderMgt_searchBtn.UseVisualStyleBackColor = true;
            this.cusOrderMgt_searchBtn.Click += new System.EventHandler(this.cusOrderMgt_searchBtn_Click);
            // 
            // customerMngOrders_orderIDInput
            // 
            this.customerMngOrders_orderIDInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerMngOrders_orderIDInput.Location = new System.Drawing.Point(135, 64);
            this.customerMngOrders_orderIDInput.Name = "customerMngOrders_orderIDInput";
            this.customerMngOrders_orderIDInput.Size = new System.Drawing.Size(161, 26);
            this.customerMngOrders_orderIDInput.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 68);
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
            // customerOrderMng_gridView
            // 
            this.customerOrderMng_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerOrderMng_gridView.Location = new System.Drawing.Point(15, 158);
            this.customerOrderMng_gridView.Name = "customerOrderMng_gridView";
            this.customerOrderMng_gridView.RowHeadersWidth = 51;
            this.customerOrderMng_gridView.RowTemplate.Height = 24;
            this.customerOrderMng_gridView.Size = new System.Drawing.Size(826, 327);
            this.customerOrderMng_gridView.TabIndex = 11;
            // 
            // OrderManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerOrderMng_gridView);
            this.Controls.Add(this.panel1);
            this.Name = "OrderManagment";
            this.Size = new System.Drawing.Size(857, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderMng_gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cusOrderMgt_deletBtn;
        private System.Windows.Forms.Button cusOrderMgt_searchBtn;
        private System.Windows.Forms.TextBox customerMngOrders_orderIDInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView customerOrderMng_gridView;
    }
}

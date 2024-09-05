namespace ABCTraders
{
    partial class PlaceOrders
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
            this.cus_placeOrderTotalPriceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cus_placeOrderCarPartRbtn = new System.Windows.Forms.RadioButton();
            this.cus_placeOrderCarRbtn = new System.Windows.Forms.RadioButton();
            this.cus_placeOrderAddBtn = new System.Windows.Forms.Button();
            this.cus_placeOrderDeleteBtn = new System.Windows.Forms.Button();
            this.cus_placeOrderModelCombo = new System.Windows.Forms.ComboBox();
            this.cus_placeOrderPlaceOrderBtn = new System.Windows.Forms.Button();
            this.cus_placeOrderBrandCombo = new System.Windows.Forms.ComboBox();
            this.cus_placeOrderUnitPriceInput = new System.Windows.Forms.TextBox();
            this.cus_placeOrderQtyInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.brandLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerPlaceOrder_gridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPlaceOrder_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cus_placeOrderTotalPriceLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cus_placeOrderAddBtn);
            this.panel1.Controls.Add(this.cus_placeOrderDeleteBtn);
            this.panel1.Controls.Add(this.cus_placeOrderModelCombo);
            this.panel1.Controls.Add(this.cus_placeOrderPlaceOrderBtn);
            this.panel1.Controls.Add(this.cus_placeOrderBrandCombo);
            this.panel1.Controls.Add(this.cus_placeOrderUnitPriceInput);
            this.panel1.Controls.Add(this.cus_placeOrderQtyInput);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.brandLbl);
            this.panel1.Controls.Add(this.modelLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 243);
            this.panel1.TabIndex = 4;
            // 
            // cus_placeOrderTotalPriceLbl
            // 
            this.cus_placeOrderTotalPriceLbl.AutoSize = true;
            this.cus_placeOrderTotalPriceLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_placeOrderTotalPriceLbl.Location = new System.Drawing.Point(133, 199);
            this.cus_placeOrderTotalPriceLbl.Name = "cus_placeOrderTotalPriceLbl";
            this.cus_placeOrderTotalPriceLbl.Size = new System.Drawing.Size(53, 18);
            this.cus_placeOrderTotalPriceLbl.TabIndex = 24;
            this.cus_placeOrderTotalPriceLbl.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total Price : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cus_placeOrderCarPartRbtn);
            this.groupBox1.Controls.Add(this.cus_placeOrderCarRbtn);
            this.groupBox1.Location = new System.Drawing.Point(19, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 115);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // cus_placeOrderCarPartRbtn
            // 
            this.cus_placeOrderCarPartRbtn.AutoSize = true;
            this.cus_placeOrderCarPartRbtn.Location = new System.Drawing.Point(109, 68);
            this.cus_placeOrderCarPartRbtn.Name = "cus_placeOrderCarPartRbtn";
            this.cus_placeOrderCarPartRbtn.Size = new System.Drawing.Size(83, 20);
            this.cus_placeOrderCarPartRbtn.TabIndex = 1;
            this.cus_placeOrderCarPartRbtn.TabStop = true;
            this.cus_placeOrderCarPartRbtn.Text = "Car Parts";
            this.cus_placeOrderCarPartRbtn.UseVisualStyleBackColor = true;
            this.cus_placeOrderCarPartRbtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // cus_placeOrderCarRbtn
            // 
            this.cus_placeOrderCarRbtn.AutoSize = true;
            this.cus_placeOrderCarRbtn.Location = new System.Drawing.Point(109, 21);
            this.cus_placeOrderCarRbtn.Name = "cus_placeOrderCarRbtn";
            this.cus_placeOrderCarRbtn.Size = new System.Drawing.Size(56, 20);
            this.cus_placeOrderCarRbtn.TabIndex = 0;
            this.cus_placeOrderCarRbtn.TabStop = true;
            this.cus_placeOrderCarRbtn.Text = "Cars";
            this.cus_placeOrderCarRbtn.UseVisualStyleBackColor = true;
            this.cus_placeOrderCarRbtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // cus_placeOrderAddBtn
            // 
            this.cus_placeOrderAddBtn.Location = new System.Drawing.Point(535, 192);
            this.cus_placeOrderAddBtn.Name = "cus_placeOrderAddBtn";
            this.cus_placeOrderAddBtn.Size = new System.Drawing.Size(118, 35);
            this.cus_placeOrderAddBtn.TabIndex = 12;
            this.cus_placeOrderAddBtn.Text = "ADD";
            this.cus_placeOrderAddBtn.UseVisualStyleBackColor = true;
            this.cus_placeOrderAddBtn.Click += new System.EventHandler(this.cus_placeOrderAddBtn_Click);
            // 
            // cus_placeOrderDeleteBtn
            // 
            this.cus_placeOrderDeleteBtn.Location = new System.Drawing.Point(404, 192);
            this.cus_placeOrderDeleteBtn.Name = "cus_placeOrderDeleteBtn";
            this.cus_placeOrderDeleteBtn.Size = new System.Drawing.Size(118, 35);
            this.cus_placeOrderDeleteBtn.TabIndex = 13;
            this.cus_placeOrderDeleteBtn.Text = "DELETE";
            this.cus_placeOrderDeleteBtn.UseVisualStyleBackColor = true;
            this.cus_placeOrderDeleteBtn.Click += new System.EventHandler(this.cus_placeOrderDeleteBtn_Click);
            // 
            // cus_placeOrderModelCombo
            // 
            this.cus_placeOrderModelCombo.FormattingEnabled = true;
            this.cus_placeOrderModelCombo.Location = new System.Drawing.Point(609, 77);
            this.cus_placeOrderModelCombo.Name = "cus_placeOrderModelCombo";
            this.cus_placeOrderModelCombo.Size = new System.Drawing.Size(160, 24);
            this.cus_placeOrderModelCombo.TabIndex = 21;
            this.cus_placeOrderModelCombo.SelectedIndexChanged += new System.EventHandler(this.cus_placeOrderModelCombo_SelectedIndexChanged);
            // 
            // cus_placeOrderPlaceOrderBtn
            // 
            this.cus_placeOrderPlaceOrderBtn.Location = new System.Drawing.Point(665, 192);
            this.cus_placeOrderPlaceOrderBtn.Name = "cus_placeOrderPlaceOrderBtn";
            this.cus_placeOrderPlaceOrderBtn.Size = new System.Drawing.Size(141, 35);
            this.cus_placeOrderPlaceOrderBtn.TabIndex = 14;
            this.cus_placeOrderPlaceOrderBtn.Text = "PALACE ORDER";
            this.cus_placeOrderPlaceOrderBtn.UseVisualStyleBackColor = true;
            this.cus_placeOrderPlaceOrderBtn.Click += new System.EventHandler(this.cus_placeOrderPlaceOrderBtn_Click);
            // 
            // cus_placeOrderBrandCombo
            // 
            this.cus_placeOrderBrandCombo.FormattingEnabled = true;
            this.cus_placeOrderBrandCombo.Location = new System.Drawing.Point(342, 76);
            this.cus_placeOrderBrandCombo.Name = "cus_placeOrderBrandCombo";
            this.cus_placeOrderBrandCombo.Size = new System.Drawing.Size(160, 24);
            this.cus_placeOrderBrandCombo.TabIndex = 20;
            this.cus_placeOrderBrandCombo.SelectedIndexChanged += new System.EventHandler(this.cus_placeOrderBrandCombo_SelectedIndexChanged);
            // 
            // cus_placeOrderUnitPriceInput
            // 
            this.cus_placeOrderUnitPriceInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_placeOrderUnitPriceInput.Location = new System.Drawing.Point(611, 125);
            this.cus_placeOrderUnitPriceInput.Name = "cus_placeOrderUnitPriceInput";
            this.cus_placeOrderUnitPriceInput.Size = new System.Drawing.Size(114, 26);
            this.cus_placeOrderUnitPriceInput.TabIndex = 16;
            // 
            // cus_placeOrderQtyInput
            // 
            this.cus_placeOrderQtyInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_placeOrderQtyInput.Location = new System.Drawing.Point(343, 125);
            this.cus_placeOrderQtyInput.Name = "cus_placeOrderQtyInput";
            this.cus_placeOrderQtyInput.Size = new System.Drawing.Size(114, 26);
            this.cus_placeOrderQtyInput.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Unit Price : ";
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLbl.Location = new System.Drawing.Point(271, 77);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(65, 18);
            this.brandLbl.TabIndex = 0;
            this.brandLbl.Text = "Brand : ";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLbl.Location = new System.Drawing.Point(534, 79);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(66, 18);
            this.modelLbl.TabIndex = 10;
            this.modelLbl.Text = "Model : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Qty : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Place Orders";
            // 
            // customerPlaceOrder_gridView
            // 
            this.customerPlaceOrder_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerPlaceOrder_gridView.Location = new System.Drawing.Point(15, 277);
            this.customerPlaceOrder_gridView.Name = "customerPlaceOrder_gridView";
            this.customerPlaceOrder_gridView.RowHeadersWidth = 51;
            this.customerPlaceOrder_gridView.RowTemplate.Height = 24;
            this.customerPlaceOrder_gridView.Size = new System.Drawing.Size(826, 219);
            this.customerPlaceOrder_gridView.TabIndex = 12;
            // 
            // PlaceOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerPlaceOrder_gridView);
            this.Controls.Add(this.panel1);
            this.Name = "PlaceOrders";
            this.Size = new System.Drawing.Size(857, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPlaceOrder_gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cus_placeOrderQtyInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cus_placeOrderUnitPriceInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cus_placeOrderPlaceOrderBtn;
        private System.Windows.Forms.Button cus_placeOrderDeleteBtn;
        private System.Windows.Forms.Button cus_placeOrderAddBtn;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.ComboBox cus_placeOrderModelCombo;
        private System.Windows.Forms.ComboBox cus_placeOrderBrandCombo;
        private System.Windows.Forms.DataGridView customerPlaceOrder_gridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cus_placeOrderCarPartRbtn;
        private System.Windows.Forms.RadioButton cus_placeOrderCarRbtn;
        private System.Windows.Forms.Label cus_placeOrderTotalPriceLbl;
        private System.Windows.Forms.Label label4;
    }
}

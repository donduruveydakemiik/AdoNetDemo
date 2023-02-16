namespace AdoNetDemoo
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtname2 = new System.Windows.Forms.TextBox();
            this.txtStockAmount2 = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblStockAmount2 = new System.Windows.Forms.Label();
            this.lblUnitPrice2 = new System.Windows.Forms.Label();
            this.txtUnitPrice2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(98, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(581, 173);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(112, 72);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 22);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 72);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(64, 16);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.Click += new System.EventHandler(this.lblUnitPrice_Click);
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(112, 110);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(100, 22);
            this.txtStockAmount.TabIndex = 6;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(6, 113);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(86, 16);
            this.lblStockAmount.TabIndex = 5;
            this.lblStockAmount.Text = "StockAmount";
            this.lblStockAmount.Click += new System.EventHandler(this.lblStockAmount_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnEkle);
            this.gbxAdd.Controls.Add(this.txtName);
            this.gbxAdd.Controls.Add(this.txtStockAmount);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Controls.Add(this.txtUnitPrice);
            this.gbxAdd.Location = new System.Drawing.Point(73, 237);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(274, 186);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(183, 157);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(63, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Add";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.txtname2);
            this.gbxUpdate.Controls.Add(this.txtStockAmount2);
            this.gbxUpdate.Controls.Add(this.lblName2);
            this.gbxUpdate.Controls.Add(this.lblStockAmount2);
            this.gbxUpdate.Controls.Add(this.lblUnitPrice2);
            this.gbxUpdate.Controls.Add(this.txtUnitPrice2);
            this.gbxUpdate.Location = new System.Drawing.Point(450, 237);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(285, 186);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Product";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(183, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtname2
            // 
            this.txtname2.Location = new System.Drawing.Point(112, 33);
            this.txtname2.Name = "txtname2";
            this.txtname2.Size = new System.Drawing.Size(100, 22);
            this.txtname2.TabIndex = 2;
            // 
            // txtStockAmount2
            // 
            this.txtStockAmount2.Location = new System.Drawing.Point(112, 110);
            this.txtStockAmount2.Name = "txtStockAmount2";
            this.txtStockAmount2.Size = new System.Drawing.Size(100, 22);
            this.txtStockAmount2.TabIndex = 6;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(6, 33);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(44, 16);
            this.lblName2.TabIndex = 1;
            this.lblName2.Text = "Name";
            // 
            // lblStockAmount2
            // 
            this.lblStockAmount2.AutoSize = true;
            this.lblStockAmount2.Location = new System.Drawing.Point(6, 113);
            this.lblStockAmount2.Name = "lblStockAmount2";
            this.lblStockAmount2.Size = new System.Drawing.Size(86, 16);
            this.lblStockAmount2.TabIndex = 5;
            this.lblStockAmount2.Text = "StockAmount";
            // 
            // lblUnitPrice2
            // 
            this.lblUnitPrice2.AutoSize = true;
            this.lblUnitPrice2.Location = new System.Drawing.Point(6, 72);
            this.lblUnitPrice2.Name = "lblUnitPrice2";
            this.lblUnitPrice2.Size = new System.Drawing.Size(64, 16);
            this.lblUnitPrice2.TabIndex = 3;
            this.lblUnitPrice2.Text = "Unit Price";
            // 
            // txtUnitPrice2
            // 
            this.txtUnitPrice2.Location = new System.Drawing.Point(112, 72);
            this.txtUnitPrice2.Name = "txtUnitPrice2";
            this.txtUnitPrice2.Size = new System.Drawing.Size(100, 22);
            this.txtUnitPrice2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtname2;
        private System.Windows.Forms.TextBox txtStockAmount2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblStockAmount2;
        private System.Windows.Forms.Label lblUnitPrice2;
        private System.Windows.Forms.TextBox txtUnitPrice2;
        private System.Windows.Forms.Button btnDelete;
    }
}


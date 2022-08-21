
namespace BarCodeApplication
{
    partial class ProduntSelling
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBuy = new System.Windows.Forms.TabPage();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.panelBuyShow = new System.Windows.Forms.Panel();
            this.panelBuyMenu = new System.Windows.Forms.Panel();
            this.txtBuyItem = new System.Windows.Forms.TextBox();
            this.btnBuyScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelProMenu = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBuy.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.panelBuyShow.SuspendLayout();
            this.panelBuyMenu.SuspendLayout();
            this.panelProMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBuy);
            this.tabControl.Controls.Add(this.tabProduct);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(724, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabBuy
            // 
            this.tabBuy.Controls.Add(this.panelBuyMenu);
            this.tabBuy.Controls.Add(this.panelBuyShow);
            this.tabBuy.Location = new System.Drawing.Point(4, 22);
            this.tabBuy.Name = "tabBuy";
            this.tabBuy.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuy.Size = new System.Drawing.Size(716, 400);
            this.tabBuy.TabIndex = 0;
            this.tabBuy.Text = "Buy Product";
            this.tabBuy.UseVisualStyleBackColor = true;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.splitContainer1);
            this.tabProduct.Controls.Add(this.panelProMenu);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(716, 400);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Products";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // panelBuyShow
            // 
            this.panelBuyShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBuyShow.Controls.Add(this.splitContainer2);
            this.panelBuyShow.Location = new System.Drawing.Point(3, 3);
            this.panelBuyShow.Name = "panelBuyShow";
            this.panelBuyShow.Size = new System.Drawing.Size(713, 344);
            this.panelBuyShow.TabIndex = 0;
            // 
            // panelBuyMenu
            // 
            this.panelBuyMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBuyMenu.Controls.Add(this.btnBuy);
            this.panelBuyMenu.Controls.Add(this.label2);
            this.panelBuyMenu.Controls.Add(this.label1);
            this.panelBuyMenu.Controls.Add(this.btnBuyScan);
            this.panelBuyMenu.Controls.Add(this.txtBuyItem);
            this.panelBuyMenu.Location = new System.Drawing.Point(4, 353);
            this.panelBuyMenu.Name = "panelBuyMenu";
            this.panelBuyMenu.Size = new System.Drawing.Size(709, 44);
            this.panelBuyMenu.TabIndex = 1;
            // 
            // txtBuyItem
            // 
            this.txtBuyItem.Location = new System.Drawing.Point(15, 12);
            this.txtBuyItem.Name = "txtBuyItem";
            this.txtBuyItem.Size = new System.Drawing.Size(115, 20);
            this.txtBuyItem.TabIndex = 0;
            this.txtBuyItem.Text = "Enter Name...";
            this.txtBuyItem.Enter += new System.EventHandler(this.txtBuyItem_Enter);
            this.txtBuyItem.Leave += new System.EventHandler(this.txtBuyItem_Leave);
            // 
            // btnBuyScan
            // 
            this.btnBuyScan.Location = new System.Drawing.Point(136, 10);
            this.btnBuyScan.Name = "btnBuyScan";
            this.btnBuyScan.Size = new System.Drawing.Size(75, 23);
            this.btnBuyScan.TabIndex = 1;
            this.btnBuyScan.Text = "Scan";
            this.btnBuyScan.UseVisualStyleBackColor = true;
            this.btnBuyScan.Click += new System.EventHandler(this.btnBuyScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Price : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(601, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "0.00";
            // 
            // panelProMenu
            // 
            this.panelProMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProMenu.Controls.Add(this.button1);
            this.panelProMenu.Controls.Add(this.btnAdd);
            this.panelProMenu.Controls.Add(this.txtPrice);
            this.panelProMenu.Controls.Add(this.txtBarCode);
            this.panelProMenu.Controls.Add(this.txtName);
            this.panelProMenu.Location = new System.Drawing.Point(3, 353);
            this.panelProMenu.Name = "panelProMenu";
            this.panelProMenu.Size = new System.Drawing.Size(713, 44);
            this.panelProMenu.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Enter Name...";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(169, 12);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(121, 20);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.Text = "Enter Barcode...";
            this.txtBarCode.Enter += new System.EventHandler(this.txtBarCode_Enter);
            this.txtBarCode.Leave += new System.EventHandler(this.txtBarCode_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(310, 12);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "Enter Price...";
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(593, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 15);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(702, 322);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 9);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Size = new System.Drawing.Size(702, 322);
            this.splitContainer2.SplitterDistance = 346;
            this.splitContainer2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(315, 9);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // ProduntSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 446);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "ProduntSelling";
            this.Text = "BarCodeItemPurchased.";
            this.Load += new System.EventHandler(this.ProduntSelling_Load);
            this.tabControl.ResumeLayout(false);
            this.tabBuy.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.panelBuyShow.ResumeLayout(false);
            this.panelBuyMenu.ResumeLayout(false);
            this.panelBuyMenu.PerformLayout();
            this.panelProMenu.ResumeLayout(false);
            this.panelProMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBuy;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.Panel panelBuyMenu;
        private System.Windows.Forms.Panel panelBuyShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuyScan;
        private System.Windows.Forms.TextBox txtBuyItem;
        private System.Windows.Forms.Panel panelProMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuy;
    }
}


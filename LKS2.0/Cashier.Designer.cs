namespace LKS2._0
{
    partial class Cashier
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
            this.cart = new System.Windows.Forms.ListView();
            this.orders = new System.Windows.Forms.ListBox();
            this.newOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cart
            // 
            this.cart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.cart.Location = new System.Drawing.Point(163, 29);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(430, 212);
            this.cart.TabIndex = 6;
            this.cart.UseCompatibleStateImageBehavior = false;
            this.cart.View = System.Windows.Forms.View.Details;
            // 
            // orders
            // 
            this.orders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.orders.FormattingEnabled = true;
            this.orders.Location = new System.Drawing.Point(0, 29);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(157, 212);
            this.orders.TabIndex = 5;
            this.orders.SelectedIndexChanged += new System.EventHandler(this.orders_SelectedIndexChanged);
            // 
            // newOrder
            // 
            this.newOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newOrder.Location = new System.Drawing.Point(82, 248);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(75, 49);
            this.newOrder.TabIndex = 7;
            this.newOrder.Text = "Pesanan Baru";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total";
            // 
            // totalText
            // 
            this.totalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.Location = new System.Drawing.Point(157, 265);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(68, 32);
            this.totalText.TabIndex = 9;
            this.totalText.Text = "Rp. 0";
            // 
            // pay
            // 
            this.pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pay.Location = new System.Drawing.Point(506, 248);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(75, 49);
            this.pay.TabIndex = 10;
            this.pay.Text = "Bayar";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(129, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(452, 13);
            this.name.TabIndex = 23;
            this.name.Text = "Nama Pemesan: -";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nama";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jumlah";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subtotal";
            this.columnHeader3.Width = 151;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 90;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 308);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.orders);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView cart;
        private System.Windows.Forms.ListBox orders;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
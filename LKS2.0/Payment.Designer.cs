namespace LKS2._0
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bill = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.method = new System.Windows.Forms.ComboBox();
            this.bank = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cardNo = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "PEMBAYARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pembeli";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(79, 24);
            this.name.TabIndex = 15;
            this.name.Text = "Pembeli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tagihan";
            // 
            // bill
            // 
            this.bill.AutoSize = true;
            this.bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.Location = new System.Drawing.Point(13, 97);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(54, 24);
            this.bill.TabIndex = 17;
            this.bill.Text = "Rp. 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Metode Pembayaran";
            // 
            // method
            // 
            this.method.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.method.FormattingEnabled = true;
            this.method.Items.AddRange(new object[] {
            "Tunai",
            "Debit",
            "Kredit"});
            this.method.Location = new System.Drawing.Point(17, 157);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(330, 21);
            this.method.TabIndex = 19;
            this.method.Text = "Tunai";
            this.method.SelectedIndexChanged += new System.EventHandler(this.method_SelectedIndexChanged);
            // 
            // bank
            // 
            this.bank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bank.Enabled = false;
            this.bank.FormattingEnabled = true;
            this.bank.Items.AddRange(new object[] {
            "BCA",
            "BNI",
            "Mandiri"});
            this.bank.Location = new System.Drawing.Point(17, 197);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(330, 21);
            this.bank.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nomor Kartu";
            // 
            // cardNo
            // 
            this.cardNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardNo.Enabled = false;
            this.cardNo.Location = new System.Drawing.Point(17, 237);
            this.cardNo.MaxLength = 16;
            this.cardNo.Name = "cardNo";
            this.cardNo.Size = new System.Drawing.Size(330, 20);
            this.cardNo.TabIndex = 23;
            // 
            // pay
            // 
            this.pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pay.Location = new System.Drawing.Point(272, 263);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(75, 49);
            this.pay.TabIndex = 24;
            this.pay.Text = "Bayar";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 324);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.cardNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.method);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox method;
        private System.Windows.Forms.ComboBox bank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cardNo;
        private System.Windows.Forms.Button pay;
    }
}
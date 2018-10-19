namespace LKS2._0
{
    partial class ChangePass
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
            this.oldPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newPassCriteriaChecker = new System.Windows.Forms.Panel();
            this.newPassConfirmation = new System.Windows.Forms.Panel();
            this.apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "UBAH PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password Lama";
            // 
            // oldPass
            // 
            this.oldPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPass.Location = new System.Drawing.Point(17, 69);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(330, 20);
            this.oldPass.TabIndex = 15;
            // 
            // newPass
            // 
            this.newPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPass.Location = new System.Drawing.Point(17, 108);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(330, 20);
            this.newPass.TabIndex = 17;
            this.newPass.TextChanged += new System.EventHandler(this.newPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password Baru";
            // 
            // cNewPass
            // 
            this.cNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cNewPass.Location = new System.Drawing.Point(15, 147);
            this.cNewPass.Name = "cNewPass";
            this.cNewPass.Size = new System.Drawing.Size(330, 20);
            this.cNewPass.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Konfirmasi Password";
            // 
            // newPassCriteriaChecker
            // 
            this.newPassCriteriaChecker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newPassCriteriaChecker.Location = new System.Drawing.Point(353, 108);
            this.newPassCriteriaChecker.Name = "newPassCriteriaChecker";
            this.newPassCriteriaChecker.Size = new System.Drawing.Size(20, 20);
            this.newPassCriteriaChecker.TabIndex = 21;
            // 
            // newPassConfirmation
            // 
            this.newPassConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newPassConfirmation.Location = new System.Drawing.Point(353, 147);
            this.newPassConfirmation.Name = "newPassConfirmation";
            this.newPassConfirmation.Size = new System.Drawing.Size(20, 20);
            this.newPassConfirmation.TabIndex = 22;
            // 
            // apply
            // 
            this.apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apply.Location = new System.Drawing.Point(298, 173);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 49);
            this.apply.TabIndex = 23;
            this.apply.Text = "Simpan";
            this.apply.UseVisualStyleBackColor = true;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 234);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.newPassConfirmation);
            this.Controls.Add(this.newPassCriteriaChecker);
            this.Controls.Add(this.cNewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel newPassCriteriaChecker;
        private System.Windows.Forms.Panel newPassConfirmation;
        private System.Windows.Forms.Button apply;
    }
}
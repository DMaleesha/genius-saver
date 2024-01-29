
namespace Financial
{
    partial class frmPortfolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortfolio));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaymentHistory = new System.Windows.Forms.Button();
            this.btnTransactionSummery = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Generate Reports";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.button1.Location = new System.Drawing.Point(47, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Account Summary Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPaymentHistory.FlatAppearance.BorderSize = 0;
            this.btnPaymentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnPaymentHistory.Location = new System.Drawing.Point(47, 161);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(296, 44);
            this.btnPaymentHistory.TabIndex = 12;
            this.btnPaymentHistory.Text = "Payment History Report";
            this.btnPaymentHistory.UseVisualStyleBackColor = false;
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click);
            // 
            // btnTransactionSummery
            // 
            this.btnTransactionSummery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnTransactionSummery.FlatAppearance.BorderSize = 0;
            this.btnTransactionSummery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionSummery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionSummery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnTransactionSummery.Location = new System.Drawing.Point(47, 243);
            this.btnTransactionSummery.Name = "btnTransactionSummery";
            this.btnTransactionSummery.Size = new System.Drawing.Size(296, 44);
            this.btnTransactionSummery.TabIndex = 13;
            this.btnTransactionSummery.Text = "Transaction Summary Report";
            this.btnTransactionSummery.UseVisualStyleBackColor = false;
            this.btnTransactionSummery.Click += new System.EventHandler(this.btnTransactionSummery_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(654, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTransactionSummery);
            this.Controls.Add(this.btnPaymentHistory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPortfolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPortfolio";
            this.Load += new System.EventHandler(this.frmPortfolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPaymentHistory;
        private System.Windows.Forms.Button btnTransactionSummery;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
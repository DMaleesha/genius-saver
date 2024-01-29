
namespace Financial
{
    partial class rptPaymentHistory
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PaymentHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentHistory1 = new Financial.PaymentHistory1();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentHistoryTableAdapter = new Financial.PaymentHistory1TableAdapters.PaymentHistoryTableAdapter();
            this.AccSummery1 = new Financial.AccSummery1();
            this.AccountDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountDataTableAdapter = new Financial.AccSummery1TableAdapters.AccountDataTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentHistory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccSummery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentHistoryBindingSource
            // 
            this.PaymentHistoryBindingSource.DataMember = "PaymentHistory";
            this.PaymentHistoryBindingSource.DataSource = this.PaymentHistory1;
            // 
            // PaymentHistory1
            // 
            this.PaymentHistory1.DataSetName = "PaymentHistory1";
            this.PaymentHistory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblClose.Location = new System.Drawing.Point(1255, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 28);
            this.lblClose.TabIndex = 16;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Payment History Report";
            // 
            // PaymentHistoryTableAdapter
            // 
            this.PaymentHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // AccSummery1
            // 
            this.AccSummery1.DataSetName = "AccSummery1";
            this.AccSummery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AccountDataBindingSource
            // 
            this.AccountDataBindingSource.DataMember = "AccountData";
            this.AccountDataBindingSource.DataSource = this.AccSummery1;
            // 
            // AccountDataTableAdapter
            // 
            this.AccountDataTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PaymentHistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Financial.PaymentHistoryWizard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1249, 642);
            this.reportViewer1.TabIndex = 17;
            // 
            // rptPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rptPaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rptPaymentHistory";
            this.Load += new System.EventHandler(this.rptPaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentHistory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccSummery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource PaymentHistoryBindingSource;
        private PaymentHistory1 PaymentHistory1;
        private PaymentHistory1TableAdapters.PaymentHistoryTableAdapter PaymentHistoryTableAdapter;
        private System.Windows.Forms.BindingSource AccountDataBindingSource;
        private AccSummery1 AccSummery1;
        private AccSummery1TableAdapters.AccountDataTableAdapter AccountDataTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
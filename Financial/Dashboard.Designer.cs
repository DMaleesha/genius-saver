
namespace Financial
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelSide = new System.Windows.Forms.Panel();
            this.pnlNavi = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEarn = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPortfolio = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnAddNewAcc = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblRestore = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelSide.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelSide.Controls.Add(this.pnlNavi);
            this.panelSide.Controls.Add(this.btnLogOut);
            this.panelSide.Controls.Add(this.btnEarn);
            this.panelSide.Controls.Add(this.btnHistory);
            this.panelSide.Controls.Add(this.btnPortfolio);
            this.panelSide.Controls.Add(this.btnTransfer);
            this.panelSide.Controls.Add(this.btnPayment);
            this.panelSide.Controls.Add(this.btnAddNewAcc);
            this.panelSide.Controls.Add(this.btnHome);
            this.panelSide.Controls.Add(this.panel2);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(300, 673);
            this.panelSide.TabIndex = 0;
            // 
            // pnlNavi
            // 
            this.pnlNavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.pnlNavi.Location = new System.Drawing.Point(292, 128);
            this.pnlNavi.Name = "pnlNavi";
            this.pnlNavi.Size = new System.Drawing.Size(10, 100);
            this.pnlNavi.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 615);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(300, 58);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "     Logout";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEarn
            // 
            this.btnEarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnEarn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEarn.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnEarn.FlatAppearance.BorderSize = 0;
            this.btnEarn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEarn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnEarn.Image = ((System.Drawing.Image)(resources.GetObject("btnEarn.Image")));
            this.btnEarn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEarn.Location = new System.Drawing.Point(0, 448);
            this.btnEarn.Name = "btnEarn";
            this.btnEarn.Size = new System.Drawing.Size(300, 58);
            this.btnEarn.TabIndex = 6;
            this.btnEarn.Text = "     Earn";
            this.btnEarn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEarn.UseVisualStyleBackColor = false;
            this.btnEarn.Click += new System.EventHandler(this.btnEarn_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 390);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(300, 58);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "     Payment History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPortfolio
            // 
            this.btnPortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPortfolio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPortfolio.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnPortfolio.FlatAppearance.BorderSize = 0;
            this.btnPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortfolio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnPortfolio.Image = ((System.Drawing.Image)(resources.GetObject("btnPortfolio.Image")));
            this.btnPortfolio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPortfolio.Location = new System.Drawing.Point(0, 332);
            this.btnPortfolio.Name = "btnPortfolio";
            this.btnPortfolio.Size = new System.Drawing.Size(300, 58);
            this.btnPortfolio.TabIndex = 6;
            this.btnPortfolio.Text = "     My Portfolio";
            this.btnPortfolio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPortfolio.UseVisualStyleBackColor = false;
            this.btnPortfolio.Click += new System.EventHandler(this.btnPortfolio_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(0, 274);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(300, 58);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "     Transfer Money";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(0, 216);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(300, 58);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "     Bill Payment";
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnAddNewAcc
            // 
            this.btnAddNewAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAddNewAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewAcc.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnAddNewAcc.FlatAppearance.BorderSize = 0;
            this.btnAddNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAddNewAcc.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewAcc.Image")));
            this.btnAddNewAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewAcc.Location = new System.Drawing.Point(0, 158);
            this.btnAddNewAcc.Name = "btnAddNewAcc";
            this.btnAddNewAcc.Size = new System.Drawing.Size(300, 58);
            this.btnAddNewAcc.TabIndex = 6;
            this.btnAddNewAcc.Text = "     Add New Account";
            this.btnAddNewAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewAcc.UseVisualStyleBackColor = false;
            this.btnAddNewAcc.Click += new System.EventHandler(this.btnBanking_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 58);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "     Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 100);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelTitle.Controls.Add(this.lblMinimize);
            this.panelTitle.Controls.Add(this.lblRestore);
            this.panelTitle.Controls.Add(this.lblClose);
            this.panelTitle.Controls.Add(this.lblUserDetails);
            this.panelTitle.Controls.Add(this.lblName);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(300, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(962, 100);
            this.panelTitle.TabIndex = 1;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblMinimize.Location = new System.Drawing.Point(881, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(27, 28);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "O";
            this.toolTip1.SetToolTip(this.lblMinimize, "Minimize");
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblRestore.Location = new System.Drawing.Point(908, 0);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(27, 28);
            this.lblRestore.TabIndex = 1;
            this.lblRestore.Text = "O";
            this.toolTip1.SetToolTip(this.lblRestore, "Maximize");
            this.lblRestore.Click += new System.EventHandler(this.lblRestore_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblClose.Location = new System.Drawing.Point(935, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "O";
            this.toolTip1.SetToolTip(this.lblClose, "Close");
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblUserDetails.Location = new System.Drawing.Point(9, 59);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(144, 23);
            this.lblUserDetails.TabIndex = 2;
            this.lblUserDetails.Text = "Some user details";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblName.Location = new System.Drawing.Point(6, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 41);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Hi, Name";
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(300, 100);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(962, 573);
            this.panelFormLoader.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelSide.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnPortfolio;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnAddNewAcc;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlNavi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEarn;
        private System.Windows.Forms.Button btnLogOut;
    }
}
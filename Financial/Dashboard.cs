using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Financial
{
    public partial class Dashboard : Form
    {
        int userId;
        string fname;
        DateTime logDate;

        SqlConnection con;
        SqlCommand cmd;
        public Dashboard(string name, int ID)
        {
            InitializeComponent();
            lblName.Text = "Hi, "+name;
            userId = ID;
            fname = name;

            con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
            getLogDate();
            displayMembership();

            pnlNavi.Height = btnHome.Height;
            pnlNavi.Top = btnHome.Top;
            pnlNavi.Left = btnHome.Right - pnlNavi.Width;
            btnHome.BackColor = Color.FromArgb(20, 24, 44);
            //Open Home form
            this.panelFormLoader.Controls.Clear();
            frmHome frmHomeObj = new frmHome(userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(frmHomeObj);
            frmHomeObj.Show();
        }
        private void displayMembership()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = logDate;

            TimeSpan t = d1 - d2;
            double NrOfDays = t.TotalDays;
            if(NrOfDays>60)
            {
                lblUserDetails.ForeColor = Color.FromArgb(255, 215, 0);
                lblUserDetails.Text = "Gold Member";
            }
            else if(NrOfDays>30)
            {
                lblUserDetails.ForeColor = Color.FromArgb(192, 192, 192);
                lblUserDetails.Text = "Silver Member";
            }
            else if(NrOfDays<30)
            {
                lblUserDetails.Text = "Bronze Member";
            }
        }

        private void getLogDate()
        {
            try
            {
                con.Open();
                string q = "select LogDate from UserData where UserID = '" + userId.ToString() + "'";
                cmd = new SqlCommand(q, con);

                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    logDate = (DateTime)reader["LogDate"];
                }
                else
                {
                    frmNotification notification = new frmNotification();
                    notification.ShowNotification("Error", "Please Try Again", "warning");
                }

                con.Close();
            }
            catch(Exception)
            {
                frmNotification notification = new frmNotification();
                notification.ShowNotification("Error", "Please Try Again", "warning");
            }
        }
        private void checkData()
        {
            try
            {
                con.Open();
                string q = "select * from AccountData where UserId = '"+userId.ToString()+"'";
                cmd = new SqlCommand(q, con);
                int j = cmd.ExecuteNonQuery();
                if(j==0)
                {
                    btnPayment.Enabled = false;
                    btnTransfer.Enabled = false;
                    btnPortfolio.Enabled = false;
                    btnHistory.Enabled = false;
                    btnEarn.Enabled = false;
                }
            }
            catch(Exception)
            {
                frmNotification notification = new frmNotification();
                notification.ShowNotification("Error", "Please Try Again", "warning");
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            btnAddNewAcc.BackColor = Color.FromArgb(24, 30, 54);
            btnEarn.BackColor = Color.FromArgb(24, 30, 54);
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);
            btnPortfolio.BackColor = Color.FromArgb(24, 30, 54);
            btnTransfer.BackColor = Color.FromArgb(24, 30, 54);
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);

            pnlNavi.Height = btnHome.Height;
            pnlNavi.Top = btnHome.Top;
            pnlNavi.Left = btnHome.Right - pnlNavi.Width;
            btnHome.BackColor = Color.FromArgb(20, 24, 44);
            //Open Home form
            this.panelFormLoader.Controls.Clear();
            frmHome frmHomeObj = new frmHome(userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(frmHomeObj);
            frmHomeObj.Show();
        }

        private void btnBanking_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnEarn.BackColor = Color.FromArgb(24, 30, 54);
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);
            btnPortfolio.BackColor = Color.FromArgb(24, 30, 54);
            btnTransfer.BackColor = Color.FromArgb(24, 30, 54);
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);

            pnlNavi.Height = btnAddNewAcc.Height;
            pnlNavi.Top = btnAddNewAcc.Top;
            pnlNavi.Left = btnAddNewAcc.Right - pnlNavi.Width;
            btnAddNewAcc.BackColor = Color.FromArgb(20, 24, 44);
            //Open Banking form
            this.panelFormLoader.Controls.Clear();
            frmAddCard frmAddCardObj = new frmAddCard(userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(frmAddCardObj);
            frmAddCardObj.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnEarn.BackColor = Color.FromArgb(24, 30, 54);
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);
            btnPortfolio.BackColor = Color.FromArgb(24, 30, 54);
            btnAddNewAcc.BackColor = Color.FromArgb(24, 30, 54);
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);

            pnlNavi.Height = btnTransfer.Height;
            pnlNavi.Top = btnTransfer.Top;
            pnlNavi.Left = btnTransfer.Right - pnlNavi.Width;
            btnTransfer.BackColor = Color.FromArgb(20, 24, 44);

            this.panelFormLoader.Controls.Clear();
            frmTransfer frmTransferObj = new frmTransfer(userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(frmTransferObj);
            frmTransferObj.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnEarn.BackColor = Color.FromArgb(24, 30, 54);
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
            btnTransfer.BackColor = Color.FromArgb(24, 30, 54);
            btnPortfolio.BackColor = Color.FromArgb(24, 30, 54);
            btnAddNewAcc.BackColor = Color.FromArgb(24, 30, 54);
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);

            pnlNavi.Height = btnPayment.Height;
            pnlNavi.Top = btnPayment.Top;
            pnlNavi.Left = btnPayment.Right - pnlNavi.Width;
            btnPayment.BackColor = Color.FromArgb(20, 24, 44);

            //Open Bill Payment form
            this.panelFormLoader.Controls.Clear();
            BillPayment billPayment = new BillPayment(userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(billPayment);
            billPayment.Show();

        }
        private void btnEarn_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
            btnTransfer.BackColor = Color.FromArgb(24, 30, 54);
            btnPortfolio.BackColor = Color.FromArgb(24, 30, 54);
            btnAddNewAcc.BackColor = Color.FromArgb(24, 30, 54);
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);

            pnlNavi.Height = btnEarn.Height;
            pnlNavi.Top = btnEarn.Top;
            pnlNavi.Left = btnEarn.Right - pnlNavi.Width;
            btnEarn.BackColor = Color.FromArgb(20, 24, 44);

            this.panelFormLoader.Controls.Clear();
            frmEarn earn = new frmEarn(userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(earn);
            earn.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);
            btnEarn.BackColor = Color.FromArgb(24, 30, 54);
            btnTransfer.BackColor = Color.FromArgb(24, 30, 54);
            btnPortfolio.BackColor = Color.FromArgb(24, 30, 54);
            btnAddNewAcc.BackColor = Color.FromArgb(24, 30, 54);
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);

            pnlNavi.Height = btnHistory.Height;
            pnlNavi.Top = btnHistory.Top;
            pnlNavi.Left = btnHistory.Right - pnlNavi.Width;
            btnHistory.BackColor = Color.FromArgb(20, 24, 44);

            this.panelFormLoader.Controls.Clear();
            frmPaymentHistory frmPaymentHistory = new frmPaymentHistory(userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(frmPaymentHistory);
            frmPaymentHistory.Show();
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);
            btnEarn.BackColor = Color.FromArgb(24, 30, 54);
            btnTransfer.BackColor = Color.FromArgb(24, 30, 54);
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
            btnAddNewAcc.BackColor = Color.FromArgb(24, 30, 54);
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);

            pnlNavi.Height = btnPortfolio.Height;
            pnlNavi.Top = btnPortfolio.Top;
            pnlNavi.Left = btnPortfolio.Right - pnlNavi.Width;
            btnPortfolio.BackColor = Color.FromArgb(20, 24, 44);

            this.panelFormLoader.Controls.Clear();
            frmPortfolio frmPortfolio = new frmPortfolio(userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(frmPortfolio);
            frmPortfolio.Show();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);
            btnEarn.BackColor = Color.FromArgb(24, 30, 54);
            btnTransfer.BackColor = Color.FromArgb(24, 30, 54);
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
            btnAddNewAcc.BackColor = Color.FromArgb(24, 30, 54);

            pnlNavi.Height = btnLogOut.Height;
            pnlNavi.Top = btnLogOut.Top;
            pnlNavi.Left = btnLogOut.Right - pnlNavi.Width;
            btnLogOut.BackColor = Color.FromArgb(20, 24, 44);

            SignIn obj = new SignIn();
            obj.Show();
            this.Close();
        }
        private void lblRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

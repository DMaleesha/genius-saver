using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial
{
    public partial class frmTransfer : Form
    {
        decimal amt;
        int userID;
        decimal BalFrom;

        SqlConnection con;
        SqlCommand cmd;
        public frmTransfer(int id)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
            userID = id;

            cmbAccNum.TabIndex = 0;
            txtAccNumTo.TabIndex = 1;
            txtAmount.TabIndex = 2;
            btnTransfer.TabIndex = 3;
            btnClear.TabIndex = 4;

            lbl_errorMessage.Text = "";
            getAccNum();
            pictureIcon.Visible = false;
        }
        private void getAccNum()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select Acc_Num from AccountData where UserId = '"+userID.ToString()+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbAccNum.Items.Add(dr[0].ToString());
                }
                con.Close();
            }
            catch (Exception)
            {
                frmNotification notification = new frmNotification();
                notification.ShowNotification("Error", "Please Try Again.", "warning");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                amt = Convert.ToDecimal(txtAmount.Text);
                if (cmbAccNum.SelectedIndex == -1)
                    lbl_errorMessage.Text = "Please Select an Account Number";
                else if (!Regex.IsMatch(txtAccNumTo.Text, @"^\d{16}$"))
                    lbl_errorMessage.Text = "Invalid card number format";
                else if (amt < 0)
                    lbl_errorMessage.Text = "Please enter valid Amount";
                else if (txtAmount.Text.Length == 0)
                    lbl_errorMessage.Text = "Amount cannot be Blank";

                else
                {
                    BalFrom = GetAccBal(cmbAccNum.SelectedItem.ToString());
                    lbl_errorMessage.Text = "";
                    if (BalFrom < amt)
                        lbl_errorMessage.Text = "Account balance not Sufficient";
                    else
                    {
                        BalFrom = BalFrom - amt;
                        InsertPaymentHistory();
                    }
                }
            }
            catch(Exception)
            {
                frmNotification notification = new frmNotification();
                notification.ShowNotification("Error", "Please Try Again.", "warning");
            }
        }
        private decimal GetAccBal(string accNo)
        {
            try
            {
                string AccNum = accNo;
                decimal AccBal;
                string connectionString = "Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True";
                string querry = "select Balance from MyAccounts where AccNum = '"+ AccNum.ToString() + "' AND CustomerID = '" + userID.ToString() + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(querry, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        AccBal = (decimal)reader["Balance"];
                        return AccBal;
                    }
                    else
                    {
                        frmNotification notification = new frmNotification();
                        notification.ShowNotification("Error", "Please Try Again.", "warning");
                        return 0;
                    }
                }
            }
            catch(Exception)
            {
                frmNotification notification = new frmNotification();
                notification.ShowNotification("Error", "Please Try Again.", "warning");
                return 0;
            }
        }
        private void InsertPaymentHistory()
        {
            try
            {
                string payTo = "Transfer";
                con.Open();
                cmd = new SqlCommand("insert into PaymentHistory values ('" + userID.ToString() + "', '" + cmbAccNum.SelectedItem.ToString() + "', '" + amt.ToString() + "', '" + payTo.ToString() + "', '" + DateTime.Now.ToString() + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    decimal BalTo = GetAccBal(txtAccNumTo.Text);
                    BalTo = BalTo + amt;
                    cmd = new SqlCommand("update MyAccounts set Balance = '" +BalTo+ "' where AccNum = '" + txtAccNumTo.Text + "'", con);
                    int j = cmd.ExecuteNonQuery();
                    if (j == 1)
                    {
                        cmd = new SqlCommand("update MyAccounts set Balance = '"+BalFrom+"' where AccNum = '"+ cmbAccNum.SelectedItem.ToString() + "'", con);
                        int l = cmd.ExecuteNonQuery();
                        if (l == 1)
                        {
                            frmNotification notify = new frmNotification();
                            notify.ShowNotification("Info", "Payment successful!.", "info");
                            txtAccNumTo.Clear();
                            txtName.Clear();
                            txtAmount.Clear();
                            cmbAccNum.Items.Clear();
                        }
                        else
                        {
                            frmNotification notify = new frmNotification();
                            notify.ShowNotification("Error", "Payment unsuccessful. Please check your payment details and try again.", "error");
                        }
                    }
                    else
                    {
                        frmNotification notify = new frmNotification();
                        notify.ShowNotification("Error", "Payment unsuccessful. Please check your payment details and try again.", "error");
                    }
                }
                else
                {
                    frmNotification notify = new frmNotification();
                    notify.ShowNotification("Error", "Payment unsuccessful. Please check your payment details and try again.", "error");
                }
            }
            catch (Exception)
            {
                frmNotification notify = new frmNotification();
                notify.ShowNotification("Error", "Please Try Again Later. INSERT", "error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select Cus_Name from AccountData where Acc_Num = '"+txtAccNumTo.Text+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    txtName.Text = (string)dr["Cus_Name"];
                    pictureIcon.Visible = true;
                    pictureIcon.Image = Properties.Resources.check;
                }
                else
                {
                    pictureIcon.Visible = true;
                    pictureIcon.Image = Properties.Resources.close;
                }
                con.Close();
            }
            catch(Exception)
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbAccNum.SelectedIndex = -1;
            txtAccNumTo.Clear();
            txtAmount.Clear();
            txtName.Clear();
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            this.pnlQR.Controls.Clear();
            AccQR accQR = new AccQR(userID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlQR.Controls.Add(accQR);
            accQR.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial
{
    public partial class BillPayment : Form
    {
        int UserId;
        decimal amt;
        decimal balance;
        SqlConnection con;
        SqlCommand cmd;
        public BillPayment(int id)
        {
            InitializeComponent();
            UserId = id;
            lbl_errorMessage.Text = "";
            rdbCEB.Checked = true;
            cmbAccNum.TabIndex = 0;
            txtPayTo.TabIndex = 1;
            txtAmount.TabIndex = 2;
            btnPay.TabIndex = 3;
            btnClear.TabIndex = 4;

            con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
            getAccNum();
        }

        private void BillPayment_Load(object sender, EventArgs e)
        {
            
            
        }
        private void getAccNum()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select Acc_Num from AccountData where UserId = '" + UserId.ToString() + "'", con);
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
        private decimal GetAccBal(string accNo)
        {
            try
            {
                string AccNum = accNo;
                decimal AccBal;
                string connectionString = "Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True";
                string querry = "select Balance from MyAccounts where AccNum = '" + AccNum.ToString() + "' AND CustomerID = '" + UserId.ToString() + "'";

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
            catch (Exception)
            {
                frmNotification notification = new frmNotification();
                notification.ShowNotification("Error", "Please Try Again.", "warning");
                return 0;
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                amt = Convert.ToDecimal(txtAmount.Text);
                if (!rdbNWSDB.Checked && !rdbCEB.Checked && !rdbDialog.Checked && !rdbAirtel.Checked)
                    lbl_errorMessage.Text = "Please select an option.";
                else if (txtPayTo.Text.Any(char.IsLetter))
                    lbl_errorMessage.Text = "Please enter a valid Account Number";
                else if (cmbAccNum.SelectedIndex == -1)
                    lbl_errorMessage.Text = "Please select an Account Number.";
                else if (txtAmount.Text.Length == 0)
                    lbl_errorMessage.Text = "Please enter Amount";
                else if (amt == 0)
                    lbl_errorMessage.Text = "Amount cannot be 0";
                else if (txtAmount.Text.Any(char.IsLetter))
                    lbl_errorMessage.Text = "Please enter a valid Amount.";


                else
                {
                    lbl_errorMessage.Text = "";
                    balance = GetAccBal(cmbAccNum.SelectedItem.ToString());
                    if (balance < amt)
                        lbl_errorMessage.Text = "Account balance not Sufficient";
                    else
                    {
                        if (rdbNWSDB.Checked)
                        {
                            InsertPaymentHistory("NWSDB");
                        }
                        else if (rdbCEB.Checked)
                        {
                            InsertPaymentHistory("CEB");
                        }
                        else if (rdbDialog.Checked)
                        {
                            InsertPaymentHistory("Dialog");
                        }
                        else if (rdbAirtel.Checked)
                        {
                            InsertPaymentHistory("Airtel");
                        }
                    }
                }
            }
            catch(Exception)
            {
                frmNotification notify = new frmNotification();
                notify.ShowNotification("Error", "Invalid data entered.", "error");
            }
        }
        private void InsertPaymentHistory(string to)
        {
            try
            {
                string payTo = to;
                con.Open();
                cmd = new SqlCommand("insert into PaymentHistory values('"+UserId.ToString()+"', '"+cmbAccNum.SelectedItem.ToString()+"', '"+amt.ToString()+"', '"+payTo.ToString()+"', '"+DateTime.Now+"')", con);
                int i = cmd.ExecuteNonQuery();
                if(i == 1)
                {
                    balance -= amt;
                    cmd = new SqlCommand("update MyAccounts set Balance = '"+balance.ToString()+"' where AccNum = '"+ cmbAccNum.SelectedItem.ToString() + "'", con);
                    int j = cmd.ExecuteNonQuery();
                    if(j == 1)
                    {
                        frmNotification notify = new frmNotification();
                        notify.ShowNotification("Info", "Payment successful!.", "info");
                        rdbNWSDB.Checked = false;
                        rdbCEB.Checked = false;
                        rdbDialog.Checked = false;
                        rdbAirtel.Checked = false;
                        txtPayTo.Clear();
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
            catch(Exception)
            {
                frmNotification notify = new frmNotification();
                notify.ShowNotification("Error", "Please Try Again Later.", "error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbAccNum.SelectedIndex = -1;
            txtAmount.Clear();
            txtPayTo.Clear();

        }
    }
}

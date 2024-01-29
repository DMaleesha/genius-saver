using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Financial
{
    public partial class frmAddCard : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        int userId;
        public frmAddCard(int id)
        {
            InitializeComponent();
            lbl_errorMessage.Text = "";
            userId = id;
            txtCustomerName.TabIndex = 0;
            txtAccNo.TabIndex = 1;
            txtAccTitle.TabIndex = 2;
            cmbAccTyp.TabIndex = 3;
            txtTP.TabIndex = 4;
            txtEmail.TabIndex = 5;
            btnCreate.TabIndex = 6;
            btnClear.TabIndex = 7;
        }
        private void frmAddCard_Load(object sender, EventArgs e)
        {
            lbl_errorMessage.Text = userId.ToString();
            lbl_errorMessage.Text = "";
            con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerName.Text.Length == 0)
                    lbl_errorMessage.Text = "Enter Customer Name";
                else if (!Regex.IsMatch(txtAccNo.Text, @"^\d{16}$"))
                    lbl_errorMessage.Text = "Invalid card number format.\nPlease enter a 16-digit number with no letters or special characters.";
                else if (txtAccNo.Text.Length == 0)
                    lbl_errorMessage.Text = "Card Holder name cannot be Blank";
                else if (txtAccNo.Text == "0000000000000000")
                    lbl_errorMessage.Text = "Please Enter valid Account Number";
                else if (txtAccTitle.Text.Length == 0)
                    lbl_errorMessage.Text = "Account Title Cannot Be Blank";
                else if (cmbAccTyp.SelectedIndex == -1)
                    lbl_errorMessage.Text = "Please select an account type";
                else if (!Regex.IsMatch(txtTP.Text, @"^(?:\+94|0)[1-9]\d{8}$"))
                    lbl_errorMessage.Text = "Invalid phone number entered";
                else if (!Regex.IsMatch(txtEmail.Text, @"^[a-z][\w\.-]*[a-z0-9]@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$"))
                    lbl_errorMessage.Text = "Enter a valid email address";
                else
                {
                    lbl_errorMessage.Text = "";
                    //SQL
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO  AccountData VALUES ('" + userId.ToString() + "','" + txtCustomerName.Text + "', '" + txtAccNo.Text + "', '" + txtAccTitle.Text + "', '" + cmbAccTyp.Text + "', '" + txtTP.Text + "', '" + txtEmail.Text + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        int balance = 1000;
                        cmd = new SqlCommand("insert into MyAccounts values('" + txtAccNo.Text + "', '" + cmbAccTyp.Text + "', '" + balance.ToString() + "', '" + userId.ToString() + "')", con);
                        int j = cmd.ExecuteNonQuery();
                        if (j == 1)
                        {
                            frmNotification notify = new frmNotification();
                            notify.ShowNotification("Info", "Account created successfully.", "info");
                            txtAccNo.Clear();
                            txtAccTitle.Clear();
                            txtCustomerName.Clear();
                            txtEmail.Clear();
                            txtTP.Clear();
                            cmbAccTyp.Items.Clear();
                        }
                        else
                        {
                            frmNotification notify = new frmNotification();
                            notify.ShowNotification("Error", "Failed to create account.", "error");
                        }
                    }
                    else
                    {
                        frmNotification notify = new frmNotification();
                        notify.ShowNotification("Error", "Failed to create account.", "error");
                    }
                    con.Close();

                }

                }
            catch
            {
                frmNotification notify = new frmNotification();
                notify.ShowNotification("Error", "Please Try Again Later.", "error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccNo.Clear();
            txtAccTitle.Clear();
            txtCustomerName.Clear();
            txtEmail.Clear();
            txtTP.Clear();
            cmbAccTyp.Items.Clear();
        }
    }
}

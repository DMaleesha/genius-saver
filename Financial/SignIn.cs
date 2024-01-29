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
    public partial class SignIn : Form
    {
        DataBaseLogic obj = new DataBaseLogic();
        public SignIn()
        {
            InitializeComponent();
            txt_email.TabIndex = 0;
            txt_pwd.TabIndex = 1;
            checkBox1.TabIndex = 2;
            btnSignIn.TabIndex = 3;
            btnClear.TabIndex = 4;
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_email.Text))
            {
                lbl_errorMessage.Text = "E mail Cannot Be Blank";
                txt_email.Focus();
            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-z][\w\.-]*[a-z0-9]@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$"))
            {
                lbl_errorMessage.Text = "Enter a valid email address";
                txt_email.Focus();
            }
            else if (txt_pwd.Text.Length == 0)
            {
                lbl_errorMessage.Text = "Password cannot be blank";
                txt_pwd.Focus();
            }

            else if (!Regex.IsMatch(txt_pwd.Text, ("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")))
            {
                lbl_errorMessage.Text = "Invalid Password";
                txt_pwd.Focus();
            }
            else
            {
                try
                {
                    string q = "SELECT * FROM UserData WHERE E_mail='" + txt_email.Text+"' AND Password='"+txt_pwd.Text+"'";
                    SqlDataAdapter da = new SqlDataAdapter(q, con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string connectionString = "Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True";
                        string querry = "SELECT UserID, Fname FROM UserData WHERE E_mail='" + txt_email.Text+"' AND Password='"+txt_pwd.Text+"'";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(querry, connection);
                            connection.Open();

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                int userID = (int)reader["UserID"];
                                string Fname = (string)reader["Fname"];

                                //OPEN Dashboard
                                frmNotification notification = new frmNotification();
                                notification.ShowNotification("Info", "Sign In Successful", "info");
                                Dashboard dashboard = new Dashboard(Fname, userID);
                                dashboard.ShowDialog();
                                this.Hide();

                            }
                            else
                            {
                                frmNotification notification = new frmNotification();
                                notification.ShowNotification("Error", "Please Try Again", "warning");
                            }
                        }
                    }
                    else if (dt.Rows.Count == 0)
                    {
                        frmNotification noti = new frmNotification();
                        noti.ShowNotification("Error", "Invalid Email or Password.", "warning");
                        lbl_errorMessage.Text = "Invalid Email or Password.";
                        txt_email.Clear();
                        txt_pwd.Clear();
                        txt_email.Focus();
                    }
                }
                catch
                {
                    frmNotification notification = new frmNotification();
                    notification.ShowNotification("Error", "Try Again Later.", "warning");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            txt_email.Focus();
            lbl_errorMessage.Text = "";
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            //this.Close();
            SignUp obj = new SignUp();
            obj.ShowDialog();
        }

        //Show Password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txt_pwd.PasswordChar = '\0';
            }
            else
            {
                txt_pwd.PasswordChar = '•';
            }
        }

        //Clear
        private void button2_Click(object sender, EventArgs e)
        {
            lbl_errorMessage.Text = "";
            txt_email.Clear();
            txt_pwd.Clear();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

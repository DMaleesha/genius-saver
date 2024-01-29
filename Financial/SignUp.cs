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

namespace Financial
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            txt_firstName.TabIndex = 0;
            txt_lastName.TabIndex = 1;
            txt_username.TabIndex = 2;
            txt_email.TabIndex = 3;
            txt_password.TabIndex = 4;
            txt_confirmPwd.TabIndex = 5;
            chboxPassword.TabIndex = 6;
            btnSignup.TabIndex = 7;
            brnClear.TabIndex = 8;
        }
        DataBaseLogic DBobj = new DataBaseLogic();
        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_errorMsg.Text = "";
                //FIRST NAME
                if (string.IsNullOrEmpty(txt_firstName.Text))
                {
                    lbl_errorMsg.Text = "First Name cannot be blank";
                    txt_firstName.Focus();
                }
                else if (txt_firstName.Text.Length > 20 || txt_firstName.Text.Length < 2)
                {
                    lbl_errorMsg.Text = "Invalid First Name";
                    txt_firstName.Focus();
                }

                else if (!Regex.IsMatch(txt_firstName.Text, "^[A-Z][a-zA-Z]*$"))
                {
                    lbl_errorMsg.Text = "Name should start with a uppercase letter and\ncannot have numbers, special characters";
                    txt_firstName.Focus();
                }

                // LAST NAME
                else if (string.IsNullOrEmpty(txt_lastName.Text))
                {
                    lbl_errorMsg.Text = "Last Name cannot be blank";
                    txt_lastName.Focus();
                }
                else if (txt_lastName.Text.Length > 20 || txt_lastName.Text.Length < 2)
                {
                    lbl_errorMsg.Text = "Invalid Last Name";
                    txt_lastName.Focus();
                }
                else if (!Regex.IsMatch(txt_lastName.Text, "^[A-Z][a-zA-Z]*$"))
                {
                    lbl_errorMsg.Text = "Name should start with a uppercase letter and\ncannot have numbers, special characters";
                    txt_lastName.Focus();
                }
                else if (txt_lastName.Text == txt_firstName.Text)
                {
                    lbl_errorMsg.Text = "First name and Last name cannot be same";
                    txt_lastName.Focus();
                }

                // USERNAME
                else if (txt_username.TextLength == 0)
                {
                    lbl_errorMsg.Text = "Username cannot be blank";
                    txt_username.Focus();
                }
                else if (!Regex.IsMatch(txt_username.Text, "^[a-zA-Z0-9_-]{3,15}$"))
                {
                    lbl_errorMsg.Text = "Invalid username";
                    txt_username.Focus();
                }

                // E MAIL
                else if (txt_email.Text.Length == 0)
                {
                    lbl_errorMsg.Text = "Email cannot be blank";
                    txt_email.Focus();
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-z][\w\.-]*[a-z0-9]@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$"))
                {
                    lbl_errorMsg.Text = "Enter a valid Email address";
                    txt_email.Focus();
                }

                // PASSWORD
                else if (txt_password.Text.Length == 0)
                {
                    lbl_errorMsg.Text = "Password cannot be blank";
                    txt_password.Focus();
                }
                else if (!Regex.IsMatch(txt_password.Text, ("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")))
                {
                    lbl_errorMsg.Text = "Invalid Password";
                    txt_password.Focus();
                }

                //CONFIRM PASSWORD
                else if (txt_confirmPwd.Text.Length == 0)
                {
                    lbl_errorMsg.Text = "Confirm password cannot be blank";
                    txt_confirmPwd.Focus();
                }
                else if (txt_confirmPwd.Text != txt_password.Text)
                {
                    lbl_errorMsg.Text = "Confirm password and Password does not match";
                    txt_confirmPwd.Focus();
                }
                else
                {
                    string q = "insert into UserData values('" + txt_firstName.Text + "', '" + txt_lastName.Text + "', '" + txt_username.Text + "', '" + txt_email.Text + "', '" + txt_password.Text + "', '"+DateTime.Now.ToString()+"')";
                    int line = DBobj.Insert_Update_Delete(q);
                    if (line == 1)
                    {
                        frmNotification obj = new frmNotification();
                        obj.ShowNotification("Info", "Sign Up Successfully", "info");
                        SignIn signIn = new SignIn();
                        signIn.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        frmNotification obj = new frmNotification();
                        obj.ShowNotification("Error", "Sign Up Unsuccessfully", "error");
                    }
                }
            }
            catch(Exception)
            {
                frmNotification obj = new frmNotification();
                obj.ShowNotification("Error", "Try Again Later", "error");
            }
        }

        private void chboxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chboxPassword.Checked)
            {
                txt_password.PasswordChar = '\0';
                txt_confirmPwd.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '•';
                txt_confirmPwd.PasswordChar = '•';
            }
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_username.Clear();
            txt_email.Clear();
            txt_password.Clear();
            txt_confirmPwd.Clear();
        }

        private void SignUp_Load_1(object sender, EventArgs e)
        {
            txt_firstName.Focus();
            lbl_errorMsg.Text = "";
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn obj = new SignIn();
            obj.ShowDialog();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

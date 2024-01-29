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
    public partial class frmHome : Form
    {
        int userID;
        private int imgNum = 1;

        private void LoadNextImg()
        {
            if(imgNum == 6)
            {
                imgNum = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.png", imgNum);
            imgNum++;
        }
        public frmHome(int ID)
        {
            InitializeComponent();
            
            userID = ID;
        }
        private void btnSaving_Click(object sender, EventArgs e)
        {
            frmSavingAccount frmAccount = new frmSavingAccount("Savings Account", userID);
            frmAccount.ShowDialog();

        }

        private void btnChecking_Click(object sender, EventArgs e)
        {
            frmSavingAccount frmSaving = new frmSavingAccount("Checking Account", userID);
            frmSaving.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }
    }
}

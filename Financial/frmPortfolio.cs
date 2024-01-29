using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial
{
    public partial class frmPortfolio : Form
    {
        int userID;
        public frmPortfolio(int id)
        {
            InitializeComponent();
            userID = id;
        }

        private void frmPortfolio_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptAccountSummary rptAccountSummary = new rptAccountSummary(userID);
            rptAccountSummary.ShowDialog();
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            rptPaymentHistory rptPayment = new rptPaymentHistory(userID);
            rptPayment.ShowDialog();
        }

        private void btnTransactionSummery_Click(object sender, EventArgs e)
        {
            rptTransactionSummery rptTransaction = new rptTransactionSummery(userID);
            rptTransaction.ShowDialog();
        }
    }
}

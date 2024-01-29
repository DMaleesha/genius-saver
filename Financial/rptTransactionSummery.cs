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
    public partial class rptTransactionSummery : Form
    {
        int userID;
        public rptTransactionSummery(int id)
        {
            InitializeComponent();
            userID = id;
        }

        private void rptTransactionSummery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TransactionSummeryDataSet1.PaymentHistory' table. You can move, or remove it, as needed.
            this.PaymentHistoryTableAdapter.Fill(this.TransactionSummeryDataSet1.PaymentHistory, userID);
            this.reportViewer1.RefreshReport();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmSavingAccount : Form
    {
        SqlConnection con;

        string AccType;
        int userId;
        public frmSavingAccount(string Typ, int Id)
        {
            InitializeComponent();
            AccType = Typ;
            userId = Id;

            lblAccTyp.Text = Typ;
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
                string que = "select AccNum, AccType, Balance from MyAccounts where CustomerID = '" + userId.ToString() + "' AND AccType = '" + Typ.ToString() + "'";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(que, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView.DataSource = dt;

                con.Close();
            }
            catch(Exception)
            {
                frmNotification notification = new frmNotification();
                notification.ShowNotification("Error", "Please Try Again.", "warning");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

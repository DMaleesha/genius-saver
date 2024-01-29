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
using QRCoder;

namespace Financial
{
    public partial class AccQR : Form
    {
        private int userID;
        SqlConnection con;
        SqlCommand cmd;
        public AccQR(int uID)
        {
            InitializeComponent();
            userID = uID;
            con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
        }

        private void cmbAccNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateQRCode(Convert.ToString(cmbAccNum.SelectedItem));
        }
        private void GenerateQRCode(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5);
            pictureBox1.Image = qrCodeImage;
        }

        private void AccQR_Load(object sender, EventArgs e)
        {
            getAccNum();
        }
        private void getAccNum()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select Acc_Num from AccountData where UserId = '" + userID.ToString() + "'", con);
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
    }
}

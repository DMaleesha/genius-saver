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
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace Financial
{
    public partial class frmPaymentHistory : Form
    {
        int userID;
        SqlConnection conn;
        SqlCommand comd;
        public frmPaymentHistory(int id)
        {
            InitializeComponent();
            this.ClientSize = new Size(962, 573);
            userID = id;
            conn = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
            //checkPayHistory();
        }
        private void checkPayHistory()
        {
            try
            {
                conn.Open();
                string q = "select * from PaymentHistory where CustomerID = '" + userID.ToString() + "'";
                comd = new SqlCommand(q, conn);
                int a = comd.ExecuteNonQuery();
                if (a == 1)
                {
                    //lblNoData.Text = "PASS";
                }
                else
                {
                    //lblNoData.Text = "FAIL";
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        private void frmPaymentHistory_Load(object sender, EventArgs e)
        {
            barChart();
        }
        private void barChart()
        {
            string connectionString = "Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT PayTo, SUM(PayAmount) as TotalAmount FROM PaymentHistory WHERE CustomerID = '" + userID.ToString() + "' GROUP BY PayTo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string payTo = reader.GetString(0);
                            decimal totalAmount = reader.GetDecimal(1);

                            // Add a new data point to the chart for each record in the query
                            chart1.Series[0].Points.AddXY(payTo, totalAmount);
                        }
                    }
                }

                con.Close();
            }

            // Set the chart title and axis labels
            chart1.Titles.Add("Total Payments");
            chart1.ChartAreas[0].AxisX.Title = "PayTo";
            chart1.ChartAreas[0].AxisY.Title = "Total Amount";

            // Set the chart type to a bar chart
            chart1.Series[0].ChartType = SeriesChartType.Bar;
        }
        private void btnSummary_Click(object sender, EventArgs e)
        {
            PaymentSummery paymentSummery = new PaymentSummery(userID);
            paymentSummery.ShowDialog();
        }
    }
}

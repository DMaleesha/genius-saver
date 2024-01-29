using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Financial
{
    class DataBaseLogic
    {
        SqlCommand cmd;
        SqlConnection con;
        public DataBaseLogic()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
        }
        public int Insert_Update_Delete(String a)
        {
            con.Open();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataTable display(string a)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Insert Into Card_Details
        public int insertIntoCard_Details(String b)
        {
            con.Open();
            cmd = new SqlCommand(b, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

    }
}

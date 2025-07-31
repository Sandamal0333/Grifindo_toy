using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Grifindo_toy
{
    class DBConnect
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader read;
        DataSet dst;

        string sql;

        public SqlConnection conn()
        {
            sql = @"Data Source=LAPTOP-6G7M5J6M;Initial Catalog=Grifindo_Toy;Integrated Security=True";
            con = new SqlConnection(sql);
            con.Open();
            return con;

        }

        public void closeCon()
        {
            con.Close();
        }

        public object showRec(string qry)
        {
            cmd = new SqlCommand(qry, con);
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dst = new DataSet());
            object dgv = dst.Tables[0];
            return dgv;

        }

        public SqlDataReader reader(string qry)
        {
            cmd = new SqlCommand(qry, con);
            read = cmd.ExecuteReader();
            return read;

        }

        public void recOpr(string qry)
        {
            cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_397_Quan_Ly_Khach_San
{
    class KetNoiCSDL
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Downloads\CDIO_397_Quan_Ly_Khach_San\CDIO_397_Quan_Ly_Khach_San\QLKS.mdf;Integrated Security=True";
        SqlConnection con;

        public KetNoiCSDL()
        {
            con = new SqlConnection(constr);
        }

        void Open()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
        }

        void Close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public int execNonQuery(string sql, object[] varName, object[] varValue)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            if (varName != null)
                for (int i = 0; i < varName.Length; i++)
                {
                    cmd.Parameters.AddWithValue(varName[i] + "", varValue[i]);
                }

            Open();
            int res = cmd.ExecuteNonQuery();//trả về số dòng bị tác động
            Close();
            return res;
        }

        public object execScalar(string sql, object[] varName, object[] varValue)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            if (varName != null)
                for (int i = 0; i < varName.Length; i++)
                {
                    cmd.Parameters.AddWithValue(varName[i] + "", varValue[i]);
                }

            Open();
            object res = cmd.ExecuteScalar();//trả về một giá trị duy nhất
            Close();
            return res;
        }

        public DataSet GetDataSet(string sql, object[] varName, object[] varValue)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (varName != null)
                for (int i = 0; i < varName.Length; i++)
                {
                    cmd.Parameters.AddWithValue(varName[i] + "", varValue[i]);
                }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        bool updateDB(DataTable dt, string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}

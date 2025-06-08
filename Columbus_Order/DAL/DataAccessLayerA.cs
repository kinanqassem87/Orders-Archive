using Columbus_Order.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Columbus_Order.DAL
{
    class DataAccessLayerA
    {
        //public static string con = "Server= Admin; Database= CV_Archive;User ID=sa ;Password=123;Pooling=false;";
         public static string con = "Server= Admin; Database= CV_Archive;Integrated Security=True;Pooling=false;";
        //public static string con = @"Server =192.168.1.22\vd; Database= CV_Archive;User ID=kinanQA;Password=Col@1Winner@2Harfouch?;Pooling=false;";
        
        public static SqlConnection cn;
        //open the connection 
        public static void Open()
        {
            cn = new SqlConnection(con);
            cn.Open();

        }
        //close the connection 
        public static void Close()
        {

            cn = new SqlConnection(con);
            cn.Close();

        }
        //return one value
        public static object ExcuteScalar(string query, CommandType type, params SqlParameter[] arr)
        {
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            object o = cmd.ExecuteScalar();
            return o;

        }
        //delete,Update,insert return number of effect rows
        public static int ExecuteNonQuery(string query, CommandType type, params SqlParameter[] arr)
        {
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            int n = cmd.ExecuteNonQuery();
            return n;

        }
        //return table
        public static DataTable ExecuteTable(string query, CommandType type, params SqlParameter[] arr)
        {
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //create parameter to use above function return parameter
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;
        }


    }
}

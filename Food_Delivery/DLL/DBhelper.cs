﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DBhelper
    {
        public SqlCommand cmd;
        public SqlConnection con;
        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=RAZI;Initial Catalog=FoodOrderingProject;Integrated Security=True");
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            return con;
        }

        public DataTable getdatatable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Getdatatabel(SortedList list, string query)
        {
            SqlCommand cmd = new SqlCommand(query, GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            if (!(list.Count == 0))
            {
                string[] mKeys = new string[list.Count];
                list.Keys.CopyTo(mKeys, 0);
                int i = 0;
                for (i = 1; i <= list.Count; i++)
                {
                    cmd.Parameters.Add(new SqlParameter("@" + mKeys[i - 1], list[mKeys[i - 1]]));


                }
            }

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public object execscalar(string query)
        {

            SqlCommand cmd = new SqlCommand(query, GetConnection());
            object s;
            s = cmd.ExecuteScalar();
            return s;
        }
        public int execquery(string query)
        {

            SqlCommand cmd = new SqlCommand(query, GetConnection());
            return cmd.ExecuteNonQuery();
        }

        public string executeprocedure(SortedList list, string query)
        {
            //object obj = new object();
            try
            {
                SqlCommand cmd = new SqlCommand(query, GetConnection());
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                if (!(list.Count == 0))
                {

                    string[] mKeys = new string[list.Count];
                    list.Keys.CopyTo(mKeys, 0);
                    int i = 0;
                    for (i = 1; i <= list.Count; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + mKeys[i - 1], list[mKeys[i - 1]]));

                    }
                }
                return cmd.ExecuteScalar().ToString();

            }
            catch (Exception exe)
            {
                return "-1";
            }
            finally
            {
                if (GetConnection().State == ConnectionState.Open)
                {

                    GetConnection().Close();

                }
            }
        }
    }
}

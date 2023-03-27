using BLL.User.Property;
using DLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL.User.Manager
{
    public class UserLoginManager
    {
        private DBhelper db_obj = new DBhelper();
        public UserLoginProperty user_log_Pro = new UserLoginProperty();
        private SortedList S1 = new SortedList();

        public string user_login()
        {
            S1.Clear();
            string s1;
            S1.Add("Username", user_log_Pro.Username);
            S1.Add("Password", user_log_Pro.Password);
         DataTable dt= db_obj.Getdatatabel(S1,"User_Login");
            List<UserLoginProperty> _list = new List<UserLoginProperty>();
            if(dt.Rows.Count>0)
            {
                s1 = "Success";
                user_log_Pro.UID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
               
            }
            else
            {
                s1 = "Error";
            }
            return s1;

        }

        public void GetUserID()
        {
            S1.Clear();
            S1.Add("Username", user_log_Pro.Username);
            S1.Add("Password", user_log_Pro.Password);
            DataTable dt = new DataTable();
            dt = db_obj.Getdatatabel(S1, "getdata_View_Profile");
            if (dt.Rows.Count > 0)
            {
                user_log_Pro.UID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
               

            }
        }
    }
}

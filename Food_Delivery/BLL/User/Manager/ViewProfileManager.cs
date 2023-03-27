using BLL.User.Property;
using DLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.User.Manager
{
    
    public class ViewProfileManager
    {
        private DBhelper db_obj = new DBhelper();
        public ViewProfileProperty view_pro = new ViewProfileProperty();
        private SortedList S1 = new SortedList();
       

        public void ViewProfiledata()
        {
            S1.Clear();
            S1.Add("Username", view_pro.Username);
            S1.Add("Password", view_pro.Password);
            DataTable dt = new DataTable();
            dt = db_obj.Getdatatabel(S1, "getdata_View_Profile");
            if (dt.Rows.Count > 0)
            {
                view_pro.UID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                view_pro.UName = dt.Rows[0].ItemArray[1].ToString();

                view_pro.UAddress = dt.Rows[0].ItemArray[2].ToString();
                view_pro.UPhone = dt.Rows[0].ItemArray[3].ToString();
                view_pro.UPinCode = dt.Rows[0].ItemArray[4].ToString();
                view_pro.UEmail = dt.Rows[0].ItemArray[5].ToString();
                //view_pro.Password = dt.Rows[0].ItemArray[5].ToString();

            }
            //return db_obj.executeprocedure(S1, "getdata_View_Profile");
        }

        

        public string UserProfileUpdate()
        {

            S1.Clear();
            S1.Add("uid", view_pro.UID);
            S1.Add("UName", view_pro.UName);
            S1.Add("UAddress", view_pro.UAddress);
            S1.Add("UPhone", view_pro.UPhone);
            S1.Add("UPinCode", view_pro.UPinCode);
            S1.Add("UEmail", view_pro.UEmail);
            S1.Add("Username", view_pro.Username);
            S1.Add("Password", view_pro.Password);
            return db_obj.executeprocedure(S1, "UserProfile_updates");

        }
    }
}

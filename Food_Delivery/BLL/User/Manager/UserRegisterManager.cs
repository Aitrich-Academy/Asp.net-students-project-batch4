using BLL.User.Property;
using DLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.User.Manager
{
    public class UserRegisterManager
    {
        private DBhelper db_obj = new DBhelper();
        public UserRegisterProperty User_Pro = new UserRegisterProperty();
        private SortedList S1 = new SortedList();

        public string UserInsert()
        {
            S1.Clear();
            S1.Add("UName", User_Pro.UName);
            S1.Add("UAddress", User_Pro.UAddress);
            S1.Add("UPhone", User_Pro.UPhone);
            S1.Add("UPinCode", User_Pro.UPinCode);
            S1.Add("UEmail", User_Pro.UEmail);
            S1.Add("UserName", User_Pro.UserName);
            S1.Add("Password", User_Pro.Password);
            return db_obj.executeprocedure(S1, "User_insert");

        }
    }
}

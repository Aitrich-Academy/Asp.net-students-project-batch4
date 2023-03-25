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
   
    public class UserFeedbackManager
    {
        private DBhelper db_obj = new DBhelper();
        public UserFeedBackProperty feed_pro = new UserFeedBackProperty();
        private SortedList S1 = new SortedList();

        public string FeedbackInsert()
        {
            S1.Clear();
            S1.Add("UID", feed_pro.UID);
            S1.Add("Recomment", feed_pro.Recomment);
            S1.Add("Message", feed_pro.Message);
            return db_obj.executeprocedure(S1, "FeedBack_Insert");
        }
    }
}

using BLL.Admin.Property;
using DLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin.Manager
{
    public class ViewFeedbackManager
    {
        public DBhelper db_obj = new DBhelper();
        private ViewFeedbackProperty view_feed_pro = new ViewFeedbackProperty();
        public SortedList S1 = new SortedList();

        //public object SelectAllFeedbacks()
        //{
           
        //}
        public List<ViewFeedbackProperty> SelectAllFeedbacks()
        {
            DataTable dt = new DataTable();
            dt = db_obj.getdatatable("SelectFeedbacks");
            List<ViewFeedbackProperty> _list = new List<ViewFeedbackProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ViewFeedbackProperty
                {

                    FId = dr["FId"].ToString(),
                    Recomment = dr["Recomment"].ToString(),
                    Message = dr["Message"].ToString()



                }) ;
            }
            return _list;
        }
    }
}

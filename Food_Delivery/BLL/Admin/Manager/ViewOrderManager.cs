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
    public class ViewOrderManager
    {
        private DBhelper db_obj = new DBhelper();
        public ViewOrderProperty view_order_pro = new ViewOrderProperty();
        private SortedList S1 = new SortedList();

        public List<ViewOrderProperty> SelectAllOrders()
        {
            S1.Clear();
            S1.Add("UID", view_order_pro.UID);
            DataTable dt = new DataTable();
            dt = db_obj.Getdatatabel(S1,"SelectOrders");
            List<ViewOrderProperty> _list = new List<ViewOrderProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ViewOrderProperty
                {

                    ItmName = dr["ItmName"].ToString(),
                    Qty = Convert.ToInt32(dr["Qty"].ToString()),
                    Total = Convert.ToInt32(dr["Total"].ToString())



                });
            }
            return _list;
        }
       
        

    }
}

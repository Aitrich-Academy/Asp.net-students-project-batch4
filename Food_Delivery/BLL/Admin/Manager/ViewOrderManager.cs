using BLL.Admin.Property;
using DLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL.User.Property;

namespace BLL.Admin.Manager
{
    public class ViewOrderManager
    {
        private DBhelper db_obj = new DBhelper();
        public ViewOrderProperty view_order_pro = new ViewOrderProperty();
        private SortedList S1 = new SortedList();
        public BookingProperty obj_bookpro = new BookingProperty();
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

        public List<BookingProperty> SelectAllOrdersforAdmin()
        {

            DataTable dt = new DataTable();
            dt = db_obj.getdatatable("SelectAllBooking");
            List<BookingProperty> _list = new List<BookingProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new BookingProperty
                {

                    BookID = Convert.ToInt32(dr["BookID"]),
                    ItmID = Convert.ToInt32(dr["ItmID"]),
                    ItmName = dr["ItmName"].ToString(),
                    CatID = Convert.ToInt32(dr["CatID"]),
                    Email=dr["UEmail"].ToString(),
                    UID = Convert.ToInt32(dr["UID"]),
                    UName=dr["UName"].ToString(),
                    Qty = Convert.ToInt32(dr["Qty"]),
                    Total = Convert.ToDecimal(dr["Total"])




                });
            }
            return _list;
        }

        public string insertorder()
        {
            
                S1.Clear();

                S1.Add("ItmName", view_order_pro.ItmName);
                S1.Add("Qty", view_order_pro.Qty);
                S1.Add("Total", view_order_pro.Total);


            S1.Add("UID", view_order_pro.UID);
            return db_obj.executeprocedure(S1, "Orderofuserinsert");

           
        }
    }
}

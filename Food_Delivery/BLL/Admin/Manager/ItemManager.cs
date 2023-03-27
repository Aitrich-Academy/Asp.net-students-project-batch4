using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Admin.Property;
using DLL;
using System.Data;
using BLL.User.Property;

namespace BLL.Admin.Manager
{
    public class ItemManager
    {
        DBhelper obj_db = new DBhelper();
        public ItemProperty obj_proitem = new ItemProperty();
        public BookingProperty obj_bookpro = new BookingProperty();
        private SortedList S1 = new SortedList();

        public string itemInsert()
        {
            S1.Clear();
            S1.Add("ItmName", obj_proitem.ItmName);
            S1.Add("ItmPrice", obj_proitem.ItmPrice);
            S1.Add("CatID", obj_proitem.CatID);
            S1.Add("ItmImage", obj_proitem.ItmImage);
            S1.Add("ItmDiscription", obj_proitem.ItmDiscription);
            S1.Add("CookingTime", obj_proitem.CookingTime);
            return obj_db.executeprocedure(S1, "Item_insert");


        }

        public object CategoryWiseSelection()
        {
            DataTable dt = new DataTable();
            S1.Clear();
            S1.Add("CatID", obj_proitem.CatID);
            dt = obj_db.Getdatatabel(S1, "SelectCategoryById");
            List<ItemProperty> _list = new List<ItemProperty>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _list.Add(new ItemProperty
                    {
                        CatID = Convert.ToInt32(dr["CatID"]),
                        ItmID = Convert.ToInt32(dr["ItmID"]),
                        ItmName = dr["ItmName"].ToString(),
                        ItmDiscription = dr["ItmDiscription"].ToString(),
                        ItmPrice = Convert.ToDecimal(dr["ItmPrice"]),
                        ItmImage = dr["ItmImage"].ToString(),
                        CookingTime = Convert.ToInt32(dr["CookingTime"])

                    });
                }
            }
            return _list;
        }

        public string Book_Insert()
        {
            S1.Clear();
            S1.Add("ItmID", obj_bookpro.ItmID);
            S1.Add("CatID", obj_bookpro.CatID);
            S1.Add("UID", obj_bookpro.UID);
            S1.Add("Qty", obj_bookpro.Qty);
            S1.Add("Total", obj_bookpro.Total);
            return obj_db.executeprocedure(S1, "Order_insert");

        }

        public object SelectAllItems()
        {

            DataTable dt = new DataTable();
            dt = obj_db.getdatatable("selectallItems");
            List<ItemProperty> _list = new List<ItemProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ItemProperty
                {
                    ItmID = int.Parse(dr["ItmID"].ToString()),
                    ItmName = dr["ItmName"].ToString(),
                    ItmDiscription = dr["ItmDiscription"].ToString(),
                    ItmPrice = Convert.ToDecimal(dr["ItmPrice"]),
                    ItmImage = dr["ItmImage"].ToString(),
                    CookingTime = int.Parse(dr["CookingTime"].ToString())


                });



            }
            return _list;
        }



        public string getorderCategoryName()
        {
            S1.Clear();
            S1.Add("CatID", obj_bookpro.CatID);
            return obj_db.executeprocedure(S1, "getorderCategoryName");
        }

        public string getorderItemName()
        {
            S1.Clear();
            S1.Add("ItmID", obj_bookpro.ItmID);
            return obj_db.executeprocedure(S1, "getOrderItemName");
        }

        public string getorderUser()
        {
            S1.Clear();
            S1.Add("UID", obj_bookpro.UID);
            return obj_db.executeprocedure(S1, "getOrderUser");


        }

        public string GetEmailId()
        {
            S1.Clear();
            S1.Add("UID", obj_bookpro.UID);
            return obj_db.executeprocedure(S1, "Get_User_EmailId");
        }

        public List<CategoryProperty> SelectAllCategory()
        {

            DataTable dt = new DataTable();
            dt = obj_db.getdatatable("selectallCategory");
            List<CategoryProperty> _list = new List<CategoryProperty>();
            _list.Add(new CategoryProperty
            {
                CatName = "-- Select --",
                CatID = 0
            });

            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new CategoryProperty
                {

                    CatName = dr["CatName"].ToString(),
                    CatID = Convert.ToInt32(dr["CatID"])

                });
            }
            return _list;
        }
        public string Itemdelete()
        {
            S1.Clear();
            S1.Add("ItmID", obj_proitem.ItmID);
            return obj_db.executeprocedure(S1, "Item_delete");
        }
        public void SelectItemById()
        {
            DataTable dt = new DataTable();
            S1.Clear();
            S1.Add("ItmID", obj_proitem.ItmID);
            dt = obj_db.Getdatatabel(S1, "SelectItemByID");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    obj_proitem.ItmID = Convert.ToInt32(dr["ItmID"]);
                    obj_proitem.ItmName = dr["ItmName"].ToString();
                    obj_proitem.ItmPrice = Convert.ToDecimal(dr["ItmPrice"]);
                    obj_proitem.ItmDiscription = dr["ItmDiscription"].ToString();
                    obj_proitem.ItmImage = dr["ItmImage"].ToString();

                }
            }
        }

        public string ItemUpdate()
        {
            S1.Clear();
            S1.Add("ItmID", obj_proitem.ItmID);
            S1.Add("CatID", obj_proitem.CatID);
            S1.Add("ItmName", obj_proitem.ItmName);
            S1.Add("ItmImage", obj_proitem.ItmImage);
            S1.Add("ItmDiscription", obj_proitem.ItmDiscription);
            S1.Add("CookingTime", obj_proitem.CookingTime);
            S1.Add("ItmPrice", obj_proitem.ItmPrice);

            return obj_db.executeprocedure(S1, "Item_Update");
        }
    }
}

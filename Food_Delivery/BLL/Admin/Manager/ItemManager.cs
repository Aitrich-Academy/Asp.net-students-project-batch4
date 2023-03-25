using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Admin.Property;
using DLL;
using System.Data;

namespace BLL.Admin.Manager
{
    public class ItemManager
    {
        DBhelper obj_db = new DBhelper();
        public ItemProperty obj_proitem = new ItemProperty();
        private SortedList S1 = new SortedList();

        public string itemInsert()
        {
            S1.Clear();
            S1.Add("ItmName", obj_proitem.ItmName);
            S1.Add("ItmPrice", obj_proitem.ItmPrice);
            S1.Add("CatID", obj_proitem.CatName);
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
                        CatID = (dr["CatID"]).ToString(),
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
                    ItmImage = dr["ItmImage"].ToString()
                });



            }
            return _list;
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

    }
}

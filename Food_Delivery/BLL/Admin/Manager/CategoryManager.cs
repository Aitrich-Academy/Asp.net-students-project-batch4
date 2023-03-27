using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Admin.Property;
using System.Data;
using DLL;
using System.Collections;

namespace BLL.Admin.Manager
{
    public class CategoryManager
    {
        DBhelper obj_db = new DBhelper();
        public CategoryProperty obj_proitem = new CategoryProperty();
        private SortedList S1 = new SortedList();
        public List<CategoryProperty> SelectAllCategory()
        {

            DataTable dt = new DataTable();
            dt = obj_db.getdatatable("selectallCategory");
            List<CategoryProperty> _list = new List<CategoryProperty>();


            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new CategoryProperty
                {

                    CatName = dr["CatName"].ToString(),
                    CatID = Convert.ToInt32(dr["CatID"]),
                    CatImage = dr["Image"].ToString()



                });
            }
            return _list;

        }

        public string CategoryInsert()
        {

            S1.Clear();
            S1.Add("CatName", obj_proitem.CatName);
            S1.Add("CatImage", obj_proitem.CatImage);
            return obj_db.executeprocedure(S1, "Category_insert");



        }


        public string Categorydelete()
        {
            S1.Clear();
            S1.Add("CatID", obj_proitem.CatID);
            return obj_db.executeprocedure(S1, "Category_delete");
        }

        public void SelectByID()
        {
            S1.Clear();
            S1.Add("CatID", obj_proitem.CatID);
         
                DataTable dt = new DataTable();
              
                dt = obj_db.Getdatatabel(S1, "SelectCategory");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        obj_proitem.CatID= Convert.ToInt32(dr["CatID"]);
                    obj_proitem.CatName = dr["CatName"].ToString();
                    obj_proitem.CatImage = (dr["Image"]).ToString();
                       

                    }
                }
        }

        public string categoeyupdate()
        {
            S1.Clear();
            S1.Add("CatID", obj_proitem.CatID);
            S1.Add("CatName", obj_proitem.CatName);
            S1.Add("CatImage", obj_proitem.CatImage);
            

            return obj_db.executeprocedure(S1, "Category_Update");
        }
    }
}


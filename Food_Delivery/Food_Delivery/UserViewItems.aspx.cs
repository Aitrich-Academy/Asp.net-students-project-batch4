using BLL.Admin.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery
{
    public partial class UserViewItems : System.Web.UI.Page
    {
        ItemManager obj_ItemAddManager = new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {


                SelectByCategory();


            }
        }

        private void SelectByCategory()
        {
            int s2 = Convert.ToInt32(Session.Contents["CatID"]);
            obj_ItemAddManager.obj_proitem.CatID = s2;
            DataListItem.DataSource = obj_ItemAddManager.CategoryWiseSelection();
            DataListItem.DataBind();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            var ImageButton = sender as ImageButton;
            var DataListItem = ImageButton.Parent as DataListItem;
            var HiddenField = DataListItem.FindControl("Hf") as HiddenField;
            string s1 = HiddenField.Value;
            Session["ItmID"] = s1;
            Response.Redirect("SingleViewItem.aspx");
        }
    }
}
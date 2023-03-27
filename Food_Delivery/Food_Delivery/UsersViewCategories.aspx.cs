using BLL.Admin.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery
{
    public partial class UsersViewCategories : System.Web.UI.Page
    {
        CategoryManager obj_cat = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                selectAllCategory();
            }
        }

        private void selectAllCategory()
        {
            DataList1.DataSource = obj_cat.SelectAllCategory();
            DataList1.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            var ImageButton = sender as ImageButton;
            var DataListItem = ImageButton.Parent as DataListItem;
            var HiddenField = DataListItem.FindControl("hidd") as HiddenField;
            string s1 = HiddenField.Value;
            Session["CatID"] = s1;
            string s2 = Session.Contents["uid"].ToString();
            Session["uid"] = s2;
            Response.Redirect("UserViewItems.aspx");
        }
    }
}
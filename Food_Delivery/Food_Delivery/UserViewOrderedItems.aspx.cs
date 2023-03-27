using BLL.Admin.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery
{
    public partial class UserViewOrderedItems : System.Web.UI.Page
    {
        ViewOrderManager view_order_mngr = new ViewOrderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            view_order_mngr.view_order_pro.UID =int.Parse(Session.Contents["uid"].ToString());
            OrderBind();
           
        }
        public void OrderBind()
        {
            GridViewOrder.DataSource = view_order_mngr.SelectAllOrders();
            GridViewOrder.DataBind();
           
        }
    }
}
using BLL.Admin.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ViewOrderManager view_order_mngr = new ViewOrderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //OrderBind();
        }

        //private void OrderBind()
        //{
        //    GridView1.DataSource = view_order_mngr.ViewOrder();
        //    GridView1.DataBind();
        //}
    }
}
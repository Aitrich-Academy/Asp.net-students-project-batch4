using BLL.User.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery
{
    public partial class UserLogout : System.Web.UI.Page
    {
        UserLogoutProperty user_logout_pro = new UserLogoutProperty();
        protected void Page_Load(object sender, EventArgs e)
        {

            Session.Clear();
            Response.Redirect("UserLogin.aspx");
           
        }
       
    }
}
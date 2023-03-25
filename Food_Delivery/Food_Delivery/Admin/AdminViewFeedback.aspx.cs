using BLL.Admin.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ViewFeedbackManager view_feed_mngr = new ViewFeedbackManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            FeedBind();
        }
        public void FeedBind()
        {
            GridViewFeed.DataSource = view_feed_mngr.SelectAllFeedbacks();
            GridViewFeed.DataBind();
        }
    }
}
using BLL.User.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery
{
    public partial class Feedback : System.Web.UI.Page
    {
        UserFeedbackManager Feed_Mngr = new UserFeedbackManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Feedback_Insert()
        {
            Feed_Mngr.feed_pro.UID = Session.Contents["uid"].ToString();
            Feed_Mngr.feed_pro.Recomment = RadioButtonList1.SelectedValue;
            Feed_Mngr.feed_pro.Message = txtMessage.Text.Trim().ToString();


            string result = Feed_Mngr.FeedbackInsert();
            if (result == "Success")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Successfully Inserted";
                Clear();
            }
            else if (result == "Already Exists")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Already Exists";
            }
            else if (result == "Error")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Failed due to error";
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Failed due to some technical error";
            }

        }

        public void Clear()
        {
            RadioButtonList1.SelectedValue = "";
            txtMessage.Text = "";

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Feedback_Insert();
        }
    }
}
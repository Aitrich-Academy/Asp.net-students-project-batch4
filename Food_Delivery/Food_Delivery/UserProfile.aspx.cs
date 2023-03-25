using BLL.User.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery
{
    public partial class Home : System.Web.UI.Page
    {
        ViewProfileManager view_mngr = new ViewProfileManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Session["uid"] = 4;
                passdata();
            }
           
        }
      
        public void passdata()
        {
            //view_mngr.view_pro.UID =(int) Session["uid"];
            view_mngr.view_pro.Username = Session["Username"].ToString();
            view_mngr.view_pro.Password = Session.Contents["Password"].ToString();
            view_mngr.ViewProfiledata();
            Session["uid"] = view_mngr.view_pro.UID;
            txtName.Text = view_mngr.view_pro.UName;
            txtAddress.Text = view_mngr.view_pro.UAddress;
            txtPhone.Text = view_mngr.view_pro.UPhone;
            txtPincode.Text = view_mngr.view_pro.UPinCode;
            txtEmail.Text = view_mngr.view_pro.UEmail;
            lblUsername.Text = view_mngr.view_pro.Username;
            lblPassword.Text = view_mngr.view_pro.Password;
            //Session["uid"] = Hf.Value;
        }

      
        public void update_user()
        {
            view_mngr.view_pro.UID = (int)Session["uid"];
            view_mngr.view_pro.UName = txtName.Text.Trim().ToString();
            view_mngr.view_pro.UAddress = txtAddress.Text.Trim().ToString();
            view_mngr.view_pro.UPhone = txtPhone.Text.Trim().ToString();
            view_mngr.view_pro.UPinCode = txtPincode.Text.Trim().ToString();
            view_mngr.view_pro.UEmail = txtEmail.Text.Trim().ToString();
            //view_mngr.view_pro.Username = lblUsername.Text;
            //view_mngr.view_pro.Password = lblPassword.Text;
            string result = view_mngr.UserProfileUpdate();
            //TxtName.Text = "";
            //Hf.Value = "-1";


            if (result == "Success")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Successfully updated";

            }
            else if (result == "Error")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "failed due to some  error";
            }

           



        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            update_user();
        }
    }
}
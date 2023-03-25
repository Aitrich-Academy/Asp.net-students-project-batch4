using BLL.User.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Food_Delivery
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UserRegisterManager User_RegMngr_obj = new UserRegisterManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void User_Insert()
        {
            User_RegMngr_obj.User_Pro.UName = txtName.Text.Trim().ToString();
            User_RegMngr_obj.User_Pro.UAddress = txtAddress.Text.Trim().ToString();
            User_RegMngr_obj.User_Pro.UPhone = txtPhone.Text.Trim().ToString();
            User_RegMngr_obj.User_Pro.UPinCode = txtPincode.Text.Trim().ToString();
            User_RegMngr_obj.User_Pro.UEmail = txtEmail.Text.Trim().ToString();
            User_RegMngr_obj.User_Pro.UserName = txtUsername.Text.Trim().ToString();
            User_RegMngr_obj.User_Pro.Password = txtPassword.Text.Trim().ToString();
            string result = User_RegMngr_obj.UserInsert();
            if (result == "Success")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Successfully Inserted";
                Clear();
            }
            else if(result=="Already Exists")
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
                lblMsg.Text="Failed due to some technical error";
            }

        }

        public void Clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtPincode.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            User_Insert();
        }
    }
}
﻿using BLL.User.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Food_Delivery
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        UserLoginManager User_log_Mngr = new UserLoginManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void User_Login()
        {
            User_log_Mngr.user_log_Pro.Username = txtUsername.Text.Trim().ToString();
            User_log_Mngr.user_log_Pro.Password = txtPassword.Text.Trim().ToString();

            string result = User_log_Mngr.user_login();
                if(result=="Success")
            {



                //Session.Add("Username", txtUsername.Text);
                //Session.Add("Password", txtPassword.Text);
                Session["UID"] = User_log_Mngr.user_log_Pro.UID;
                Session["Username"] = txtUsername.Text;
                Session["Password"] = txtUsername.Text;
                getID();
                //Response.Redirect("~/Home.aspx");

                Response.Redirect("UsersViewCategories.aspx");
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Incorrect Username and Password";
            }
               



        }
        public void getID()
        {
            User_log_Mngr.user_log_Pro.Username = txtUsername.Text.Trim().ToString();
            User_log_Mngr.user_log_Pro.Password = txtPassword.Text.Trim().ToString();
            User_log_Mngr.GetUserID();
            Session["uid"] = User_log_Mngr.user_log_Pro.UID;
            //Session["uid"] = Convert.ToInt32(result.ToString());
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text == "admin")
            {
                Response.Redirect("Admin/AddCategory.aspx");
            }
            else
            {
                User_Login();

            }


        }
    }
}
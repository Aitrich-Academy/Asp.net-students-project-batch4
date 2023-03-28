using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin.Manager;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using MimeKit;
using MailKit.Security;

namespace Food_Delivery.Admin
{
    public partial class Viewordersforadmin : System.Web.UI.Page
    {
        ViewOrderManager obj_view = new ViewOrderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack==false)
            {
                selectallorders();
            }

        }
        public void selectallorders()
        {
         GridVieworder.DataSource= obj_view.SelectAllOrdersforAdmin();
            GridVieworder.DataBind();
        }
        public void sendEmail()
        {
            //Create instance of MailMessage Class
            MailMessage msg = new MailMessage();
            //Assign From mail address
            msg.From = new MailAddress("restuarantglobalgrill@gmail.com");
            msg.To.Add(new MailAddress(HiddenField1.Value));
            msg.Subject = "Request For Order Confirmation";

            msg.Body = "Order Confirmed";

           
            msg.IsBodyHtml = true;

            System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient();

            SmtpServer.Host = "smtp.gmail.com";

            SmtpServer.Port = 587;

            SmtpServer.Credentials = new System.Net.NetworkCredential("restuarantglobalgrill@gmail.com", "evmsmdwtrzwkscwk");

            SmtpServer.EnableSsl = true;

            SmtpServer.Send(msg);


        }


        protected void GridVieworder_SelectedIndexChanged(object sender, EventArgs e)
        {

           HiddenField1.Value = GridVieworder.SelectedRow.Cells[5].Text;
            sendEmail();
            obj_view.view_order_pro.ItmName= GridVieworder.SelectedRow.Cells[0].Text;
            obj_view.view_order_pro.Qty =Convert.ToInt32( GridVieworder.SelectedRow.Cells[1].Text);
            obj_view.view_order_pro.Total = Convert.ToDecimal(GridVieworder.SelectedRow.Cells[2].Text);
            obj_view.view_order_pro.UID = Convert.ToInt32(GridVieworder.SelectedRow.Cells[3].Text);

            obj_view.insertorder();

        }
    }
}
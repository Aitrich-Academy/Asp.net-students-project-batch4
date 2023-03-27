using BLL.Admin.Manager;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Food_Delivery
{
    public partial class SingleViewItem : System.Web.UI.Page
    {
        ItemManager obj_ItemAddManager = new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(Session.Contents["uid"]);
            //int catid= Convert.ToInt32(Session.Contents["CatID"]);
            string s2 = Session.Contents["ItmID"].ToString();
            obj_ItemAddManager.obj_proitem.ItmID = Convert.ToInt32(s2);
            selectitem();
            

        }
        public void selectitem()
        {
            obj_ItemAddManager.SelectItemById();
            LabelItemName.Text = obj_ItemAddManager.obj_proitem.ItmName;
            LabelDiscription.Text = obj_ItemAddManager.obj_proitem.ItmDiscription;
            ItmPrice.Text = obj_ItemAddManager.obj_proitem.ItmPrice.ToString();
            Image1.ImageUrl = obj_ItemAddManager.obj_proitem.ItmImage;

        }
        protected void Buttonorder_Click(object sender, EventArgs e)
        {
            bookorder();
            SendMail();
        }

        public void bookorder()
        {
            int id = Convert.ToInt32(Session.Contents["uid"]);
            obj_ItemAddManager.obj_bookpro.UID = id;
            int catid = Convert.ToInt32(Session.Contents["CatID"]);
            obj_ItemAddManager.obj_bookpro.CatID = catid;
            int s2 = Convert.ToInt32(Session.Contents["ItmID"]);
            obj_ItemAddManager.obj_bookpro.ItmID = s2;
            obj_ItemAddManager.obj_bookpro.Qty=int.Parse(Label1.Text);
            int price = Convert.ToInt32(ItmPrice.Text);
            int qty = obj_ItemAddManager.obj_bookpro.Qty;
            obj_ItemAddManager.obj_bookpro.Total = qty * price;
            string result=obj_ItemAddManager.Book_Insert();
            if (result == "Success")
            {
                Label2.Visible = true;
                Label2.Text = "Inserted Successfully";

            }
            else if (result == "Already Exist")
            {
                Label2.Visible = true;
                Label2.Text = "alreaddy Exist";

            }
            else 
            { 
                Label2.Visible = true;
                Label2.Text = "failed due to error";

            }
           

        }

        
        public void SendMail()
        {

            //Create instance of MailMessage Class
            MailMessage msg = new MailMessage();
            //Assign From mail address
            msg.From = new MailAddress(obj_ItemAddManager.GetEmailId());
            msg.To.Add(new MailAddress("restuarantglobalgrill@gmail.com"));
            msg.Subject = "Request For Order Confirmation";

            msg.Body = obj_ItemAddManager.getorderUser(); 

            msg.Body += obj_ItemAddManager.getorderItemName();
            msg.Body += obj_ItemAddManager.getorderCategoryName();
            msg.Body += obj_ItemAddManager.obj_bookpro.Qty;
            msg.IsBodyHtml = true;

            System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient();

            SmtpServer.Host = "smtp.gmail.com";

            SmtpServer.Port = 587;

            SmtpServer.Credentials = new System.Net.NetworkCredential("restuarantglobalgrill@gmail.com", "evmsmdwtrzwkscwk");

            SmtpServer.EnableSsl = true;

            SmtpServer.Send(msg);
        }

        protected void ButtonDec_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Label1.Text) > 0)
            {
                Label1.Text = (Convert.ToInt32(Label1.Text) - 1).ToString();
            }
        }

        protected void ButtonInc_Click1(object sender, EventArgs e)
        {
            Label1.Text = (Convert.ToInt32(Label1.Text) + 1).ToString();
        }
    }
}
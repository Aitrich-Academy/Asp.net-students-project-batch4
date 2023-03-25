using BLL.Admin.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
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
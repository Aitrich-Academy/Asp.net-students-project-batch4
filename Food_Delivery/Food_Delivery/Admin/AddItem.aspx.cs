using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin.Manager;

namespace Food_Delivery.Admin
{
    public partial class AddItem : System.Web.UI.Page
    {
        ItemManager obj_ItemAddManager = new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                selectAllCategory();
                selectAllItems();
            }

        }
        public void selectAllItems()
        {
                   
            DataList1.DataSource = obj_ItemAddManager.SelectAllItems();
            DataList1.DataBind();

        }
        public void selectAllCategory()
        {
            DropDownListCatName.DataSource = obj_ItemAddManager.SelectAllCategory();
            DropDownListCatName.DataTextField = "CatName";
            DropDownListCatName.DataValueField = "CatId";
            DropDownListCatName.DataBind();
        }

        private string GetRandomText()
        {
            string randomText = "";
            string alphabets = "0123456789";

            Random r = new Random();
            for (int j = 0; j <= 3; j++)
            {
                randomText += alphabets[r.Next(alphabets.Length)];
            }
            return randomText.ToString();
        }
        public void insertItem()
        {
            if (FileUploadItmImage.HasFile)
            {
                string fileName = GetRandomText();
                string path = Server.MapPath("~/Images/");
                FileUploadItmImage.SaveAs(path + fileName + ".jpg");
                obj_ItemAddManager.obj_proitem.ItmName = TextItemName.Text.Trim().ToString();
                obj_ItemAddManager.obj_proitem.ItmPrice = Convert.ToDecimal(TextItmPrice.Text);
                obj_ItemAddManager.obj_proitem.ItmImage = ("/Images/" + fileName + ".jpg");
                obj_ItemAddManager.obj_proitem.ItmDiscription = TextItemDiscription.Text.Trim().ToString();
               obj_ItemAddManager.obj_proitem.CookingTime =Convert.ToInt32(TextCookTime.Text);
                obj_ItemAddManager.obj_proitem.CatID = DropDownListCatName.SelectedIndex;
                string result = obj_ItemAddManager.itemInsert();
                HiddenFieldItem.Value = "-1";
                Clear();
                if (result == "Success")
                {
                    LabelMsg.Visible = true;
                    LabelMsg.Text = "Inserted Successfully";

                }
                else if (result == "Already Exist")
                {
                    LabelMsg.Visible = true;
                    LabelMsg.Text = "alreaddy Exist";

                }
                else if (result == "Error")
                {
                    LabelMsg.Visible = true;
                    LabelMsg.Text = "failed due to error";

                }
                else
                {
                    LabelMsg.Visible = true;
                    LabelMsg.Text = "failed due to some technical error";
                }
                
            }
            selectAllItems();

        }
        public void Clear()
        {
            TextItemName.Text = "";
            TextItmPrice.Text = "";
            TextItmPrice.Text = "";
            TextCookTime.Text = "";
            TextItemDiscription.Text = "";

        }

        protected void ButtonAddItem_Click(object sender, EventArgs e)
        {
            insertItem();
        }

     


        protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int Id;
            try
            {
                HiddenFieldItem.Value= (DataList1.DataKeys[e.Item.ItemIndex]).ToString();
                deleteitem();

            }
            catch(Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('error' +" + ex.Message.ToString() + "')",true);
            }


        }
        public void deleteitem()
        {
            obj_ItemAddManager.obj_proitem.ItmID = int.Parse(HiddenFieldItem.Value);
            string result = obj_ItemAddManager.Itemdelete();
            TextItemName.Text = "";
            HiddenFieldItem.Value = "-1";
            if (result == "Success")
            {
              
                //Lblimageshow.Visible = false;
                LabelMsg.Visible = true;
                LabelMsg.Text = "Successfully Deleted";

            }
            else if (result == "Error")
            {
                LabelMsg.Visible = true;
                LabelMsg.Text = "failed due to some  error";
            }

            else if (result == "Already exist")
            {
                LabelMsg.Visible = true;
                LabelMsg.Text = "Already Exist";
            }
            else
            {
                LabelMsg.Visible = true;
                LabelMsg.Text = "failed due to some technical error";
            }
            selectAllItems();
        }

    

        protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
        {
            HiddenFieldItem.Value = (DataList1.DataKeys[e.Item.ItemIndex]).ToString();
            obj_ItemAddManager.obj_proitem.ItmID =Convert.ToInt32( HiddenFieldItem.Value);
            obj_ItemAddManager.SelectItemById();
            TextItemName.Text=obj_ItemAddManager.obj_proitem.ItmName;
            TextItmPrice.Text = obj_ItemAddManager.obj_proitem.ItmPrice.ToString();
            TextItemDiscription.Text = obj_ItemAddManager.obj_proitem.ItmDiscription.ToString();
            DropDownListCatName.SelectedIndex = obj_ItemAddManager.obj_proitem.CatID;
            // FileUploadItmImage.PostedFile.SaveAs(Server.MapPath("~/images/" + obj_ItemAddManager.obj_proitem.ItmImage));
            TextCookTime.Text = obj_ItemAddManager.obj_proitem.CookingTime.ToString();
            ButtonAddItem.Visible = false;
            ButtonUpdate.Visible = true;
            ButtonCancel.Visible = true;




        }

        protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
        {

        }

        protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
        {

        }

        protected void LinkEdit_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ItemUpdate();
            selectAllItems();
        }
        public void ItemUpdate()
        {
            string filename = GetRandomText();
            string path = Server.MapPath("~/Images/");
            FileUploadItmImage.SaveAs(path + filename + ".jpg");
            obj_ItemAddManager.obj_proitem.ItmImage= ("~/Images/" + filename + ".jpg");
            obj_ItemAddManager.obj_proitem.ItmName = TextItemName.Text;
            obj_ItemAddManager.obj_proitem.ItmDiscription = TextItemDiscription.Text;
            obj_ItemAddManager.obj_proitem.ItmPrice = Convert.ToInt32(TextItmPrice.Text);
            obj_ItemAddManager.obj_proitem.CookingTime = Convert.ToInt32(TextCookTime.Text);
            obj_ItemAddManager.obj_proitem.CatID = DropDownListCatName.SelectedIndex;
            obj_ItemAddManager.obj_proitem.ItmID = Convert.ToInt32(HiddenFieldItem.Value);
            string result = obj_ItemAddManager.ItemUpdate();
            Clear();
            ButtonUpdate.Visible = false;
            ButtonAddItem.Visible = true;
            ButtonCancel.Visible = false;
            if (result == "Success")
            {
                LabelMsg.Visible = true;
                LabelMsg.Text = "Successfully updated";
                //Lblimageshow.Visible = false;
               
            }
            else if (result == "Error")
            {
               LabelMsg.Visible = true;
                LabelMsg.Text = "failed due to some  error";
            }




        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Clear();
            ButtonUpdate.Visible = false;
            ButtonAddItem.Visible = true;
            ButtonCancel.Visible = false;
        }
    }
}


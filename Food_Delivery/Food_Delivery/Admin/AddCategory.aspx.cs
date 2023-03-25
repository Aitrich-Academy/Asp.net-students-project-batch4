using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin.Manager;

namespace Food_Delivery.Admin
{
    public partial class AddCategory : System.Web.UI.Page
    {
        CategoryManager obj_cat = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                selectAllCategory();

            }
        }
        public void selectAllCategory()
        {
            DataListCategory.DataSource = obj_cat.SelectAllCategory();
            DataListCategory.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            insertItem();
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
            if (FileUploadCategory.HasFile)
            {
                string fileName = GetRandomText();
                string path = Server.MapPath("~/Images/");
                FileUploadCategory.SaveAs(path + fileName + ".jpg");
                obj_cat.obj_proitem.CatName = TextBoxCatName.Text.Trim().ToString();

                obj_cat.obj_proitem.CatImage = ("/Images/" + fileName + ".jpg");
                string result = obj_cat.CategoryInsert();
                HiddenFieldCategory.Value = "-1";
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
            selectAllCategory();

        }
        public void Clear()
        {
            TextBoxCatName.Text = "";



        }

        protected void DataListCategory_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            try
            {
                HiddenFieldCategory.Value = (DataListCategory.DataKeys[e.Item.ItemIndex]).ToString();
                deleteitem();

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('error' +" + ex.Message.ToString() + "')", true);
            }
        }
        public void deleteitem()
        {
            obj_cat.obj_proitem.CatID = int.Parse(HiddenFieldCategory.Value);
            string result = obj_cat.Categorydelete();
            TextBoxCatName.Text = "";
            HiddenFieldCategory.Value = "-1";
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
            selectAllCategory();
        }
    }               
}
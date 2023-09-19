using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using businesslayer;

namespace project.admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Display_Desigantion();
            }
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            User_business obj = new User_business(txt_first_name.Text, txt_last_name.Text, txt_email_address.Text, txt_password.Text, Convert.ToInt32(txt_mobile.Text), Convert.ToDateTime(txt_DOB.Text),txt_address.Text, Convert.ToInt32(drp_designation.SelectedValue), 1);
            obj.Insert_User();
            Clear();
        }

        private void Clear()
        {
            txt_first_name.Text = "";
            txt_last_name.Text = "";
            txt_email_address.Text = "";
            txt_password.Text = "";
            txt_mobile.Text = "";
            drp_designation.SelectedIndex = 0;
            txt_DOB.Text = "";
            txt_address.Text = "";
        }

        protected void btn_refersh_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Display_Desigantion()
        {
            User_business obj=new User_business();
            drp_designation.DataSource = obj.Display_User_Designation();
            drp_designation.DataTextField = "DesignationType";
            drp_designation.DataValueField="DesignationId";
            drp_designation.DataBind();
        }

        protected void btn_View_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewuserdetail.aspx");
        }
    }
}

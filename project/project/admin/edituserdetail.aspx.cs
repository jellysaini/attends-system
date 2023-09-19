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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Display_data();
            }
        }

        public void Display_data()
        {
            User_business obj = new User_business();
            DataTable dt = new DataTable();
            dt = obj.Find_User_Detail(Convert.ToInt32(Request.QueryString["val"].ToString()));
            txt_first_name.Text = dt.Rows[0]["UserFirstName"].ToString();
            txt_last_name.Text = dt.Rows[0]["UserLastName"].ToString();
            txt_email_address.Text = dt.Rows[0]["UserEmailAddress"].ToString();
            txt_mobile.Text = dt.Rows[0]["UserMobile"].ToString();
            txt_DOB.Text = dt.Rows[0]["UserDOB"].ToString();
            drp_designation.DataSource = obj.Display_User_Designation();
            drp_designation.DataTextField = "DesignationType";
            drp_designation.DataValueField = "DesignationId";
            drp_designation.SelectedIndex = 1;
            drp_designation.DataBind();
            txt_address.Text = dt.Rows[0]["UserAddress"].ToString();

        }

        protected void btn_refersh_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewuserdetail.aspx");
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            User_business obj = new User_business(Convert.ToInt32(Request.QueryString["val"].ToString()), txt_first_name.Text, txt_last_name.Text, txt_email_address.Text,Convert.ToInt32(txt_mobile.Text),Convert.ToDateTime(txt_DOB.Text), Convert.ToInt32(drp_designation.SelectedValue), txt_address.Text);
            obj.Update_User_Detail();
            Response.Redirect("viewuserdetail.aspx");

        }
    }
}

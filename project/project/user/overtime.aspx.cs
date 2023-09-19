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

namespace project.user
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Display_UserName();
            }
        }
        public void Display_UserName()
        {
            User_business obj = new User_business();
            drp_user_name.DataSource = obj.Display_User_Name();
            drp_user_name.DataTextField = "UserFirstName";
            drp_user_name.DataValueField = "UserId";
            drp_user_name.DataBind();
        }

        protected void drp_user_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            User_business obj = new User_business();
            DataTable dt = new DataTable();
            dt=obj.Find_User_Detail(Convert.ToInt32(drp_user_name.SelectedValue));
            txt_email.Text = dt.Rows[0]["UserEmailAddress"].ToString();

        }
    }
}

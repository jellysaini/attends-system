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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_change_password_Click(object sender, EventArgs e)
        {

            User_business obj = new User_business(txt_old_password.Text, txt_new_password.Text, Convert.ToInt32(Session["UserId"].ToString()));
            Int32 ret = obj.Change_UserPassword();
            if (ret == 1)
            {
                lblerr.Text = "Password Change Successfully";

            }
            else if (ret == -1)
            {
                lblerr.Text = "Your Old Password is Incorrect";
            }
            txt_old_password.Text = "";
            txt_new_password.Text = "";
            txt_confirm_password.Text = "";
        }
    }
}

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using businesslayer;

namespace project
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Int32 a;
            Int32 UserDesignation;
            String UserName;
            User_business obj=new User_business(txt_user_name.Text,txt_password.Text);
            a = obj.User_Login(out UserDesignation,out UserName);
            if (a == -1)
            {
                lbl_err.Text = "UserName/Password Incorrect";
            }
            else
            {
                Session["UserName"] = UserName;
                Session["UserId"] = a;
                Session["Des"] = UserDesignation;
                if (UserDesignation == 1)
                {
                    Response.Redirect("admin/userregister.aspx");
                }
                else
                {
                    DateTime dt =new DateTime();
                    dt = DateTime.Now;
                    User_Attends_business obj1 = new User_Attends_business(a,dt,'P',1);
                    Session["LoginDateTime"] = dt;
                    obj1.Insert_User_Allends();
                    Response.Redirect("user/changepassword.aspx");
                }
            }


        }

        protected void lnk_forget_password_Click(object sender, EventArgs e)
        {
            Response.Redirect("forgetpassword.aspx");
        }
    }
}

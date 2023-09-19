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

namespace project.user
{
    public partial class user : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnk_logout_Click(object sender, EventArgs e)
        {
            DateTime LogoutTime = new DateTime();
            DateTime LoginTime = new DateTime();
            LogoutTime = DateTime.Now;
            User_Attends_business ob = new User_Attends_business();
            LoginTime=ob.Get_LoginDate(Convert.ToInt32(Session["UserId"].ToString()));
            TimeSpan Ts = LogoutTime - LoginTime;
            int hh = Ts.Hours;
            int mm = Ts.Minutes;
            int ss = Ts.Seconds;
            String TimeDiff = hh.ToString("00")+":" +mm.ToString("00")+":" +ss.ToString("00");
            User_Attends_business obj = new User_Attends_business(Convert.ToInt32(Session["UserId"].ToString()), LoginTime, LogoutTime, TimeDiff);
            obj.Update_User_Attends();
            Session.Abandon();
            Session.Clear();
            Response.Redirect("../login.aspx");
        }
    }
}


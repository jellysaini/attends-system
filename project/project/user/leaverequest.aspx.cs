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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_refersh_Click(object sender, EventArgs e)
        {
            txt_leave_form.Text = "";
            txt_leave_to.Text = "";
            txt_reason.Text = "";
            
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            DateTime LeaveFrom = new DateTime();
            DateTime LeaveTo = new DateTime();
            LeaveFrom = Convert.ToDateTime(txt_leave_form.Text);
            if (LeaveFrom < DateTime.Now)
            {
                lbl.Text = "LeaveFrom must be greater then the current Date";
                return;
            }
            LeaveTo = Convert.ToDateTime(txt_leave_to.Text);
            if (LeaveTo < DateTime.Now)
            {
                lbl.Text = "LeaveTo must be greater then the current Date";
                return;
            }
            TimeSpan dif = LeaveTo.Subtract(LeaveFrom);
            String NoOfDay = "";
            if (dif.Days < 0)
            {
                lbl.Text = "LeaveTo must be Greater then LeaveFrom";
                return;
            }
            else if (dif.Days <= 0)
            {
                NoOfDay = Convert.ToString(0.5);
            }
            else
            {
                NoOfDay = Convert.ToString(dif.Days);
            }
            Leave_business obj = new Leave_business(Convert.ToString(Session["UserName"].ToString()), Convert.ToInt32(Session["UserId"].ToString()), Convert.ToInt32(Session["Des"].ToString()), Convert.ToDateTime(txt_leave_form.Text), Convert.ToDateTime(txt_leave_to.Text), NoOfDay, txt_reason.Text, 0, DateTime.Now);
            obj.Insert_Apply_Leave();

        }

        protected void btn_View_Click(object sender, EventArgs e)
        {
            Response.Redirect("leaveresponse.aspx");
        }

        
    }
}

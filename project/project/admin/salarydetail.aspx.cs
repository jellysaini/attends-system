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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Display_User();
            }
        }
        private void Display_User()
        {
            User_business obj = new User_business();
            drp_user.DataSource = obj.Display_All_User_Name();
            drp_user.DataTextField = "UserFirstname";
            drp_user.DataValueField = "UserId";
            drp_user.DataBind();
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            Salary_Detail_business obj = new Salary_Detail_business(Convert.ToInt32(drp_user.SelectedValue), Convert.ToInt32(txt_basic.Text), Convert.ToInt32(txt_HRA.Text), Convert.ToInt32(txt_TA.Text), Convert.ToInt32(txt_DA.Text), Convert.ToInt32(txt_daily_rate.Text), Convert.ToInt32(txt_daily_overtime.Text), Convert.ToInt32(txt_reduction_rate.Text), Convert.ToInt32(txt_total_salary.Text));
            obj.Insert_Salary_Detail();
            Display_User();
            Clear_Salary();

        }

        private void Clear_Salary()
        {
            drp_user.SelectedIndex = 0;
            txt_basic.Text = "";
            txt_HRA.Text = "";
            txt_TA.Text = "";
            txt_DA.Text = "";
            txt_daily_rate.Text = "";
            txt_daily_overtime.Text = "";
            txt_reduction_rate.Text = "";
            txt_total_salary.Text = "";
        }

        protected void btn_refersh_Click(object sender, EventArgs e)
        {
            Clear_Salary();
        }

        protected void btn_View_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewsalarydetail.aspx");
        }
    }
}

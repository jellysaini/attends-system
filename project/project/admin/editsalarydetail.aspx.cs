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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DisplayData();
            }
        }
        public void DisplayData()
        {
            Salary_Detail_business obj = new Salary_Detail_business();
            DataTable dt = new DataTable();
            dt=obj.Find_Salary_Detail(Convert.ToInt32(Request.QueryString["val"].ToString()));
            txt_user_name.Text = dt.Rows[0]["UserFirstName"].ToString();
            txt_basic.Text = dt.Rows[0]["Basic"].ToString();
            txt_HRA.Text = dt.Rows[0]["HRA"].ToString();
            txt_TA.Text = dt.Rows[0]["TA"].ToString();
            txt_DA.Text = dt.Rows[0]["DA"].ToString();
            txt_daily_rate.Text = dt.Rows[0]["DailyRate"].ToString();
            txt_daily_overtime.Text = dt.Rows[0]["DailyOvertimeRate"].ToString();
            txt_reduction_rate.Text = dt.Rows[0]["DailyReductionRate"].ToString();
            txt_total_salary.Text = dt.Rows[0]["TotalSalary"].ToString();

        }

        protected void btn_refersh_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewsalarydetail.aspx");
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            Salary_Detail_business obj=new Salary_Detail_business(Convert.ToInt32(Request.QueryString["val"].ToString()),Convert.ToInt32(txt_basic.Text),Convert.ToInt32(txt_HRA.Text),Convert.ToInt32(txt_TA.Text),Convert.ToInt32(txt_DA.Text),Convert.ToInt32(txt_daily_rate.Text),Convert.ToInt32(txt_daily_overtime.Text),Convert.ToInt32(txt_reduction_rate.Text),Convert.ToInt32(txt_total_salary.Text));
            obj.Update_Salary_Detail();
            
            Response.Redirect("viewsalarydetail.aspx");
        }
    }
}

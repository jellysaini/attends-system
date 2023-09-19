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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Grid_Bind();
                
            }
        }
        public void Grid_Bind()
        {
            Salary_Detail_business obj = new Salary_Detail_business();
            GridView1.DataSource = obj.Display_salary_Detail();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
           String a = (GridView1.DataKeys[e.NewEditIndex].Value.ToString());
           Response.Redirect("editsalarydetail.aspx?val=" + a);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String a = (GridView1.DataKeys[e.RowIndex].Value.ToString());
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Grid_Bind();
        }
 
    }
}

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
    public partial class WebForm3 : System.Web.UI.Page
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
            Leave_business obj = new Leave_business();
            GridView1.DataSource=obj.Check_Leave_Respones(Convert.ToInt32(Session["UserId"].ToString()));
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Leave_business obj = new Leave_business();
            Int32  a =Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            obj.Delete_Leave_Request(a);
            Grid_Bind();

        }
    }
}

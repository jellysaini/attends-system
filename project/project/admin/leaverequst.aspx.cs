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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Leave_Request();
            }
           
        }
        public void Leave_Request()
        {
            Leave_business obj=new Leave_business();
            GridView1.DataSource = obj.Check_Leave_Request();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 a =Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex].Value.ToString());
            Leave_business obj = new Leave_business();
            obj.Confirm_Leave(a);
            Leave_Request();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Int32 a =Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            Leave_business obj = new Leave_business();
            obj.Cancel_Leave(a);
            Leave_Request();
        }
    }
}

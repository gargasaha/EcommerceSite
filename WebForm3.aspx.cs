using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("mdiv");
            div.Visible = false;
            admin_name.Text = Session["admin_email"].ToString();
        }
        protected void products(object sender,EventArgs e)
        {
            Response.Redirect("WebForm8.aspx");
        }
        protected void addproducts(object sender, EventArgs e) {
            Response.Redirect("WebForm11.aspx");
        }
        protected void add_dynamic_image(object sender, EventArgs e) {
            Response.Redirect("WebForm19.aspx");
        }

    }
}
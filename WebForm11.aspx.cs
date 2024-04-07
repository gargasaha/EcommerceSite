using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("mdiv");
            div.Visible = false;
            System.Web.UI.HtmlControls.HtmlGenericControl div2=(System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("dynamic");
            div2.Visible = false;
        }
        protected void add_item(object sender, System.EventArgs e) {
            Button b1 = (Button)sender;
            if (b1.ID == "bmc")
            {
                Response.Redirect("WebForm12.aspx");
            }
            else if (b1.ID == "btae") {
                Response.Redirect("WebForm13.aspx");
            }

            else if (b1.ID == "bmf")
            {
                Response.Redirect("WebForm14.aspx");
            }

            else if (b1.ID == "bwf")
            {
                Response.Redirect("WebForm15.aspx");
            }

            else if (b1.ID == "bbhg")
            {
                Response.Redirect("WebForm16.aspx");
            }

            else if (b1.ID == "bb")
            {
                Response.Redirect("WebForm17.aspx");
            }
        }
    }
}
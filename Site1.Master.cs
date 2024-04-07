using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Label label = (Label)FindControl("name_div");
                label.Text = "Howdy";
                label.Text = label.Text+" "+Session["email"].ToString();
                HtmlAnchor htmlAnchor = (HtmlAnchor)FindControl("dis1");
                htmlAnchor.Visible = false;
                HtmlAnchor htmlAnchor2 = (HtmlAnchor)FindControl("dis2");
                htmlAnchor2.Visible = false;
                number.InnerText="("+ assign_number()+")";

            }
            else { 
                Button button=(Button)FindControl("out");
                button.Visible = false;
                Label label = (Label)FindControl("name_div");
                label.Visible = false;
                number.InnerText = "";

            }
        }
        protected int assign_number() {
            string email = Session["email"].ToString();
            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select count(*) from add_to_cart where email = '"+email+"'",sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            int n = 0;
            while (reader.Read()) {
                n = Convert.ToInt32(reader[0]);
            }
            return n;
           
        }
        protected void logout(object sender, EventArgs e) {
            Button button =(Button)FindControl("out");
            button.Visible= false;  
            Session["email"] = null;
            Session["c_id"]= null;
            Session["p_id"] = null;
            HtmlAnchor htmlAnchor = (HtmlAnchor)FindControl("dis1");
            htmlAnchor.Visible = true;
            HtmlAnchor htmlAnchor2 = (HtmlAnchor)FindControl("dis2");
            htmlAnchor2.Visible = true;
            Label label = (Label)FindControl("name_div");
            label.Visible = false;
            Response.Redirect("WebForm1.aspx");
        }
       

        protected void Unnamed_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["email"]==null)
            {
                Response.Write("<script>alert('Not logged in')</script>");
            }
            else
            {
                Response.Redirect("WebForm7.aspx");
            }
        }
        
        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            if (b1.ID == "mc"){
                Session["c_id"] = "1";
                Response.Redirect("WebForm5.aspx");
            }
            else if (b1.ID == "tae"){
                Session["c_id"] = "2";
                Response.Redirect("WebForm5.aspx");
            }
            else if (b1.ID == "fd")
            {
                Session["c_id"] = "4";
                Response.Redirect("WebForm5.aspx");
            }
        }
        protected void get_key_word(object sender, EventArgs e) {
            Session["key"]=search_item.Text.ToString();
            Session["c_id"] = "0";
            Response.Redirect("WebForm18.aspx");
        }
    }
}
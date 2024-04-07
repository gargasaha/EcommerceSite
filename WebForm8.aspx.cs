using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        public Byte[] bytes = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            getdata();
        }

        protected void getdata()
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("mdiv");
            div.Visible = false;
            SqlConnection conn = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            conn.Open();
            SqlDataReader reader;   
            SqlCommand sqlCommand = new SqlCommand("select a.pr_id,a.pr_name,a.image_data,b.stock,b.c_id from mobile_and_computer as a,stock_table as b where b.c_id=1 and a.pr_id=b.pr_id;", conn);
            reader = sqlCommand.ExecuteReader();
            gv1.DataSource = reader;
            gv1.DataBind();
            reader.Close();
            
            
            SqlCommand sqlCommand2 = new SqlCommand("select a.pr_id,a.pr_name,a.image_data,b.stock,b.c_id from tv_appliances_electronics as a,stock_table as b where b.c_id=2 and a.pr_id=b.pr_id;", conn);
            reader = sqlCommand2.ExecuteReader();
            gv2.DataSource = reader;
            gv2.DataBind();
            reader.Close ();

            sqlCommand = new SqlCommand("select a.pr_id,a.pr_name,a.image_data,b.stock,b.c_id from mens_fashion as a,stock_table as b where b.c_id=3 and a.pr_id=b.pr_id;", conn);
            reader = sqlCommand.ExecuteReader();
            gv3.DataSource = reader;
            gv3.DataBind();
            reader.Close();

            sqlCommand = new SqlCommand("select a.pr_id,a.pr_name,a.image_data,b.stock,b.c_id from womens_fashion as a,stock_table as b where b.c_id=4 and a.pr_id=b.pr_id;", conn);
            reader = sqlCommand.ExecuteReader();
            gv4.DataSource = reader;
            gv4.DataBind();
            reader.Close();

            sqlCommand = new SqlCommand("select a.pr_id,a.pr_name,a.image_data,b.stock,b.c_id from beauty_health_grocery as a,stock_table as b where b.c_id=5 and a.pr_id=b.pr_id;", conn);
            reader = sqlCommand.ExecuteReader();
            gv5.DataSource = reader;
            gv5.DataBind();
            reader.Close();

            sqlCommand = new SqlCommand("select a.pr_id,a.pr_name,a.image_data,b.stock,b.c_id from book as a,stock_table as b where b.c_id=6 and a.pr_id=b.pr_id;", conn);
            reader = sqlCommand.ExecuteReader();
            gv6.DataSource = reader;
            gv6.DataBind();
            reader.Close();


        }

        protected void update_click1(object sender, ImageClickEventArgs e)
        {
            
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            Response.Redirect("WebForm9.aspx");
        }
        protected void update_click2(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            Response.Redirect("WebForm9.aspx");
        }
        protected void update_click3(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            Response.Redirect("WebForm9.aspx");
        }
        protected void update_click4(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            Response.Redirect("WebForm9.aspx");
        }
        protected void update_click5(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            Response.Redirect("WebForm9.aspx");
        }
        protected void update_click6(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            Response.Redirect("WebForm9.aspx");
        }
        protected void delete_click1(object sender, EventArgs e) {
            //Response.Write("<script>confirm('ARE YOU SURE TO DELETE THE ITEM')</script>");
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            int id = Convert.ToInt32(Session["pr_id"]);
            SqlConnection conn = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("delete_1",conn);
            sqlCommand.CommandType=System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("WebForm8.aspx");

        }
        protected void delete_click2(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            int id = Convert.ToInt32(Session["pr_id"]);
            SqlConnection conn = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("delete_2", conn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("WebForm8.aspx");

        }
        protected void delete_click3(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            int id = Convert.ToInt32(Session["pr_id"]);
            SqlConnection conn = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("delete_3", conn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("WebForm8.aspx");

        }
        protected void delete_click4(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            int id = Convert.ToInt32(Session["pr_id"]);
            SqlConnection conn = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("delete_4", conn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("WebForm8.aspx");

        }
        protected void delete_click5(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            int id = Convert.ToInt32(Session["pr_id"]);
            SqlConnection conn = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("delete_5", conn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("WebForm8.aspx");

        }
        protected void delete_click6(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Session["pr_id"] = btn.CssClass;
            Session["c_id"] = btn.AlternateText;
            int id = Convert.ToInt32(Session["pr_id"]);
            SqlConnection conn = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("delete6", conn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("WebForm8.aspx");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("mdiv");
            div.Visible = false;
            string str_c_id = Session["c_id"].ToString();
            string str_pr_id = Session["pr_id"].ToString();
            StringBuilder stringBuilder = new StringBuilder();

            if (str_c_id.Equals("1"))
            {
                stringBuilder.Append("select [os],[seller],[brand],[pr_name],[image_data],[desp],[pr_price] from mobile_and_computer where pr_id=" + str_pr_id);

            }
            else if (str_c_id.Equals("2"))
            {
                stringBuilder.Append("select [brand],[pr_name],[image_data],[desp],[pr_price] from tv_appliances_electronics where pr_id=" + str_pr_id);
            }
            else if (str_c_id.Equals("3"))
            {
                stringBuilder.Append("select [material_name],[color],[size],[brand],[pr_name],[image_data],[desp],[pr_price] from mens_fashion where pr_id=" + str_pr_id);
            }
            else if (str_c_id.Equals("4"))
            {
                stringBuilder.Append("select [material_name],[color],[size],[brand],[pr_name],[image_data],[desp],[pr_price] from womens_fashion where pr_id=" + str_pr_id);
            }
            else if (str_c_id.Equals("5"))
            {
                stringBuilder.Append("select [brand],[pr_name],[image_data],[desp],[pr_price] from Beauty_health_grocery where pr_id=" + str_pr_id);
            }
            else if (str_c_id.Equals("6"))
            {
                stringBuilder.Append("select [publisher],[pr_name],[image_data],[desp],[pr_price] from book where pr_id=" + str_pr_id);
            }
            List<string> img = new List<string>();
            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(stringBuilder.ToString(), sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            string name = null, desp = null, price = null, os = null, seller = null, brand = null, color = null, size = null, material_name = null;
            while (reader.Read())
            {
                byte[] arr = (byte[])reader["image_data"];
                img.Add(Convert.ToBase64String(arr));
                name = reader["pr_name"].ToString();
                desp = reader["desp"].ToString();
                price = reader["pr_price"].ToString() + "₹";
                
                if (Session["c_id"].Equals("1"))
                {
                    os = reader["os"].ToString();
                    seller = reader["seller"].ToString();
                    brand = reader["brand"].ToString();
                    
                    dv4.InnerText = "Operating system: " + os;
                    dv5.InnerText = "Seller Details: " + seller;
                    dv6.InnerText = "brand: " + brand;
                    dv7.Visible = false;
                    string str = "select [pr_name],[pr_price],[image_data],[pr_id] from[mobile_and_computer] where brand= '" + brand + "'";
                    SqlDataSource1.SelectCommand = str;
                    //Response.Write(str);
                }
                else if (Session["c_id"].Equals("2"))
                {


                    brand = reader["brand"].ToString();
                    dv4.InnerText = "Brand: " + brand;
                    dv5.Visible = false;
                    dv6.Visible = false;
                    dv7.Visible = false;
                    string str = "select [pr_name],[pr_price],[image_data],[pr_id] from[tv_appliances_electronics] where brand= '" + brand + "'";
                    SqlDataSource1.SelectCommand = str;
                }
                else if (Session["c_id"].Equals("3"))
                {

                    color = reader["color"].ToString();
                    size = reader["size"].ToString();
                    material_name = reader["material_name"].ToString();
                    brand = reader["brand"].ToString();
                    dv4.InnerText = "Brand: " + brand;
                    dv5.InnerText = "Color: " + color;
                    dv6.InnerText = "Size: " + size;
                    dv7.InnerText = "Material" + material_name;
                    string str = "select [pr_name],[pr_price],[image_data],[pr_id] from[mens_fashion] where brand= '" + brand + "'";
                    SqlDataSource1.SelectCommand = str;
                }
                else if (Session["c_id"].Equals("4"))
                {
                    color = reader["color"].ToString();
                    size = reader["size"].ToString();
                    material_name = reader["material_name"].ToString();
                    brand = reader["brand"].ToString();
                    dv4.InnerText = "Brand: " + brand;
                    dv5.InnerText = "Color: " + color;
                    dv6.InnerText = "Size: " + size;
                    dv7.InnerText = "Material" + material_name;
                    string str = "select [pr_name],[pr_price],[image_data],[pr_id] from[mens_fashion] where brand= '" + brand + "'";
                    SqlDataSource1.SelectCommand = str;
                }
                else if (Session["c_id"].Equals("5"))
                {


                    brand = reader["brand"].ToString();
                    dv4.InnerText = "Brand: " + brand;
                    dv5.Visible = false;
                    dv6.Visible = false;
                    dv7.Visible = false;
                    string str = "select [pr_name],[pr_price],[image_data],[pr_id] from[Beauty_health_grocery] where brand= '" + brand + "'";
                    SqlDataSource1.SelectCommand = str;
                }
                else if (Session["c_id"].Equals("6"))
                {


                    brand = reader["publisher"].ToString();
                    dv4.InnerText = "Publisher: " + brand;
                    dv5.Visible = false;
                    dv6.Visible = false;
                    dv7.Visible = false;
                    string str = "select [publisher],[pr_name],[pr_price],[image_data],[pr_id] from[book] where publisher= '" + brand + "'";
                    SqlDataSource1.SelectCommand = str;
                }

            }

            dv1.InnerText = name;
            img1.ImageUrl = "data:Image1/png;base64," + img[0];
            dv2.InnerText = desp;
            dv3.InnerText = price;
            stringBuilder.Clear();
            stringBuilder.Append("select image_data from product_image where pr_id = " + str_pr_id + " and c_id=" + str_c_id);
            img.Clear();
            cmd = new SqlCommand(stringBuilder.ToString(), sqlConnection);
            reader.Close();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                byte[] arr = (byte[])reader["image_data"];
                img.Add(Convert.ToBase64String(arr));
            }
            ib1.ImageUrl = "data:Image1/png;base64," + img[0];
            ib2.ImageUrl = "data:Image1/png;base64," + img[1];

        }
        protected void view_img(object sender, EventArgs e)
        {
            ImageButton imageButton = (ImageButton)sender;
            img1.ImageUrl = imageButton.ImageUrl;
        }
        protected void Unnamed_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = (ImageButton)sender;
            //Response.Write(imageButton.AlternateText);
            Session["pr_id"] = imageButton.AlternateText;
            Response.Redirect("WebForm6.aspx");
        }

        
        protected void add_to_cart_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null) {
                Response.Write("<script>alert('You are not logged in,log in first')</script>");
                return;
            }
            string email = Session["email"].ToString();
            int c_id = Convert.ToInt32(Session["c_id"]);
            int p_id = Convert.ToInt32(Session["pr_id"]);
            int n = Convert.ToInt32(lbb.Value);
            //Response.Write(n);
            if (n == 0) {
                n = 1;
            }
            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();
            SqlDataReader reader;
            SqlCommand sqlCommand;
            
            if (Session["email"].Equals(""))
            {
                Response.Write("not logged in");
            }
            else {
                string query = "select *from add_to_cart where c_id=" + c_id + " and p_id=" + p_id+" and email='"+email+"'";
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                int p=0,x=0;
                while (reader.Read())
                {
                    p = Convert.ToInt32(reader["p_id"]);
                }
                //Response.Write(p);
                reader.Close();
                if (p!=0)
                {
                    query="select item_no from add_to_cart where c_id=" + c_id + " and p_id=" + p_id+" and email='"+email+"'";
                    sqlCommand=new SqlCommand(query, sqlConnection);
                    reader=sqlCommand.ExecuteReader();
                    while (reader.Read()) {
                        x = Convert.ToInt32(reader["item_no"]);
                    }
                    
                    //Response.Write(n+"   "+x);
                    n =n+ x;
                    reader.Close();
                    query="update add_to_cart set item_no="+n+" where c_id=" + c_id + " and p_id=" + p_id+" and email='"+email+"'";
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    //Response.Write("inserted");
                }
                else {
                    
                        query = "insert into add_to_cart values('" + email + "'," + c_id + "," + p_id + "," + n + ")";
                        sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        //Response.Write("inserted");
                    
                    }
                }
                sqlCommand = new SqlCommand("select count(*) from add_to_cart where email = '" + email + "'", sqlConnection);
                reader = sqlCommand.ExecuteReader();
                n= 0;
                while (reader.Read())
                {
                n = Convert.ToInt32(reader[0]);
                }
                System.Web.UI.HtmlControls.HtmlGenericControl span = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("number");
                span.InnerText="("+n+")";
            }
        }
}
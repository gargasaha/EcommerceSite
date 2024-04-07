using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace E_COMMERCE_SITE
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        private float total_price;
        protected void Page_Load(object sender, EventArgs e)
        {
            //EnableEventValidation = false;
            //Page.EnableEventValidation = false;
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("mdiv");
            div.Visible = false;
            fetch_data();
            calculate_price();
            price.Text=total_price.ToString()+ " \u20A8";
            double i = total_price + 50;
            total.Text = i.ToString() + " \u20A8";
        }
        protected void fetch_data() {
            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();
            string email = Session["email"].ToString();
            SqlCommand sqlCommand = new SqlCommand("select c_id,p_id,item_no from add_to_cart where email='" + email + "'", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<int> c_id = new List<int>();
            List<int> p_id = new List<int>();
            //List<int> item_no = new List<int>();
            while (reader.Read())
            {
                c_id.Add(reader.GetInt32(0));
                p_id.Add(reader.GetInt32(1));
                //item_no.Add(reader.GetInt32(2));
            }
            reader.Close();
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();
            StringBuilder sb5 = new StringBuilder();
            StringBuilder sb6 = new StringBuilder();
            sb1.Append("0");
            sb2.Append("0");
            sb3.Append("0");
            sb4.Append("0");
            sb5.Append("0");
            sb6.Append("0");
            for (int i = 0; i < p_id.Count; i++)
            {
                if (c_id[i] == 1)
                {
                    if (sb1.Length == 0)
                    {
                        sb1.Append(p_id[i].ToString());
                    }
                    else
                    {
                        sb1.Append("," + p_id[i].ToString());
                    }
                }
            }
            for (int i = 0; i < p_id.Count; i++)
            {
                if (c_id[i] == 2)
                {
                    if (sb2.Length == 0)
                    {
                        sb2.Append(p_id[i].ToString());
                    }
                    else
                    {
                        sb2.Append("," + p_id[i].ToString());
                    }
                }
            }
            for (int i = 0; i < p_id.Count; i++)
            {
                if (c_id[i] == 3)
                {
                    if (sb3.Length == 0)
                    {
                        sb3.Append(p_id[i].ToString());
                    }
                    else
                    {
                        sb3.Append("," + p_id[i].ToString());
                    }
                }
            }
            for (int i = 0; i < p_id.Count; i++)
            {
                if (c_id[i] == 4)
                {
                    if (sb4.Length == 0)
                    {
                        sb4.Append(p_id[i].ToString());
                    }
                    else
                    {
                        sb4.Append("," + p_id[i].ToString());
                    }
                }
            }
            for (int i = 0; i < p_id.Count; i++)
            {
                if (c_id[i] == 5)
                {
                    if (sb5.Length == 0)
                    {
                        sb5.Append(p_id[i].ToString());
                    }
                    else
                    {
                        sb5.Append("," + p_id[i].ToString());
                    }
                }
            }
            for (int i = 0; i < p_id.Count; i++)
            {
                if (c_id[i] == 6)
                {
                    if (sb6.Length == 0)
                    {
                        sb6.Append(p_id[i].ToString());
                    }
                    else
                    {
                        sb6.Append("," + p_id[i].ToString());
                    }
                }

            }
            //Response.Write(sb1);
            string query = "select c_id,item_no,image_data,pr_name,pr_price,pr_id from mobile_and_computer,add_to_cart where pr_id in(" + sb1 + ") and c_id=" + 1 + " and p_id=pr_id";
            SqlCommand sqlCommand1 = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            DataList1.DataSource = sqlDataReader1;
            DataList1.DataBind();
            sqlDataReader1.Close();

            string query2 = "select c_id,item_no,image_data,pr_name,pr_price,pr_id from tv_appliances_electronics,add_to_cart where pr_id in(" + sb2 + ") and c_id=" + 2 + " and p_id=pr_id";
            SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            DataList2.DataSource = sqlDataReader2;
            DataList2.DataBind();
            sqlDataReader2.Close();

            string query3 = "select c_id,item_no,image_data,pr_name,pr_price,pr_id from mens_fashion,add_to_cart where pr_id in(" + sb3 + ") and c_id=" + 3 + " and p_id=pr_id";
            SqlCommand sqlCommand3 = new SqlCommand(query3, sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            DataList3.DataSource = sqlDataReader3;
            DataList3.DataBind();
            sqlDataReader3.Close();

            query = "select c_id,item_no,image_data,pr_name,pr_price,pr_id from womens_fashion,add_to_cart where pr_id in(" + sb4 + ") and c_id=" + 4 + " and p_id=pr_id";
            SqlCommand SqlCommand4 = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader4 = SqlCommand4.ExecuteReader();
            DataList4.DataSource = sqlDataReader4;
            DataList4.DataBind();
            sqlDataReader4.Close();

            string query4 = "select c_id,item_no,image_data,pr_name,pr_price,pr_id from Beauty_health_grocery,add_to_cart where pr_id in(" + sb5 + ") and c_id=" + 5 + " and p_id=pr_id";
            SqlCommand sqlCommand5 = new SqlCommand(query4, sqlConnection);
            SqlDataReader sqlDataReader5 = sqlCommand5.ExecuteReader();
            DataList5.DataSource = sqlDataReader5;
            DataList5.DataBind();
            sqlDataReader5.Close();

            query = "select c_id,item_no,image_data,pr_name,pr_price,pr_id from book,add_to_cart where pr_id in(" + sb6 + ") and c_id=" + 6 + " and p_id=pr_id";
            SqlCommand sqlCommand6 = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader6 = sqlCommand6.ExecuteReader();
            DataList6.DataSource = sqlDataReader6;
            DataList6.DataBind();
            sqlDataReader6.Close();

        }
        protected void redirect_to_view(object sender,EventArgs e) {
            ImageButton imageButton = (ImageButton)sender;
            Session["pr_id"] = imageButton.AlternateText;
            Session["c_id"] = imageButton.CssClass;
            
            Response.Redirect("WebForm6.aspx");
            
        }
        protected void funrm(object sender,EventArgs e) {
            Button btn = (Button)sender;
            string c_id = (btn.CssClass).ToString();
            string pr_id = btn.CommandName;
            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();
            string query="delete from add_to_cart where c_id="+c_id+" and p_id="+pr_id;
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            //fetch_data();
            Response.Redirect("WebForm7.aspx");
        }
        protected void funbuy(object sender,EventArgs e) {
            Button btn = (Button)sender;
            string c_id = (btn.CssClass).ToString();
            string pr_id = btn.CommandName;
            Response.Write(c_id + "  " + pr_id);
        }
        protected void calculate_price() {
            total_price = 0;
            List<demo_data> data=new List<demo_data> ();
            string email = Session["email"].ToString();
            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select c_id,p_id,item_no from add_to_cart  where email='"+email+"'",sqlConnection);
            SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int pr_id, c_id,item_no;
                pr_id = Convert.ToInt32(sqlDataReader["p_id"]);
                c_id = Convert.ToInt32(sqlDataReader["c_id"]);
                item_no = Convert.ToInt32(sqlDataReader["item_no"]);
                data.Add(new demo_data(pr_id, c_id,item_no));

            }
            sqlDataReader.Close();  
            for (int i = 0; i < data.Count; i++) { 
                demo_data obj = data[i];
                int c_id = obj.get_c_id();
                int pr_id=obj.get_pr_id();
                int item_no=obj.get_item_no();
                if (c_id == 1) {
                    string str = "select pr_price from mobile_and_computer where pr_id=" + pr_id;
                    sqlCommand = new SqlCommand(str,sqlConnection);
                    sqlDataReader= sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read()){
                        total_price += Convert.ToInt32(sqlDataReader["pr_price"]) * item_no;
                    }
                    sqlDataReader.Close();  
                }
                else if (c_id == 2)
                {
                    string str = "select pr_price from tv_appliances_electronics where pr_id=" + pr_id;
                    sqlCommand = new SqlCommand(str, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        total_price += Convert.ToInt32(sqlDataReader["pr_price"]) * item_no;
                    }
                    sqlDataReader.Close();
                }
                else if (c_id == 3)
                {
                    string str = "select pr_price from mens_fashion where pr_id=" + pr_id;
                    sqlCommand = new SqlCommand(str, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        total_price += Convert.ToInt32(sqlDataReader["pr_price"]) * item_no;
                    }
                    sqlDataReader.Close();
                }
                else if (c_id == 4)
                {
                    string str = "select pr_price from womens_fashion where pr_id=" + pr_id;
                    sqlCommand = new SqlCommand(str, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        total_price += Convert.ToInt32(sqlDataReader["pr_price"]) * item_no;
                    }
                    sqlDataReader.Close();
                }
                else if (c_id == 5)
                {
                    string str = "select pr_price from beauty_health_grocery where pr_id=" + pr_id;
                    sqlCommand = new SqlCommand(str, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        total_price += Convert.ToInt32(sqlDataReader["pr_price"]) * item_no;
                    }
                    sqlDataReader.Close();
                }
                else if (c_id == 6)
                {
                    string str = "select pr_price from book where pr_id=" + pr_id;
                    sqlCommand = new SqlCommand(str, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        total_price += Convert.ToInt32(sqlDataReader["pr_price"]) * item_no;
                    }
                    sqlDataReader.Close();
                }
            }
        }
    }
    public class demo_data {
        int pr_id, c_id,item_no;
        public demo_data(int a, int b,int c) {
            pr_id = a;
            c_id = b;
            item_no = c;
        }
        public  int get_pr_id() {
            return pr_id;
        }
        public int get_c_id(){
            return c_id;
        }
        public int get_item_no(){
            return item_no;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<string> img=new List<string>();
        public static int j=0;
        public int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page.MaintainScrollPositionOnPostBack = false;
            
            List<string> image_data = new List<string>();
            List<string> category_name = new List<string>();

            string str = "ib1";
            string str2 = "tb1";
            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();


            SqlCommand sqlCommand = new SqlCommand("select image_data from product_category_image", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                byte[] bytes = (byte[])sqlDataReader["image_data"];
                image_data.Add(Convert.ToBase64String(bytes));
            }
            sqlDataReader.Close();

            SqlCommand sqlCommand2 = new SqlCommand("select category_name from product_category", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();


            while (sqlDataReader2.Read())
            {
                category_name.Add(sqlDataReader2["category_name"].ToString());
            }

            sqlDataReader2.Close();
            for (int i = 0; i < 6; i++)
            {
                Image image = (Image)holder.FindControl(str);
                image.ImageUrl = "data:Image1/png;base64," + image_data[i];
                TextBox textBox = (TextBox)holder.FindControl(str2);
                textBox.Text = category_name[i];
                str = edit_string(str, ref str2);
            }
            load_dynamic_object();
            //scroll_img();
        }
        protected string edit_string(string str, ref string str2)
        {
            string temp = str;
            string temp2 = str2;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '1' || temp[i] == '2' || temp[i] == '3' || temp[i] == '4' || temp[i] == '5' || temp[i] == '6')
                {
                    string ch = temp[i].ToString();
                    int num = Int32.Parse(ch);
                    num++;
                    string ch2 = num.ToString();
                    str = temp.Replace(ch, ch2);
                    str2 = temp2.Replace(ch, ch2);
                }
            }
            //Response.Write(temp);
            return str;
        }
        protected void item_view(object sender,EventArgs e) {
            Button btn = (Button)sender;
            if (btn.ID == "cb1")
            {
                Session["c_id"] = "1";
                //Response.Write(Session["c_id"]);
                Response.Redirect("WebForm5.aspx");
            }
            else if (btn.ID == "cb2")
            {
                Session["c_id"] = "2";
                Response.Redirect("WebForm5.aspx");
            }
            else if (btn.ID == "cb3")
            {
                Session["c_id"] = "3";
                Response.Redirect("WebForm5.aspx");
            }
            else if (btn.ID == "cb4")
            {
                Session["c_id"] = "4";
                Response.Redirect("WebForm5.aspx");
            }
            else if (btn.ID == "cb5")
            {
                Session["c_id"] = "5";
                Response.Redirect("WebForm5.aspx");
            }
            else if (btn.ID == "cb6") {
                Session["c_id"] = "6";
                Response.Redirect("WebForm5.aspx");
            }
        }
        protected string div_name(string str) {
            string temp = str;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '1' || temp[i] == '2' || temp[i] == '3' || temp[i] == '4' || temp[i] == '5' || temp[i] == '6')
                {
                    string ch = temp[i].ToString();
                    int num = Int32.Parse(ch);
                    num++;
                    string ch2 = num.ToString();
                    str = temp.Replace(ch, ch2);
                    
                }
            }
            //Response.Write(temp);
            return str;
        }
        protected void load_dynamic_object(){
            string dv = "dv1";
            SqlConnection conn = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("select image_data,flackert,sort_name from dynamic_offer_deal", conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<string> image_data=new List<string>();
            List<string> flackert=new List<string>();
            int count = 0;
            while (reader.Read())
            {
                byte[] image = (byte[])reader["image_data"];
                image_data.Add(Convert.ToBase64String(image));
                flackert.Add(reader["flackert"].ToString());
                count++;
            }
            for (int i = 0; i < count; i++) { 
                Image image = new Image();
                image.ImageUrl= "data:Image1/png;base64," + image_data[i];
                image.Height=200;
                image.Width = 200;
                TextBox textBox = new TextBox();
                textBox.Text = flackert[i];
                System.Web.UI.HtmlControls.HtmlGenericControl div=new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                div.ID = dv;
                //this.spawn_object.Controls.Add(div);
                //this..Controls.Add(image);
            }

        }
        protected void show_dynamic(object sender, EventArgs e) {
            ImageButton imageButton=(ImageButton)sender;
            string c_id = imageButton.CssClass.ToString();
            string sort_name=imageButton.AlternateText.ToString();
            Session["c_id"] = c_id;
            Session["sort_name"]=sort_name;
            Response.Redirect("WebForm5.aspx");
        }
        protected void scroll_img() {
            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select image_data from dynamic_offer_deal where flackert='scroll'",sqlConnection);
            
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read()) {
                byte[] b = (byte[])sqlDataReader["image_data"];
                img.Add(Convert.ToBase64String(b));
                i++;
            }
            
        }

        protected void Unnamed1_Tick(object sender, EventArgs e)
        {
            //if (j == i) {
            //    j = 0;
            //}
            //img1.ImageUrl = "data:Image1/png;base64," + img[j];
            //j++;
            //Page.MaintainScrollPositionOnPostBack = true;
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "hash", "location.hash = '#MOVEHERE';", true);
            //ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "ScrollTo", "var needScroll = true;", true);
        }
        
    }
}
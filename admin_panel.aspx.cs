using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class admin_panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void b1_Click(object sender, EventArgs e)
        {
            if (tb1.Text.Equals("") || TextBox2.Text.Equals(""))
            {
                Response.Write("All fields must be filled");
            }
            else
            {
                int i = 0;
                string eemail = tb1.Text.ToString();
                string epass = TextBox2.Text.ToString();
                SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=garga;Integrated Security=True");
                sqlConnection.Open();
                string s = "select count(*) as total from admin_manager where email='" + eemail + "' and passwd='" + epass + "'";
                SqlCommand sqlCommand = new SqlCommand(s, sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    i = Convert.ToInt32(reader["total"]);
                }
                if (i == 1)
                {
                    Session["admin_email"] = eemail;

                    Response.Redirect("WebForm3.aspx");
                }
                else
                {
                    Response.Write("Wrong Password");
                }
            }

        }
        
    }
}
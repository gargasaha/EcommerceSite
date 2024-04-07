using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            if (tb1.Text.Equals("") || tb2.Text.Equals("") ) {
                Response.Write("All fields must be filled");
            }
            else {
                int i = 0;
                string cname = tb1.Text.ToString();
                string cemail= tb2.Text.ToString();
                string cpassword=tb3.Text.ToString();
                string caddress=tb4.Text.ToString();    
                string cphone_no=tb5.Text.ToString();   
                string query = "select count(*) as total from register where cemail='" + cemail + "'";
                SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    i = Convert.ToInt32(reader["total"]);
                    
                }
                reader.Close();
                if (i == 1) {
                    Response.Write("Account already exists");
                    
                }
                else
                {
                    sqlCommand=new SqlCommand("prcRegister", sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@cname",SqlDbType.VarChar).Value = cname;
                    sqlCommand.Parameters.AddWithValue("@cemail", SqlDbType.VarChar).Value = cemail;
                    sqlCommand.Parameters.AddWithValue("@cpassword", SqlDbType.VarChar).Value = cpassword;
                    sqlCommand.Parameters.AddWithValue("@caddress", SqlDbType.VarChar).Value = caddress;
                    sqlCommand.Parameters.AddWithValue("@cphone_no", SqlDbType.VarChar).Value = cphone_no;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    Session["email"] = cemail;
                    Response.Redirect("WebForm1.aspx");
                }
            }
            
        }
    }
}
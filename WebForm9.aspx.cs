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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);

                string name = pr_name.Text;
                int st = Convert.ToInt32(stock.Text);
                int id = Convert.ToInt32(Session["pr_id"]);
                SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand cmd;
                if (Session["c_id"].Equals("1")) {
                    cmd = new SqlCommand("update_mobile_and_computer",sqlConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@image_data", bytes);
                    cmd.Parameters.AddWithValue("@pr_name", name);
                    cmd.Parameters.AddWithValue("@stock", st);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("WebForm8.aspx");
                }

                else if (Session["c_id"].Equals("2"))
                {
                    cmd = new SqlCommand("update_tv_appliances_electronics", sqlConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@image_data", bytes);
                    cmd.Parameters.AddWithValue("@pr_name", name);
                    cmd.Parameters.AddWithValue("@stock", st);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("WebForm8.aspx");
                }
                if (Session["c_id"].Equals("3"))
                {
                    cmd = new SqlCommand("update_mens_fashion", sqlConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@image_data", bytes);
                    cmd.Parameters.AddWithValue("@pr_name", name);
                    cmd.Parameters.AddWithValue("@stock", st);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("WebForm8.aspx");
                }
                if (Session["c_id"].Equals("4"))
                {
                    cmd = new SqlCommand("update_womens_fashion", sqlConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@image_data", bytes);
                    cmd.Parameters.AddWithValue("@pr_name", name);
                    cmd.Parameters.AddWithValue("@stock", st);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("WebForm8.aspx");
                }

                if (Session["c_id"].Equals("5"))
                {
                    cmd = new SqlCommand("update_beauty_health_grocery", sqlConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@image_data", bytes);
                    cmd.Parameters.AddWithValue("@pr_name", name);
                    cmd.Parameters.AddWithValue("@stock", st);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("WebForm8.aspx");
                }
                if (Session["c_id"].Equals("6"))
                {
                    cmd = new SqlCommand("update_book", sqlConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@image_data", bytes);
                    cmd.Parameters.AddWithValue("@pr_name", name);
                    cmd.Parameters.AddWithValue("@stock", st);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("WebForm8.aspx");
                }
            }
        }
    }
}
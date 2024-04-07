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
    public partial class WebForm19 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("mdiv");
            div.Visible = false;
        }
        protected void submit(object sender, EventArgs e) {
            string flackert, short_name, category;
            int c_id=0;
            Byte[] bytes = null;
            flackert = pr_flackert.Text.ToString();
            category = select.Value.ToString();
            short_name = pr_sort_name.Text.ToString();
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp" || fileExtension.ToLower() == ".jpeg")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                bytes = binaryReader.ReadBytes((int)stream.Length);
            }
     

            if (category.Equals("Mobile and Computer")) {
                c_id = 1;
            }
            else if (category.Equals("Tv,appliances and electronics")){
                c_id = 2;
            }
            else if (category.Equals("Mens fashion")) {
                c_id = 3;
            }
            else if (category.Equals("Womens fashion")) {
                c_id = 4;
            }
            else if (category.Equals("Beauty,health and grocery")) {
                c_id = 5;
            }
            else if (category.Equals("Books")) { 
                c_id = 6;
            }

            SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert_into_dynamic_offer_deal", sqlConnection);
            sqlCommand.CommandType= System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@image_data",bytes);
            sqlCommand.Parameters.AddWithValue("@flackert", flackert);
            sqlCommand.Parameters.AddWithValue("@c_id", c_id);
            sqlCommand.Parameters.AddWithValue("@sort_name", short_name);
            //Response.Write(bytes);
            sqlCommand.ExecuteNonQuery();
            Response.Write("<script>alert('file uploaded')</script>");

        }
        
    }
}
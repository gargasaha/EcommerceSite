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
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("mdiv");
            div.Visible = false;
            System.Web.UI.HtmlControls.HtmlGenericControl div2 = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("dynamic");
            div2.Visible = false;
        }
        protected void submit(object sender, EventArgs e)
        {
            Byte[] b1 = getimg1();
            Byte[] b2 = getimg2();
            Byte[] b3 = getimg3();
            if (b1 == null && b2 == null && b3 == null)
            {
                Response.Write("ALL IMAGE DATA ARE NOT UPLOADED");
            }
            else
            {
                string name, desp, brand,seller,os;
                double price;
                int stock;
                name = pr_name.Text.ToString();
                desp = pr_desp.Text.ToString();
                brand = pr_brand.Text.ToString();
                seller= pr_seller.Text.ToString();
                os=pr_os.Text.ToString();
                price = Convert.ToDouble((pr_price.Text).ToString());
                stock = Convert.ToInt32((pr_stock.Text).ToString());
                //Response.Write(name + desp + price + stock);
                SqlConnection sqlConnection = new SqlConnection("Data Source=GARGASAHA\\SQLEXPRESS;Initial Catalog=garga;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("insert1", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pr_name", name);
                cmd.Parameters.AddWithValue("pr_desp", desp);
                cmd.Parameters.AddWithValue("pr_price", price);
                cmd.Parameters.AddWithValue("pr_stock", stock);
                cmd.Parameters.AddWithValue("pr_brand", brand);
                cmd.Parameters.AddWithValue("pr_seller", seller);
                cmd.Parameters.AddWithValue("pr_os", os);
                cmd.Parameters.AddWithValue("img1", b1);
                cmd.Parameters.AddWithValue("img2", b2);
                cmd.Parameters.AddWithValue("img3", b3);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Given data is inserted')</script>");
            }
        }
        protected Byte[] getimg1()
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp" || fileExtension.ToLower() == ".jpeg")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);

                return bytes;
            }
            return null;
        }
        protected Byte[] getimg2()
        {
            HttpPostedFile postedFile = FileUpload2.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp" || fileExtension.ToLower() == ".jpeg")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);

                return bytes;
            }
            return null;
        }
        protected Byte[] getimg3()
        {
            HttpPostedFile postedFile = FileUpload3.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp" || fileExtension.ToLower() == ".jpeg")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);

                return bytes;
            }
            return null;
        }
    }
}
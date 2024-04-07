using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_COMMERCE_SITE
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("mdiv");
            div.Visible = false;

            if (Session["c_id"].Equals("3"))
            {
                if (Session["sort_name"] != null)
                {
                    string sort_name = Session["sort_name"].ToString();
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[mens_fashion] where desp like('%" + sort_name + "%')";
                    Session["sort_name"] = null;
                }
                else
                {
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[mens_fashion]";
                }

                //SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[mens_fashion]";
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb5.Enabled = false;
                cb6.Enabled = false;    
                cb7.Enabled = false;
                cb8.Enabled = false;
                cb9.Enabled = false;
                cb10.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
                cb14.Enabled = false;
                cb22.Enabled = false;
                cb23.Enabled = false;
                //nn.Visible = false;
            }
            else if (Session["c_id"].Equals("1"))
            {
                //Response.Write(Session["c_id"]);
                if (Session["sort_name"] != null)
                {
                    string sort_name = Session["sort_name"].ToString();
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[mobile_and_computer] where desp like('%" + sort_name + "%')";
                    Session["sort_name"] = null;
                }
                else {
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[mobile_and_computer]";
                }
                cb5.Enabled= false; 
                cb6.Enabled= false;
                cb7.Enabled= false;
                cb8.Enabled= false;
                cb9.Enabled= false;
                cb10.Enabled= false;
                cb15.Enabled= false;
                cb16.Enabled= false;
                cb17.Enabled= false;
                cb18.Enabled= false;
                cb19.Enabled= false;
                cb20.Enabled= false;
                cb21.Enabled= false;
                cb22.Enabled = false;
                cb23.Enabled = false;
            }
            else if (Session["c_id"].Equals("2"))
            {

                if (Session["sort_name"] != null)
                {
                    string sort_name = Session["sort_name"].ToString();
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[tv_appliances_electronics] where desp like('%" + sort_name + "%')";
                    Session["sort_name"] = null;
                }
                else
                {
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[tv_appliances_electronics]";
                }
                //SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[tv_appliances_electronics]";
                cb1.Enabled= false;
                cb2.Enabled= false;
                cb3.Enabled= false;
                cb4.Enabled= false;
                cb11.Enabled= false;
                cb12.Enabled= false;
                cb13.Enabled= false;
                cb14.Enabled= false;
                cb15.Enabled = false;
                cb16.Enabled= false;
                cb17.Enabled= false;
                cb18.Enabled= false;
                cb19.Enabled= false;
                cb20.Enabled= false;
                cb21.Enabled= false;
                cb22.Enabled = false;
                cb23.Enabled = false;
                //nn.Visible = false;
            }
            else if (Session["c_id"].Equals("4"))
            {

                if (Session["sort_name"] != null)
                {
                    string sort_name = Session["sort_name"].ToString();
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[womens_fashion] where desp like('%" + sort_name + "%')";
                    Session["sort_name"] = null;
                }
                else
                {
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[womens_fashion]";
                }
                //SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[tv_appliances_electronics]";
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
                cb14.Enabled = false;
                cb15.Enabled = true;
                cb16.Enabled = true;
                cb17.Enabled = true;
                cb18.Enabled = true;
                cb19.Enabled = true;
                cb20.Enabled = true;
                cb21.Enabled = true;

                cb1.Enabled = false;
                cb2.Enabled = false;
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb5.Enabled = false;
                cb6.Enabled = false;
                cb7.Enabled = false;
                cb8.Enabled = false;
                cb9.Enabled = false;
                cb10.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
                cb14.Enabled = false;
                cb22.Enabled = false;
                cb23.Enabled = false;
                //nn.Visible = false;
            }
            else if (Session["c_id"].Equals("5"))
            {

                if (Session["sort_name"] != null)
                {
                    string sort_name = Session["sort_name"].ToString();
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[Beauty_health_grocery] where desp like('%" + sort_name + "%')";
                    Session["sort_name"] = null;
                }
                else
                {
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[Beauty_health_grocery]";
                }
                //SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[Beauty_health_grocery]";
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
                cb14.Enabled = false;
                cb15.Enabled = false;
                cb16.Enabled = false;
                cb17.Enabled = false;
                cb18.Enabled = false;
                cb19.Enabled = false;
                cb20.Enabled = false;
                cb21.Enabled = false;

                cb1.Enabled = false;
                cb2.Enabled = false;
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb5.Enabled = false;
                cb6.Enabled = false;
                cb7.Enabled = false;
                cb8.Enabled = false;
                cb9.Enabled = false;
                cb10.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
                cb14.Enabled = false;

                //nn.Visible = false;
            }
            else if (Session["c_id"].Equals("6"))
            {

                if (Session["sort_name"] != null)
                {
                    string sort_name = Session["sort_name"].ToString();
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[book] where desp like('%" + sort_name + "%')";
                    Session["sort_name"] = null;
                }
                else
                {
                    SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[book]";
                }
                //SqlDataSource1.SelectCommand = "SELECT [pr_name], [pr_price], [image_data],[pr_id] FROM[Beauty_health_grocery]";
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
                cb14.Enabled = false;
                cb15.Enabled = false;
                cb16.Enabled = false;
                cb17.Enabled = false;
                cb18.Enabled = false;
                cb19.Enabled = false;
                cb20.Enabled = false;
                cb21.Enabled = false;

                cb1.Enabled = false;
                cb2.Enabled = false;
                cb3.Enabled = false;
                cb4.Enabled = false;
                cb5.Enabled = false;
                cb6.Enabled = false;
                cb7.Enabled = false;
                cb8.Enabled = false;
                cb9.Enabled = false;
                cb10.Enabled = false;
                cb11.Enabled = false;
                cb12.Enabled = false;
                cb13.Enabled = false;
                cb14.Enabled = false;
                cb22.Enabled = false;
                cb23.Enabled = false;
                //nn.Visible = false;
            }


        }

        protected void redirect_to_view(object sender, EventArgs e)
        {
            
            StringBuilder str = new StringBuilder();
            int f = 0;
            if (Session["c_id"].Equals("1"))
            {
                str.Append("select [pr_name],[pr_price],[image_data],[pr_id] from [mobile_and_computer] ");
                if (cb1.Checked || cb2.Checked || cb3.Checked || cb4.Checked)
                {
                    f = 1;

                    if (cb1.Checked)
                    {
                        str.Append(" where (brand='Oneplus'");
                    }
                    if (cb2.Checked)
                    {
                        if (cb1.Checked)
                        {
                            str.Append(" or brand='Realme'");
                        }
                        else { str.Append(" where (brand='Realme'"); }

                    }
                    if (cb3.Checked)
                    {
                        if (cb1.Checked || cb2.Checked)
                        {
                            str.Append(" or brand='Apple'");
                        }
                        else { str.Append(" where (brand='Apple'"); }

                    }
                    if (cb4.Checked)
                    {
                        if (cb1.Checked || cb2.Checked || cb3.Checked)
                        {
                            str.Append(" or brand='ASUS'");
                        }
                        else { str.Append(" where (brand='ASUS'"); }

                    }
                    str.Append(" ) ");
                }
                if (f == 1)
                {
                    if (cb11.Checked || cb12.Checked || cb13.Checked || cb14.Checked)
                    {

                        if (cb11.Checked)
                        {
                            str.Append(" and (os='Android'");
                        }
                        if (cb12.Checked)
                        {
                            if (cb11.Checked)
                            {
                                str.Append(" or os='IOS'");
                            }
                            else { str.Append(" and (os='IOS'"); }

                        }
                        if (cb13.Checked)
                        {
                            if (cb11.Checked || cb12.Checked)
                            {
                                str.Append(" or os='MAC OS'");
                            }
                            else { str.Append(" and (os='MAC OS'"); }

                        }
                        if (cb14.Checked)
                        {
                            if (cb11.Checked || cb12.Checked || cb13.Checked)
                            {
                                str.Append(" or os='Windows'");
                            }
                            else { str.Append(" and (os='Windows'"); }

                        }
                        str.Append(" ) ");
                    }
                }
                else if (cb11.Checked || cb12.Checked || cb13.Checked || cb14.Checked)
                {

                    if (cb11.Checked)
                    {
                        str.Append(" where ( os='Android'");
                    }
                    if (cb12.Checked)
                    {
                        if (cb11.Checked)
                        {
                            str.Append(" or os='IOS'");
                        }
                        else { str.Append(" where ( os='IOS'"); }

                    }
                    if (cb13.Checked)
                    {
                        if (cb11.Checked || cb12.Checked)
                        {
                            str.Append(" or os='MAC OS'");
                        }
                        else { str.Append(" where ( os='MAC OS'"); }

                    }
                    if (cb14.Checked)
                    {
                        if (cb11.Checked || cb12.Checked || cb13.Checked)
                        {
                            str.Append(" or os='Windows'");
                        }
                        else { str.Append(" where ( os='Windows'"); }

                    }
                    str.Append(" ) ");
                    f = 1;
                }
                string range = input_range.Value.ToString();
                int lb = Convert.ToInt32(range);
                int ub = Convert.ToInt32(range);
                lb = lb - 10000;
                ub = ub + 10000;
                string strlb, strub;
                strlb = Convert.ToString(lb);
                strub = Convert.ToString(ub);
                if (f == 1)
                {
                    str.Append(" and pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                else
                {
                    str.Append(" where pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                //Response.Write(str);
                SqlDataSource1.SelectCommand = str.ToString();
            }
            else if (Session["C_id"].Equals("2"))
            {
                str.Append("select [pr_name],[pr_price],[image_data],[pr_id] from [tv_appliances_electronics]");
                if (cb5.Checked || cb6.Checked || cb7.Checked || cb8.Checked || cb9.Checked || cb10.Checked)
                {
                    f = 1;

                    if (cb5.Checked)
                    {
                        str.Append(" where (brand='Redmi'");
                    }
                    if (cb6.Checked)
                    {
                        if (cb5.Checked)
                        {
                            str.Append(" or brand='LG'");
                        }
                        else { str.Append(" where (brand='LG'"); }

                    }
                    if (cb7.Checked)
                    {
                        if (cb5.Checked || cb6.Checked)
                        {
                            str.Append(" or brand='BoAt'");
                        }
                        else { str.Append(" where (brand='BoAt'"); }

                    }
                    if (cb8.Checked)
                    {
                        if (cb5.Checked || cb6.Checked || cb7.Checked)
                        {
                            str.Append(" or brand='Ambrane'");
                        }
                        else { str.Append(" where (brand='Ambrane'"); }

                    }
                    if (cb9.Checked)
                    {

                        if (cb5.Checked || cb6.Checked || cb7.Checked || cb8.Checked)
                        {
                            str.Append(" or brand='Canon'");
                        }
                        else { str.Append(" where (brand='Canon'"); }
                    }
                    if (cb10.Checked)
                    {

                        if (cb5.Checked || cb6.Checked || cb7.Checked || cb8.Checked || cb9.Checked)
                        {
                            str.Append(" or brand='Fujiflim'");
                        }
                        else { str.Append(" where (brand='Fujiflim'"); }
                    }
                    str.Append(" ) ");
                    f = 1;
                }

                string range = input_range.Value.ToString();
                int lb = Convert.ToInt32(range);
                int ub = Convert.ToInt32(range);
                lb = lb - 1000;
                ub = ub + 1000;
                string strlb, strub;
                strlb = Convert.ToString(lb);
                strub = Convert.ToString(ub);
                if (f == 1)
                {
                    str.Append(" and pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                else
                {
                    str.Append(" where pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                //Response.Write(str);    
                SqlDataSource1.SelectCommand = str.ToString();
            }
            else if (Session["C_id"].Equals("3"))
            {
                str.Append("select [pr_name],[pr_price],[image_data],[pr_id] from [mens_fashion]");
                if (cb15.Checked || cb16.Checked || cb17.Checked || cb18.Checked)
                {
                    f = 1;

                    if (cb15.Checked)
                    {
                        str.Append(" where ( brand='Manyavar'");
                    }
                    if (cb16.Checked)
                    {
                        if (cb15.Checked)
                        {
                            str.Append(" or brand='AMERICAN CREW'");
                        }
                        else
                        {
                            str.Append(" where ( brand='AMERICAN CREW'");
                        }
                    }
                    if (cb17.Checked)
                    {
                        if (cb15.Checked || cb16.Checked)
                        {
                            str.Append(" or brand='ELEGANTE'");
                        }
                        else
                        {
                            str.Append(" where ( brand='ELEGANTE'");
                        }
                    }
                    if (cb18.Checked)
                    {
                        if (cb15.Checked || cb16.Checked || cb17.Checked)
                        {
                            str.Append(" or brand='London Hills'");
                        }
                        else
                        {
                            str.Append(" where ( brand='London Hills'");
                        }
                    }
                    str.Append(" ) ");
                }
                if (f == 1)
                {
                    if (cb19.Checked || cb20.Checked || cb21.Checked)
                    {
                        str.Append(" and ( ");
                        if (cb19.Checked)
                        {
                            str.Append("material_name like('%Cotton%')");
                        }
                        if (cb20.Checked)
                        {
                            if (cb19.Checked)
                            {
                                str.Append(" or material_name like('%Denim%')");
                            }
                            else { str.Append("material_name like('%Denim%)"); }

                        }
                        if (cb21.Checked)
                        {
                            if (cb19.Checked || cb20.Checked)
                            {
                                str.Append(" or material_name like('%silk%')");
                            }
                            else { str.Append("material_name like('%silk%')"); }

                        }
                        str.Append(" ) ");
                    }
                }
                else if (cb19.Checked || cb20.Checked || cb21.Checked)
                {


                    if (cb19.Checked)
                    {
                        str.Append(" where ( material_name like('%Cotton%')");
                    }
                    if (cb20.Checked)
                    {
                        if (cb19.Checked)
                        {
                            str.Append(" or material_name like('%Denim%')");
                        }
                        else { str.Append(" where (material_name like('%Denim%')"); }

                    }
                    if (cb21.Checked)
                    {
                        if (cb19.Checked || cb20.Checked)
                        {
                            str.Append(" or material_name like('%silk%')");
                        }
                        else { str.Append(" where (material_name like('%silk%')"); }

                    }
                    str.Append(" ) ");
                    f = 1;
                }
                string range = input_range.Value.ToString();
                int lb = Convert.ToInt32(range);
                int ub = Convert.ToInt32(range);
                lb = lb - 1000;
                ub = ub + 1000;
                string strlb, strub;
                strlb = Convert.ToString(lb);
                strub = Convert.ToString(ub);
                if (f == 1)
                {
                    str.Append(" and pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                else
                {
                    str.Append(" where pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                //Response.Write(str);
                SqlDataSource1.SelectCommand = str.ToString();
            }
            else if (Session["C_id"].Equals("4"))
            {
                str.Append("select [pr_name],[pr_price],[image_data],[pr_id] from [womens_fashion]");
                if (cb15.Checked || cb16.Checked || cb17.Checked || cb18.Checked)
                {
                    f = 1;

                    if (cb15.Checked)
                    {
                        str.Append(" where ( brand='Manyavar'");
                    }
                    if (cb16.Checked)
                    {
                        if (cb15.Checked)
                        {
                            str.Append(" or brand='AMERICAN CREW'");
                        }
                        else
                        {
                            str.Append(" where ( brand='AMERICAN CREW'");
                        }
                    }
                    if (cb17.Checked)
                    {
                        if (cb15.Checked || cb16.Checked)
                        {
                            str.Append(" or brand='ELEGANTE'");
                        }
                        else
                        {
                            str.Append(" where ( brand='ELEGANTE'");
                        }
                    }
                    if (cb18.Checked)
                    {
                        if (cb15.Checked || cb16.Checked || cb17.Checked)
                        {
                            str.Append(" or brand='London Hills'");
                        }
                        else
                        {
                            str.Append(" where ( brand='London Hills'");
                        }
                    }
                    str.Append(" ) ");
                }
                if (f == 1)
                {
                    if (cb19.Checked || cb20.Checked || cb21.Checked)
                    {
                        str.Append(" and ( ");
                        if (cb19.Checked)
                        {
                            str.Append("material_name like('%Cotton%')");
                        }
                        if (cb20.Checked)
                        {
                            if (cb19.Checked)
                            {
                                str.Append(" or material_name like('%Denim%')");
                            }
                            else { str.Append("material_name like('%Denim%)"); }

                        }
                        if (cb21.Checked)
                        {
                            if (cb19.Checked || cb20.Checked)
                            {
                                str.Append(" or material_name like('%silk%')");
                            }
                            else { str.Append("material_name like('%silk%')"); }

                        }
                        str.Append(" ) ");
                    }
                }
                else if (cb19.Checked || cb20.Checked || cb21.Checked)
                {


                    if (cb19.Checked)
                    {
                        str.Append(" where ( material_name like('%Cotton%')");
                    }
                    if (cb20.Checked)
                    {
                        if (cb19.Checked)
                        {
                            str.Append(" or material_name like('%Denim%')");
                        }
                        else { str.Append(" where (material_name like('%Denim%')"); }

                    }
                    if (cb21.Checked)
                    {
                        if (cb19.Checked || cb20.Checked)
                        {
                            str.Append(" or material_name like('%silk%')");
                        }
                        else { str.Append(" where (material_name like('%silk%')"); }

                    }
                    str.Append(" ) ");
                    f = 1;
                }
                string range = input_range.Value.ToString();
                int lb = Convert.ToInt32(range);
                int ub = Convert.ToInt32(range);
                lb = lb - 1000;
                ub = ub + 1000;
                string strlb, strub;
                strlb = Convert.ToString(lb);
                strub = Convert.ToString(ub);
                if (f == 1)
                {
                    str.Append(" and pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                else
                {
                    str.Append(" where pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                //Response.Write(str);
                SqlDataSource1.SelectCommand = str.ToString();
            }
            else if (Session["c_id"].Equals("5")) {
                str.Append("select [pr_name],[pr_price],[image_data],[pr_id] from [Beauty_health_grocery]");
                if (cb22.Checked || cb23.Checked) {
                    f = 1;
                    if (cb22.Checked) {
                        str.Append(" where ( brand = 'Maybelline' ");
                    }
                    if (cb23.Checked) {
                        if (cb2.Checked)
                        {
                            str.Append(" or brand = 'LOreal'");
                        }
                        else {
                            str.Append(" where ( brand = 'LOreal'");
                        }
                    }
                    str.Append(" ) ");
                }
                string range = input_range.Value.ToString();
                int lb = Convert.ToInt32(range);
                int ub = Convert.ToInt32(range);
                lb = lb - 1000;
                ub = ub + 1000;
                string strlb, strub;
                strlb = Convert.ToString(lb);
                strub = Convert.ToString(ub);
                if (f == 1)
                {
                    str.Append(" and pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                else
                {
                    str.Append(" where pr_price>=" + strlb + " and pr_price<=" + strub);
                }
                //Response.Write(str);
                SqlDataSource1.SelectCommand = str.ToString();
            }
        }
        protected void Unnamed_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = (ImageButton)sender;
            //Response.Write(imageButton.AlternateText);
            Session["pr_id"]=imageButton.AlternateText;
            Session["sort_name"] = null;
            Response.Redirect("WebForm6.aspx");
        }
    }
}
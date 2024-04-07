<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <%-- <style>
        .major_div {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            margin-top: 100px;
            column-gap: 50px;
        }

        .product_name {
            margin-bottom: 50px;
        }

        .product_desp {
            width: 200px;
        }
    </style>--%>

   <style>
    body {
      font-family: Arial, sans-serif;
    }

    /* Customize the styles according to your design */
    .product-container {
      column-gap:50px;
      margin: 0 auto;
      padding: 20px;
      display:flex;
      flex-wrap:wrap;
      margin-top:100px;
      justify-content:center
      
    }

    .product-image {
      height:600px;
      width:500px;
      display: block;
      margin-bottom: 20px;
      border-width:5px;
      border-color:#808080;
      
    }

    .product-title {
        display:inline;
      font-size: 24px;
      font-weight: bold;
      margin-bottom: 10px;
      background-color:aqua
      
    }
    .supp_img {
       border-style:solid;
       border-color:#808080;
    }
    .product-description {
      font-size: 16px;
      margin-bottom: 20px;
      margin-top:100px;
    }

    .product-price {
      font-size: 20px;
      font-weight: bold;
      margin-bottom: 10px;
    }

    .product-rating {
      color: #f39c12;
      font-size: 18px;
      margin-bottom: 10px;
    }

    .product-btn {
      background-color: #269b19;
      color: #fff;
      border: none;
      padding: 10px 20px;
      font-size: 16px;
      cursor: pointer;
      border-radius:25px;
      
      transition: background-color 0.2s;
    }

    .product-btn:hover {
      background-color: #2980b9;
    }
    .other_details {
         font-size:25px;
         width:300px;
         font-weight:500;
         text-decoration-style:wavy;
    }
       .supp_img {
        filter: drop-shadow(10px 10px 5px #3e3b3b);
       }
       .plus_minus {
            font-size:30px;
            margin-left:20px;
            
       }
  </style>
    <script>
        var i = 0;
        function funplus() {
            var lbl = document.getElementById('<%=lbb.ClientID%>');
            lbl.value = ++i;
            
        }
        function funminus() {
            var lbl = document.getElementById('<%=lbb.ClientID%>');
            if (i <= 0) {
                return;
            }
            else {
                lbl.value = --i;
            }
        }
    </script>
    <div class="product-container">
        <asp:ScriptManager ID="sm1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <div>
                    <asp:Image runat="server" BorderStyle="Solid" CssClass="product-image" ID="img1" />

                    <br />
                    <br />
                    <asp:ImageButton CssClass="supp_img" runat="server" Width="200px" Height="100px" ID="ib1" OnClick="view_img" />
                    <asp:ImageButton CssClass="supp_img" runat="server" Width="200px" Height="100px" ID="ib2" OnClick="view_img" />

                </div>


            </ContentTemplate>
        </asp:UpdatePanel>
        <div style="width: 500px">
            <div>
                <h1 class="product-title" runat="server" id="dv1">Product Title</h1>
                <br />
                <b style="font-size: 25px; margin-top: 50px;">Details in brief</b>
                <p class="product-description" runat="server" id="dv2">Product description goes here. Provide all the relevant details about the product.</p>

                <p class="product-price" id="dv3" runat="server"></p>
                <div style="margin-top: 150px;">
                    <asp:Button CssClass="product-btn" runat="server" Text="BUY" />
                    <asp:Button CssClass="product-btn" runat="server" Text="ADD TO CART" ID="add_to_cart" OnClick="add_to_cart_Click" />
                    <input runat="server" type="button" value="+" height="40px" width="80px" class="plus_minus" onclick="funplus()" />
                    <input type="text" runat="server" id="lbb" style="font-size:30px;display:inline;width:40px;margin-left:10px" value="0"/>
                    
                    <input runat="server" type="button" value="-" height="40px" width="80px" class="plus_minus" onclick="funminus()" />
                </div>
            </div>
        </div>
        <div>
            <ul style="margin-top: 100px;">
                <li runat="server" id="dv4" class="other_details"></li>
                <li runat="server" id="dv5" class="other_details"></li>
                <li runat="server" id="dv6" class="other_details"></li>
                <li runat="server" id="dv7" class="other_details"></li>
            </ul>
        </div>
    </div>

    <div style="display: flex; justify-content: center; font-size: 30px; text-decoration: dotted; margin-top: 100px; color: #ff0000">
        <b>Related products from same brand</b>
    </div>
    <div style="display: flex; justify-content: center">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gargaConnectionString %>"></asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <div style="background-color: #CCCCFF; width: 350px; height: 400px; margin-left: 50px; margin-top: 50px;">
                    <asp:ImageButton OnClick="Unnamed_Click" ID="img" CssClass="img_but" BorderStyle="Solid" BorderWidth="5px" AlternateText='<%# Eval("pr_id") %>' Height="300px" Width="300px" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' />
                    <br />
                    <br />
                    <asp:Label CssClass="name_label" ID="pr_nameLabel" Width="300px" runat="server" Text='<%# Eval("pr_name") %>' />
                    <br />
                    <span style="font-family: 'Edu SA Beginner', cursive; font-family: 'IBM Plex Mono', monospace; font-family: 'Lumanosimo', cursive; font-family: 'Merriweather', serif; font-family: 'Roboto Mono', monospace;">Price:</span>

                    <asp:Label ID="pr_priceLabel" runat="server" Text='<%# Eval("pr_price") %>' />
                    <span>&#8377</span>
                    <br />
                    <br />
                </div>

            </ItemTemplate>
        </asp:DataList>

    </div>
</asp:Content>

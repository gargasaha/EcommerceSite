<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm1"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    
        .home_body {
            margin-top:50px;
            margin-left:30px;
            margin-right:30px;
            height:900px;
            text-align:center;
            border-top-left-radius:25px;
            border-top-right-radius:25px;
            border-bottom-left-radius:25px;
            border-bottom-right-radius:25px;
            background-color:#11113b;
            text-align:center;
        }
        .home_body_header {
            height: 40px;
            font-size: 20px;
            padding-top: 20px;
            color: white;
            font-family: 'Edu SA Beginner', cursive;
            font-family: 'Lumanosimo', cursive;
            font-family: 'Merriweather', serif;
        }
        .body_body_box_holder{
            display:flex;
            justify-content:center;
            flex-wrap:wrap;
            column-gap:100px;
        }
        .box_model{
            margin-top:30px;
            margin-right:50px;
        }
        .view_button {
            width:100px;
            height:30px;
            border-radius:25px;
            margin-top:30px;
            color:white;
            height:50px;
            width:100px;
            background-color:black;
            box-shadow:10px 5px 10px #2b2b2b;
            
        }
        .view_button:hover {
            top:20px;
            border-bottom-width:5px;
            border-bottom-color:yellow;
            box-shadow:10px 5px 10px #808080;
            box-shadow:0px 0px 20px yellow;
        }
        .category_name_div {
            color:white;
            width:180px;
            border-width:0px;
            margin-top:20px;
            border:solid;
            border-color:#2b2b2b;
            width:200px;
            background-color:#11113b;
        }
        .spawn_object {
            margin-top:300px;
            display:flex;
            flex-wrap:wrap;
            justify-content:center;
        }
        .flackert {
            font-family: 'Edu SA Beginner', cursive;
            font-family: 'Lumanosimo', cursive;
            font-family: 'Merriweather', serif;
            font-family: 'Roboto Mono', monospace;
            background-color:aqua;
        }
        .dl1 {
            text-align:center;
        }
        .cr_img {
            box-shadow: 10px 10px 5px #0e0e0e;
            border-radius:25px;
        }
        
    </style>
   
    <div class="home_body">
        <div class="home_body_header">
            Our category
        </div>
        <div class="body_body_box_holder" id="holder" runat="server">
            <div style="height:150px;width:130px;" class="box_model">
                <asp:Image runat="server" ID="ib1" Height="200px" Width="200px" CssClass="cr_img" BorderColor="Black" BorderWidth="5px" />
                <br />
                <asp:TextBox ReadOnly="true" ID="tb1" runat="server" CssClass="category_name_div"></asp:TextBox>
                <br />
                <asp:Button id="cb1" runat="server" Text="VIEW" CssClass="view_button" OnClick="item_view"/>
            </div>
            <div style="height:150px;width:130px;" class="box_model">
                <asp:Image ID="ib2" runat="server" Height="200px" Width="200px"  CssClass="cr_img" BorderColor="Black" BorderWidth="5px" />
                <br />
                <asp:TextBox ReadOnly="true" ID="tb2" runat="server" CssClass="category_name_div"></asp:TextBox>
                <br /> 
                <asp:Button id="cb2" runat="server" Text="VIEW" CssClass="view_button" OnClick="item_view"/>
            </div>
            <div style="height:150px;width:130px;" class="box_model">
                <asp:Image id="ib3" runat="server" Height="200px" Width="200px"  CssClass="cr_img" BorderColor="Black" BorderWidth="5px"  />
                <br /> 
                <asp:TextBox ReadOnly="true" ID="tb3" runat="server" CssClass="category_name_div"></asp:TextBox>
                <br />
                <asp:Button id="cb3" runat="server" Text="VIEW" CssClass="view_button" OnClick="item_view"/>
            </div>
        </div>
        <div class="body_body_box_holder" id="holder2" runat="server" style="margin-top:200px;">
            <div style="height:150px;width:130px;" class="box_model">
                <asp:Image runat="server" ID="ib4" Height="200px" Width="200px" CssClass="cr_img" BorderColor="Black" BorderWidth="5px" />
                <br />
                <asp:TextBox ReadOnly="true" ID="tb4" runat="server" CssClass="category_name_div"></asp:TextBox>
                <br />
                <asp:Button ID="cb4" runat="server" Text="VIEW" CssClass="view_button" OnClick="item_view"/>
            </div>
            <div style="height:150px;width:130px;" class="box_model">
                <asp:Image ID="ib5" runat="server" Height="200px" Width="200px"  CssClass="cr_img" BorderColor="Black" BorderWidth="5px" />
                <br />
                <asp:TextBox ReadOnly="true" ID="tb5" runat="server" CssClass="category_name_div"></asp:TextBox>
                <br />
                <asp:Button ID="cb5" runat="server" Text="VIEW" CssClass="view_button" OnClick="item_view"/>
            </div>
            <div style="height:150px;width:130px;" class="box_model">
                <asp:Image id="ib6" runat="server" Height="200px" Width="200px"  CssClass="cr_img" BorderColor="Black" BorderWidth="5px" />
                <br />
                <asp:TextBox ReadOnly="true" ID="tb6" runat="server" CssClass="category_name_div"></asp:TextBox>
                <br />
                <asp:Button id="cb6" runat="server" Text="VIEW" CssClass="view_button" OnClick="item_view"/>
            </div>
        </div>
        <div>
            TRENDING
        </div>
        <div runat="server" id="spawn_object" class="spawn_object">
            
            <asp:DataList ID="DataList1"  runat="server" DataSourceID="SqlDataSource1" RepeatColumns="3" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" GridLines="Both" RepeatDirection="Horizontal">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="White" />
                <ItemTemplate>
                    
                    <asp:ImageButton AlternateText='<%# Eval("sort_name") %>' ID="b1" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' Height="200px" Width ="200px" BorderWidth="5px" BorderStyle="Dashed"  OnClick="show_dynamic" CssClass='<%# Eval("c_id") %>'/>
                    <br />
                   
                    <asp:Label ID="flackertLabel" CssClass="flackert" runat="server" Text='<%# Eval("flackert") %>' />
                    <br />
<br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gargaConnectionString %>" SelectCommand="SELECT [image_data], [flackert],[sort_name],[c_id] FROM [dynamic_offer_deal] where flackert !='scroll'"></asp:SqlDataSource>
        </div>

    </div>
    
    <script>
        var x = 1;
        var i = setInterval(function () {
            if (x == 4) {
                x = 1;
            }
            document.getElementById("imgg").src = "/images/" + x.toString() + ".jpg";
            x++;
        },5000)
    </script>
   
</asp:Content>

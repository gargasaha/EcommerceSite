<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .admin_name_style {
            margin-bottom:20px;
            position:relative;
        }
        .img {
            width:auto;
            padding:10px;
            height:50px;
            filter:drop-shadow(20px 20px 10px #3c3c3c);
            border-radius:25px;
            background-color:black;
            color:white;
            font-size:large;
            border:solid;
            border-color:yellow;
        }
        .img:hover {
            box-shadow:0px 0px 20px yellow;  
        }
    </style>
    <div style="display:flex;justify-content:center;font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;font-size:40px">
    ADMIN PANEL
</div>
    <div style="text-align:end;margin-right:100px">
        <table align="right" runat="server">
            <tr>
                <td colspan="1" align="center">
                    <image src="images/admin_img.jpg" height="80px" width="80px"></image>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="admin_name" runat="server" CssClass="admin_name_style"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <select id="s" runat="server" style="width:180px" onclick="option()">
                        <option>
                            SELECT
                        </option>
                        <option value="LOGOUT">
                            LOGOUT
                        </option>
                        <option value="CHANGE_PAASWORD">
                            CHANGE PASSWORD
                        </option>
                    </select>
                </td>
            </tr>
        </table>
        
        
    </div>
    
    <div style="display:flex;margin-top:200px;margin-left:100px;background-color:#808080;margin-right:100px;padding:50px;border-radius:25px">
         <div>
            <img src="images/product.png" style="height:200px;width:200px;border-radius:25px;border:solid;border-width:5px;filter: drop-shadow(20px 20px 10px #3c3c3c);"/>
         </div>
        <div style="margin-top:70px;margin-left:50px">
            <asp:Button runat="server"  Text="SHOW  ALL  STOCK" OnClick="products" CssClass="img"/>
        </div>
    </div>
     <div style="display:flex;margin-top:100px;margin-left:100px;background-color:#808080;margin-right:100px;padding:50px;border-radius:25px">
         <div>
            <img src="images/add.jpg" style="height:200px;width:200px;border-radius:25px;border:solid;border-width:5px;filter: drop-shadow(20px 20px 10px #3c3c3c);"/>
         </div>
        <div style="margin-top:70px;margin-left:50px">
            <asp:Button runat="server"  Text="ADD  STOCK  IN  INVENTORY" OnClick="addproducts" CssClass="img" />
        </div>
    </div>
     <div style="display:flex;margin-top:100px;margin-left:100px;background-color:#808080;margin-right:100px;padding:50px;border-radius:25px">
         <div>
            <img src="images/advertisement.jpeg" style="height:200px;width:200px;border-radius:25px;border:solid;border-width:5px;filter: drop-shadow(20px 20px 10px #3c3c3c);"/>
         </div>
        <div style="margin-top:70px;margin-left:50px">
            <asp:Button runat="server"  Text="ADD  DYNAMIC  ADVERTISEMENT" OnClick="add_dynamic_image" CssClass="img"/>
        </div>
    </div>
    <script>
        function option() {
            var s = document.getElementById('<%= s.ClientID %>');
            if (s.value == "LOGOUT") {
                console.log("ran");
                if (confirm("Are you sure for logout")) {
                    
                    sessionStorage.setItem("admin_email", "");
                    window.location = "WebForm1.aspx";
                }
                else
                    return;
            }
            else if (s.value=="CHANGE_PASSWORD") {

            }

           
        }
    </script>
</asp:Content>

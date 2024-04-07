<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:flex;justify-content:center;font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;font-size:40px">
        ADMIN PANEL
    </div>
    <div style="text-align: end; margin-right: 100px">
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
                    <select id="s" runat="server" style="width: 180px" onclick="option()">
                        <option>SELECT
                        </option>
                        <option value="LOGOUT">LOGOUT
                        </option>
                        <option value="CHANGE_PAASWORD">CHANGE PASSWORD
                        </option>
                    </select>
                </td>
            </tr>
        </table>



    </div>
    <div style="display: flex; justify-content: center;align-items:center;flex-direction:column;background-color:gray;margin:100px 400px 0px 400px;padding-bottom:100px;border-radius:25px">
        <div>
            <asp:Button runat="server" CssClass="commonLabel" ID="bmc" Text="ADD PRODUCT FOR MOBILE AND COMPUTER" OnClick="add_item"/>
        </div>
        <div>
             <asp:Button runat="server" CssClass="commonLabel" ID="btae" Text="ADD PRODUCT FOR TV,APPLIANCES AND ELECTRINICS" OnClick="add_item"/>
        </div>
        <div>
            <asp:Button runat="server" CssClass="commonLabel" ID="bmf" Text="ADD PRODUCT FOR MENS FASHION" OnClick="add_item"/>
        </div>
        <div>
            <asp:Button runat="server" CssClass="commonLabel" ID="bwf" Text="ADD PRODUCT FOR WOMEN FASHION" OnClick="add_item"/>
        </div>
        <div>
            <asp:Button runat="server" CssClass="commonLabel" ID="bbhg" Text="ADD PRODUCT FOR BEAUTY,HEALTH AND GROCERY" OnClick="add_item"/>
        </div>
        <div>
            <asp:Button runat="server" CssClass="commonLabel" ID="bb" Text="ADD PRODUCT FOR BOOKS" OnClick="add_item"/>
        </div>
    </div>
    <style>
    .commonLabel {
        font-size:30px;
        color:black;
        font-weight:bold;
        background-color:crimson;
        padding:40px;
        border-radius:25px;
        margin-top:50px;
        width:900px
    }
    .admin_name_style {
        margin-bottom: 20px;
        position: relative;
    }
    </style>
</asp:Content>

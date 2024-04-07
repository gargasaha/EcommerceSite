﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm15.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div style="font-size: 50px; text-align: center; font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">
            WOMENS FASHION UPLOAD SECTION
        </div>
        <div style="display: flex; justify-content: center; margin-top: 100px;">


            <table border="4">
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT NAME</b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="pr_name" Width="300px" Height="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT DESCRIPTION</b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="pr_desp" Width="300px" Height="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT PRICE</b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="pr_price" Width="300px" Height="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT MATERIAL NAME</b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="pr_material" Width="300px" Height="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT COLOR</b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="pr_color" Width="300px" Height="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT SIZE</b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="pr_size" Width="300px" Height="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT STOCK QUANTITY</b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="pr_stock" Width="300px" Height="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT BRAND</b>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="pr_brand" Width="300px" Height="50px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT MAIN IMAGE</b>
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="300px" Height="50px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT SECOND SUPPORTING IMAGE</b>
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload2" runat="server" Width="300px" Height="50px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <b style="font-size: 25px">ENTER PRODUCT THIRD SUPPORTING IMAGE</b>
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload3" runat="server" Width="300px" Height="50px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button runat="server" ID="b1" OnClick="submit" Text="SUBMIT" Height="50px" Width="100px" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:flex;justify-content:center">
        <table>
            <tr>
                <td>
                    ENTER PRODUCT NEW NAME
                </td>
                <td>
                    <asp:TextBox runat="server" ID="pr_name"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    ENTER PRODUCT NEW STOCK NUMBER
                </td>
                <td>
                    <asp:TextBox runat="server" ID="stock"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    SELECT NEW IMAGE FOR PRODUCT
                </td>
                <td>
                    <asp:FileUpload id="FileUpload1" runat="server"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button text="SUBMIT" runat="server" OnClick="submit"/>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>

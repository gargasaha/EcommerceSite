<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm19.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:flex;justify-content:center;">
        <div style="display:block;font-size:30px;font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">ADD DYNAMIC OFFER DEAL
        </div>
    </div>
    <div style="display:flex;justify-content:center;margin-top:100px">
    
        <div>
            <table>
                <tr>
                    <td>ENTER FLACKERT NAME
                    </td>
                    <td>
                        <asp:TextBox ID="pr_flackert" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        SELECT CATEGORY
                    </td>
                    <td>
                        <select runat="server" id="select">
                            <option value="Select"></option>
                            <option value="Mobile and Computer"></option>
                            <option value="Tv,appliances and electronics"></option>
                            <option value="Mens fashion"></option>
                            <option value="Womens fashion"></option>
                            <option value="Beauty,health and grocery"></option>
                            <option value="Book"></option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>SELECT SHORT NAME</td>
                    <td>
                        <asp:TextBox ID="pr_sort_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        SELECT IMAGE
                    </td>
                    <td>
                         <asp:FileUpload ID="FileUpload1" runat="server" Width="300px" Height="50px"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button text="SUBMIT" runat="server" OnClick="submit"/>
                    </td>
                </tr>
            </table>
        </div>
    </div>


</asp:Content>

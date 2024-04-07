<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log_in.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/StyleSheet1.css" rel="stylesheet"/>
</head>
<body>
    <div class="all">
        <div class="heading_div">
            Sign In
        </div>
        <div class="body_div">
            <form runat="server">
                <table>
                    <tr>
                        <td>
                            <div>
                                ENTER EMAIL
                            </div>
                        </td>
                        <td>
                            <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="padding-top:30px;">
                            ENTER PASSWORD
                        </td>
                        <td style="padding-top:30px;">
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align:center;padding-top:50px;padding-bottom:50px;" >
                            <asp:Button Text="SUBMIT" ID="b1" runat="server" CssClass="b1" OnClick="b1_Click" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
</body>
</html>

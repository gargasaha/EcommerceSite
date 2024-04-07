<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .name_label {
            background-color:#1ABC9C ;
        }
        .img_but {
            filter: drop-shadow(20px 20px 10px #3e3b3b);
        }
    </style>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gargaConnectionString %>" ></asp:SqlDataSource>
    <div style="display:flex;justify-content:center;">
        <div>
            
            <div>
                <p>SELECT BRAND</p>
                <b>Digital device Brand</b>
                
                <br /><br />
                <asp:CheckBox ID="cb1" Text="Oneplus" runat="server" Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb2" Text="Realme" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb3" Text="Apple" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb4" Text="Asus" runat="server"  Font-Size="20px"/>
                <br />
                
                <b>Electronic device brand</b>
                <br /><br />
                <asp:CheckBox ID="cb5" Text="Redmi" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb6" Text="LG" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb7" Text="BoAt" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb8" Text="Ambrane" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb9" Text="Canon" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb10" Text="Fujiflim" runat="server"  Font-Size="20px"/>
                <br />
                
                <b>Fashion brand</b>
                <br /><br />
                
                <asp:CheckBox ID="cb15" Text="Manyavar" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb16" Text="AMERICAN CREW" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb17" Text="ELEGANTE" runat="server"  Font-Size="20px"/>
                <br />
               <asp:CheckBox ID="cb18" Text="London Hills" runat="server"  Font-Size="20px"/>
               <br />
                <b>Fashion product material</b>
               <br /><br />
                <asp:CheckBox ID="cb19" Text="Cotton" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb20" Text="Denim" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb21" Text="silk" runat="server"  Font-Size="20px"/>
                <br />
                <br />

                <b>Select beauty Brands</b>
               <br /><br />
                <asp:CheckBox ID="cb22" Text="Maybelline" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb23" Text="LOreal" runat="server"  Font-Size="20px"/>
               
            </div>
            <div>
                <p id="nn" runat="server">SELECT OPERATING SYSTEM(OS)</p>
                <asp:CheckBox ID="cb11" Text="Android" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb12" Text="IOS" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb13" Text="MAC OS" runat="server"  Font-Size="20px"/>
                <br />
                <asp:CheckBox ID="cb14" Text="Windows" runat="server"  Font-Size="20px"/>
            </div>
            <div>
                Price
                <input id="input_range" runat="server" type="range" min="0" max="170000" onchange="range_val()"/>
                <label id="range_res"></label>
                <span>&#8377</span>
            </div>
            <div>
                <asp:Button runat="server" OnClick="redirect_to_view" Text="Search"/>
            </div>
        </div>
        <div style="margin-left:100px;border-left:solid">
           
                
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="3" CssClass="dl1">
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
    </div>
    <script>
        function range_val() {

            var a = document.getElementById('<%= input_range.ClientID %>').value;
            document.getElementById('range_res').innerText = a;
        }
    </script>
    
</asp:Content>

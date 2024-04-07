<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    .name {
        font-size:30px;
        background-color:aqua;
        margin-left:30px;
    }
    .price {
        font-size:25px;
        margin-top:40px;
        margin-left:30px;
    }
    .item {
         font-size:25px;
        margin-top:40px;
        margin-left:30px;     
    }
</style>
    <div style="font-size:60px;text-align:center;margin-bottom:100px">
            Shopping cart
        </div>
    <style>
        .rm_buy {
            margin-left:30px;
            display:flex;
            margin-top:50px;
            column-gap:50px;
        }
    </style>
    <%--<asp:ScriptManager ID="sm1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="up1" runat="server">
        <ContentTemplate>--%>
            <div style="display: flex; justify-content: center; margin-bottom: 500px;">
                <div>
                    <asp:DataList ID="DataList1" runat="server" RepeatColumns="1">
                        <ItemTemplate>
                            <div style="display: flex;">
                                <div>
                                    <asp:ImageButton OnClick="redirect_to_view" ID="img" CssClass='<%# Eval("c_id") %>' BorderStyle="Solid" BorderWidth="5px" AlternateText='<%# Eval("pr_id") %>' Height="300px" Width="300px" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' />

                                </div>
                                <div>
                                    <asp:Label ID="pr_nameLabel" CssClass="name" runat="server" Text='<%# Eval("pr_name") %>' Width="400px"/>
                                    <br />

                                    <asp:Label ID="pr_priceLabel" CssClass="price" runat="server" Text='<%# Eval("pr_price") %>' />
                                    <br />
                                    <span style="margin-left: 30px; font-size: 25px">Qty selected</span>
                                    <asp:Label ID="selected" CssClass="item" runat="server" Text='<%# Eval("item_no") %>'></asp:Label>
                                    <br />
                                    <div class="rm_buy">
                                        <asp:Button Text="REMOVE" ID="rm" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funrm"  BackColor="#33cccc"/>
                                        <asp:Button Text="BUY NOW" ID="b" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funbuy"  BackColor="#33cccc"/>
                                    </div>
                                </div>
                            </div>
                            <br />

                        </ItemTemplate>

                    </asp:DataList>
                    <asp:DataList ID="DataList2" runat="server" RepeatColumns="1">
                        <ItemTemplate>

                            <div style="display: flex;">
                                <div>
                                    <asp:ImageButton OnClick="redirect_to_view" ID="img" CssClass='<%# Eval("c_id") %>' BorderStyle="Solid" BorderWidth="5px" AlternateText='<%# Eval("pr_id") %>' Height="300px" Width="300px" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' />

                                </div>
                                <div>
                                    <asp:Label ID="pr_nameLabel" CssClass="name" runat="server" Text='<%# Eval("pr_name") %>' />
                                    <br />

                                    <asp:Label ID="pr_priceLabel" CssClass="price" runat="server" Text='<%# Eval("pr_price") %>' />
                                    <br />
                                    <span style="margin-left: 30px; font-size: 25px">Qty selected</span>
                                    <asp:Label ID="selected" CssClass="item" runat="server" Text='<%# Eval("item_no") %>'></asp:Label>
                                    <br />
                                    <div class="rm_buy">
                                        <asp:Button Text="REMOVE" ID="rm" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funrm"  BackColor="#33cccc"/>
                                        <asp:Button Text="BUY NOW" ID="b" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funbuy"  BackColor="#33cccc"/>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </ItemTemplate>

                    </asp:DataList>
                    <asp:DataList ID="DataList3" runat="server" RepeatColumns="1">
                        <ItemTemplate>

                            <div style="display: flex;">
                                <div>
                                    <asp:ImageButton OnClick="redirect_to_view" ID="img" CssClass='<%# Eval("c_id") %>' BorderStyle="Solid" BorderWidth="5px" AlternateText='<%# Eval("pr_id") %>' Height="300px" Width="300px" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' />

                                </div>
                                <div>
                                    <asp:Label ID="pr_nameLabel" CssClass="name" runat="server" Text='<%# Eval("pr_name") %>' />
                                    <br />

                                    <asp:Label ID="pr_priceLabel" CssClass="price" runat="server" Text='<%# Eval("pr_price") %>' />
                                    <br />
                                    <span style="margin-left: 30px; font-size: 25px">Qty selected</span>
                                    <asp:Label ID="selected" CssClass="item" runat="server" Text='<%# Eval("item_no") %>'></asp:Label>
                                    <br />
                                    <div class="rm_buy">
                                        <asp:Button Text="REMOVE" ID="rm" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funrm"  BackColor="#33cccc"/>
                                        <asp:Button Text="BUY NOW" ID="b" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funbuy"  BackColor="#33cccc"/>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </ItemTemplate>

                    </asp:DataList>
                    <asp:DataList ID="DataList4" runat="server" RepeatColumns="1">
                        <ItemTemplate>

                            <div style="display: flex;">
                                <div>
                                    <asp:ImageButton OnClick="redirect_to_view" ID="img" CssClass='<%# Eval("c_id") %>' BorderStyle="Solid" BorderWidth="5px" AlternateText='<%# Eval("pr_id") %>' Height="300px" Width="300px" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' />

                                </div>
                                <div>
                                    <asp:Label ID="pr_nameLabel" CssClass="name" runat="server" Text='<%# Eval("pr_name") %>' />
                                    <br />

                                    <asp:Label ID="pr_priceLabel" CssClass="price" runat="server" Text='<%# Eval("pr_price") %>' />
                                    <br />
                                    <span style="margin-left: 30px; font-size: 25px">Qty selected</span>
                                    <asp:Label ID="selected" CssClass="item" runat="server" Text='<%# Eval("item_no") %>'></asp:Label>
                                    <br />
                                    <div class="rm_buy">
                                        <asp:Button Text="REMOVE" ID="rm" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funrm"  BackColor="#33cccc"/>
                                        <asp:Button Text="BUY NOW" ID="b" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funbuy"  BackColor="#33cccc"/>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </ItemTemplate>

                    </asp:DataList>
                    <asp:DataList ID="DataList5" runat="server" RepeatColumns="1">
                        <ItemTemplate>

                            <div style="display: flex;">
                                <div>
                                    <asp:ImageButton OnClick="redirect_to_view" ID="img" CssClass='<%# Eval("c_id") %>' BorderStyle="Solid" BorderWidth="5px" AlternateText='<%# Eval("pr_id") %>' Height="300px" Width="300px" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' />

                                </div>
                                <div>
                                    <asp:Label ID="pr_nameLabel" CssClass="name" runat="server" Text='<%# Eval("pr_name") %>' />
                                    <br />

                                    <asp:Label ID="pr_priceLabel" CssClass="price" runat="server" Text='<%# Eval("pr_price") %>' />
                                    <br />
                                    <span style="margin-left: 30px; font-size: 25px">Qty selected</span>
                                    <asp:Label ID="selected" CssClass="item" runat="server" Text='<%# Eval("item_no") %>'></asp:Label>
                                    <br />
                                    <div class="rm_buy">
                                        <asp:Button Text="REMOVE" ID="rm" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funrm"  BackColor="#33cccc"/>
                                        <asp:Button Text="BUY NOW" ID="b" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funbuy"  BackColor="#33cccc"/>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </ItemTemplate>

                    </asp:DataList>
                    <asp:DataList ID="DataList6" runat="server" RepeatColumns="1">
                        <ItemTemplate>

                            <div style="display: flex;">
                                <div>
                                    <asp:ImageButton OnClick="redirect_to_view" ID="img" CssClass='<%# Eval("c_id") %>' BorderStyle="Solid" BorderWidth="5px" AlternateText='<%# Eval("pr_id") %>' Height="300px" Width="300px" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' />

                                </div>
                                <div>
                                    <asp:Label ID="pr_nameLabel" CssClass="name" runat="server" Text='<%# Eval("pr_name") %>' />
                                    <br />

                                    <asp:Label ID="pr_priceLabel" CssClass="price" runat="server" Text='<%# Eval("pr_price") %>' />
                                    <br />
                                    <span style="margin-left: 30px; font-size: 25px">Qty selected</span>
                                    <asp:Label ID="selected" CssClass="item" runat="server" Text='<%# Eval("item_no") %>'></asp:Label>
                                    <br />
                                    <div class="rm_buy">
                                        <asp:Button Text="REMOVE" ID="rm" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funrm"  BackColor="#33cccc"/>
                                        <asp:Button Text="BUY NOW" ID="b" runat="server" Height="40px" Width="160px" Font-Size="Large" CssClass='<%# Eval("c_id") %>' CommandName='<%# Eval("pr_id") %>' OnClick="funbuy" BackColor="#33cccc"/>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </ItemTemplate>

                    </asp:DataList>
                </div>
                <div style="width:300px">
                    <div style="text-align:center;font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;font-size:25px">
                        <b>PRICE DETAILS</b>
                    </div>
                    <br />
                    <br />
                    <div style="text-align:center">
                        <span style="font-size:20px">CART TOTAL:</span>
                        <asp:Label runat="server" ID="price" Font-Size="20px" Font-Bold="true">
                        </asp:Label>
                        <br />
                        <br />
                        <span style="font-size:20px">
                            DELIVERY CHARGE: <b>50 Rs</b>
                        </span>
                        <br />
                        <br />
                        <span>
                            DELIVERY CHARGE:
                        </span>
                        <asp:Label runat="server" ID="total" Font-Size="20px" Font-Bold="true">
                        </asp:Label>
                        <br />
                        <br />
                        <asp:Button text="BUY NOW" Height="40px" runat="server" Width="300px" BackColor="#33cccc" Font-Size="25px" Font-Bold="true" CssClass="bt1"/>
                    </div>

                    
                </div>
            </div>
        <style>
            .bt1 {
                font-family:'Times New Roman', Times, serif;
                
            }
        </style>
        <%--</ContentTemplate>
    </asp:UpdatePanel>--%>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="E_COMMERCE_SITE.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .img {
            height:200px;
            width:200px
        }
    </style>
    <div style="display:flex;justify-content:center">
        <div >
        <%--mobile_and_computer--%>
        <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="false" 
           
            >
            <Columns>
                 <asp:TemplateField HeaderText="PRODUCT ID">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_id") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                   
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PRODUCT IMAGE">
                    <ItemTemplate>
                        <asp:Image ID="img" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' CssClass="img" />
                        <br />
                       
                        
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>


                <asp:TemplateField HeaderText="PRODUCT NAME">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_name") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>

                <asp:TemplateField HeaderText="STOCK"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("stock") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/edit.png" Height="50px" Width="90" OnClick="update_click1" AlternateText="1"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/delete.png" Height="50px" Width="90" OnClick="delete_click1" AlternateText="1"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <%--electronics--%>
        <asp:GridView ID="gv2" runat="server" AutoGenerateColumns="false" 
           
            >
            <Columns>
                 <asp:TemplateField HeaderText="PRODUCT ID">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_id") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                   
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PRODUCT IMAGE">
                    <ItemTemplate>
                        <asp:Image ID="img" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' CssClass="img" />
                        <br />
                       
                        
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>


                <asp:TemplateField HeaderText="PRODUCT NAME">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_name") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>

                <asp:TemplateField HeaderText="STOCK"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("stock") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/edit.png" Height="50px" Width="90" OnClick="update_click2" AlternateText="2"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/delete.png" Height="50px" Width="90" OnClick="delete_click2" AlternateText="2"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
            </Columns>
        </asp:GridView>


        <asp:GridView ID="gv3" runat="server" AutoGenerateColumns="false" 
           
            >
            <Columns>
                 <asp:TemplateField HeaderText="PRODUCT ID">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_id") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                   
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PRODUCT IMAGE">
                    <ItemTemplate>
                        <asp:Image ID="img" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' CssClass="img" />
                        <br />
                       
                        
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>


                <asp:TemplateField HeaderText="PRODUCT NAME">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_name") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>

                <asp:TemplateField HeaderText="STOCK"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("stock") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/edit.png" Height="50px" Width="90" OnClick="update_click3" AlternateText="3"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/delete.png" Height="50px" Width="90" OnClick="delete_click3" AlternateText="3"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            <%--womens fashion--%>
        <asp:GridView ID="gv4" runat="server" AutoGenerateColumns="false" 
           
            >
            <Columns>
                 <asp:TemplateField HeaderText="PRODUCT ID">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_id") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                   
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PRODUCT IMAGE">
                    <ItemTemplate>
                        <asp:Image ID="img" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' CssClass="img" />
                        <br />
                       
                        
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>


                <asp:TemplateField HeaderText="PRODUCT NAME">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_name") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>

                <asp:TemplateField HeaderText="STOCK"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("stock") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/edit.png" Height="50px" Width="90" OnClick="update_click4" AlternateText="4"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/delete.png" Height="50px" Width="90"  OnClick="delete_click4" AlternateText="4"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <%--beauty--%>

        <asp:GridView ID="gv5" runat="server" AutoGenerateColumns="false" 
           
            >
            <Columns>
                 <asp:TemplateField HeaderText="PRODUCT ID">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_id") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                   
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PRODUCT IMAGE">
                    <ItemTemplate>
                        <asp:Image ID="img" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' CssClass="img" />
                        <br />
                       
                        
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>


                <asp:TemplateField HeaderText="PRODUCT NAME">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_name") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>

                <asp:TemplateField HeaderText="STOCK"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("stock") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/edit.png" Height="50px" Width="90" OnClick="update_click5" AlternateText="5"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/delete.png" Height="50px" Width="90" OnClick="delete_click5" AlternateText="5"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

            <%--book--%>


        <asp:GridView ID="gv6" runat="server" AutoGenerateColumns="false" 
           
            >
            <Columns>
                 <asp:TemplateField HeaderText="PRODUCT ID">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_id") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                   
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PRODUCT IMAGE">
                    <ItemTemplate>
                        <asp:Image ID="img" runat="server" ImageUrl='<%# ((Eval("image_data") is System.DBNull) ? "[Path to blank image]" : "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_data"))) %>' CssClass="img" />
                        <br />
                       
                        
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>


                <asp:TemplateField HeaderText="PRODUCT NAME">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("pr_name") %>' runat="server"></asp:Label>
                       
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>

                <asp:TemplateField HeaderText="STOCK"> 
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("stock") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/edit.png" Height="50px" Width="90" OnClick="update_click6" AlternateText="6"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UPDATE"> 
                    <ItemTemplate>
                        <asp:ImageButton  CssClass='<%# Eval("pr_id") %>' runat="server" ImageUrl="images/delete.png" Height="50px" Width="90"  OnClick="delete_click6" AlternateText="6"/>
                    </ItemTemplate>
                   
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>
    </div>
    
   

</asp:Content>

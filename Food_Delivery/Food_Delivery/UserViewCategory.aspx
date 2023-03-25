<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.Master" AutoEventWireup="true" CodeBehind="UserViewCategory.aspx.cs" Inherits="Food_Delivery.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 style="text-align:center;color:#183434;margin-top:50px;">CHOOSE YOUR CATEGORY</h1>
    <p style="text-align:center;color:red;">&nbsp;</p>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <p style="text-align:center;color:red;">
        <asp:DataList ID="DataList1" runat="server" DataKeyField="CatID" Height="285px" RepeatColumns="4" RepeatDirection="Horizontal" Width="1284px">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("CatID") %>'></asp:Label>
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageUrl='<%# Eval("CatImage") %>' OnClick="ImageButton1_Click" Width="300px" />
                <asp:HiddenField ID="hidd" runat="server" Value='<%# Eval("CatID") %>'/>
                
                
                <h3><%# Eval("CatName") %></h3>
            </ItemTemplate>

        </asp:DataList>
</asp:Content>

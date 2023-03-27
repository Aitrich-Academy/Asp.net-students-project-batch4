<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersViewCategories.aspx.cs" Inherits="Food_Delivery.UsersViewCategories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="background-color:#183434" class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" style="margin-left:600px;" ForeColor="#FFCC66">
                <Items>
                    <asp:MenuItem Text="Edit Profile" Value="Edit Profile" NavigateUrl="~/UserProfile.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Ordered Items" Value="Order Items" NavigateUrl="~/UserViewOrderedItems.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Feedback" Value="Feedback" NavigateUrl="~/Feedback.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="About " Value="About " NavigateUrl="~/AboutRestuarant.aspx"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/ContactUs.aspx" Text="ContactUs" Value="Log Out"></asp:MenuItem>
                    <asp:MenuItem Text="Log Out" Value="Log Out" NavigateUrl="~/UserLogout.aspx"></asp:MenuItem>
                </Items>
                <StaticMenuItemStyle HorizontalPadding="10px" ItemSpacing="20px" />
            </asp:Menu>
        </div>
         <h1 style="text-align:center;color:#183434;margin-top:50px;">CHOOSE YOUR CATEGORY</h1>
    <p style="text-align:center;color:red;">&nbsp;</p>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <p style="text-align:center;color:red;">
        <asp:DataList ID="DataList1" runat="server" DataKeyField="CatID" Height="285px" RepeatColumns="4" RepeatDirection="Horizontal" Width="1284px">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("CatID") %>' visible="false"></asp:Label>
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageUrl='<%# Eval("CatImage") %>' OnClick="ImageButton1_Click" Width="300px" />
                <asp:HiddenField ID="hidd" runat="server" Value='<%# Eval("CatID") %>'/>
                
                
                <h3><%# Eval("CatName") %></h3>
            </ItemTemplate>

        </asp:DataList>
    </form>
</body>
</html>

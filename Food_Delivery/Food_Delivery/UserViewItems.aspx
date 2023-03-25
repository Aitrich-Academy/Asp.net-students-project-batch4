<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserViewItems.aspx.cs" Inherits="Food_Delivery.UserViewItems" %>

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
                    <asp:MenuItem Text="Food Category" Value="Food Category" NavigateUrl="~/UserViewCategory.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Ordered Items" Value="Order Items"></asp:MenuItem>
                    <asp:MenuItem Text="Feedback" Value="Feedback" NavigateUrl="~/UserFeedback.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="About " Value="About " NavigateUrl="~/AboutRestuarant.aspx"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/ContactUs.aspx" Text="ContactUs" Value="Log Out"></asp:MenuItem>
                    <asp:MenuItem Text="Log Out" Value="Log Out" NavigateUrl="~/UserLogout.aspx"></asp:MenuItem>
                </Items>
                <StaticMenuItemStyle HorizontalPadding="10px" ItemSpacing="20px" />
            </asp:Menu>
        </div>
        <div>
            <asp:DataList ID="DataListItem" runat="server" Height="297px" RepeatColumns="4" RepeatDirection="Horizontal" Width="1095px" >
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl='<%# Eval("ItmImage") %>' Width="300px" Height="300px" OnClick="ImageButton2_Click" />
            <br />
            <asp:HiddenField ID="Hf" runat="server" Value='<%# Eval("ItmID") %>' />
            <h2> <%# Eval("ItmName") %></h2>
            <p>Rs.<%# Eval("ItmPrice") %></p>
        </ItemTemplate>
    </asp:DataList>
        </div>
    </form>
</body>
</html>

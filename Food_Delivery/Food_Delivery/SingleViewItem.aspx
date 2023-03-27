<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SingleViewItem.aspx.cs" Inherits="Food_Delivery.SingleViewItem" %>

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
                    <asp:MenuItem Text="Food Category" Value="Food Category" NavigateUrl="~/UsersViewCategories.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Ordered Items" Value="Order Items" NavigateUrl="~/UserViewOrderedItems.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Feedback" Value="Feedback" NavigateUrl="~/Feedback.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="About " Value="About " NavigateUrl="~/AboutRestuarant.aspx"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/ContactUs.aspx" Text="ContactUs" Value="Log Out"></asp:MenuItem>
                    <asp:MenuItem Text="Log Out" Value="Log Out" NavigateUrl="~/UserLogout.aspx"></asp:MenuItem>
                </Items>
                <StaticMenuItemStyle HorizontalPadding="10px" ItemSpacing="20px" />
            </asp:Menu>
        </div>
         <div style="display:inline-block"><asp:Image ID="Image1" runat="server" Height="369px" Width="486px" style="margin-left: 113px" />
    <div style="display:inline">
        </div>
   


    <div style="display:inline-block;margin-left:100px;top:10px; margin-top: 0px;" width: 353px; ><h1> <asp:Label ID="LabelItemName" runat="server" Text="Label"></asp:Label></h1>
 
    <h3>Rs:<asp:Label ID="ItmPrice" runat="server" Text="Price"></asp:Label>
    </h3>
        <h4>

        <asp:Label ID="LabelDiscription" runat="server" Text="Label" ></asp:Label>

        </h4>
    <p style="margin-left: 80px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
             <asp:Button ID="ButtonDec" runat="server" Text="-" Height="26px" Width="36px" OnClick="ButtonDec_Click"  />
            <asp:Label ID="Label1" runat="server" Height="16px" Text="1" Width="43px" ></asp:Label>
             <asp:Button ID="ButtonInc" runat="server" Text="+"  Height="25px" Width="36px" OnClick="ButtonInc_Click1" />
        </p>
    <p style="margin-left: 80px">
        <asp:Button ID="Buttonorder" runat="server" OnClick="Buttonorder_Click" Text="Order Now" style="margin-left: 1px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
    </p></div>
       


    </div>
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
    </form>
</body>
</html>

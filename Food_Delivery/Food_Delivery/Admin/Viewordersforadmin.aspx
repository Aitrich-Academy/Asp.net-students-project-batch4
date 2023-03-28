<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Viewordersforadmin.aspx.cs" Inherits="Food_Delivery.Admin.Viewordersforadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridVieworder" runat="server" AutoGenerateColumns="False" style="margin-top: 200px;margin-left:400px;align-content:center;" DataKeyNames="BookID" OnSelectedIndexChanged="GridVieworder_SelectedIndexChanged" >
        <Columns>
            <asp:BoundField DataField="ItmName" HeaderText="Item Name" />
            <asp:BoundField DataField="Qty" HeaderText="Quantity" />
            <asp:BoundField DataField="Total" HeaderText="Amount" />
            <asp:BoundField DataField="UID" HeaderText="User ID" />
            <asp:BoundField DataField="UName" HeaderText="User" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:TemplateField HeaderText="Response">
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CommandName="Select" Text="Confirm" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

<asp:HiddenField ID="HiddenField1" runat="server" />

</asp:Content>

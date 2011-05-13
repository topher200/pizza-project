<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderComplete.aspx.cs" Inherits="AnderaPizzaCompany.OrderComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Success!
    </h2>
    <p>
        Your order has been placed.
        <br />
        <asp:Label ID="ReferenceNumberLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="TotalLabel" runat="server"></asp:Label>
        <br />
        Summary:
        <asp:GridView ID="PizzaGridView" runat="server" DataSourceID="OrderObject" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="OrderObject" runat="server" 
            SelectMethod="GetPizzaDataTable" TypeName="AnderaPizzaCompany.Order"
            OnObjectCreating="OrderObject_ObjectCreating">
        </asp:ObjectDataSource>
        <br />
        Your order will be ready in 30 minutes or it's free!
    </p>
    <asp:Button runat="server" ID="home" OnClick="GoHome" Text="Home" />
</asp:Content>

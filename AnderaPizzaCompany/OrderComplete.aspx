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
        <asp:GridView ID="PizzaGridView" runat="server" DataSourceID="OrderObject">
        </asp:GridView>
        <asp:ObjectDataSource ID="OrderObject" runat="server" 
            SelectMethod="GetPizzaDataTable" TypeName="AnderaPizzaCompany.Order"
            OnObjectCreating="OrderObject_ObjectCreating">
        </asp:ObjectDataSource>
        <br />
        Your order will be ready in 30 minutes or it's free!
    </p>
    <asp:Button runat="server" ID="home" OnClick="GoHome"/>
</asp:Content>

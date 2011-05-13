<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AnderaPizzaCompany.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Checkout
    </h2>
    <h3>
        Order Summary:
        <br />
        <asp:GridView ID="PizzaGridView" runat="server" DataSourceID="OrderObject">
        </asp:GridView>
        <asp:ObjectDataSource ID="OrderObject" runat="server" 
            SelectMethod="GetPizzaDataTable" TypeName="AnderaPizzaCompany.Order"
            OnObjectCreating="OrderObject_ObjectCreating">
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="TotalLabel" runat="server"></asp:Label>
    </h3>
    <p>
        <button id="submit" onserverclick="OnSubmitButton" runat="server">
            Submit order!</button>
        <button id="cancel_button" onserverclick="Cancel" runat="server">
            Cancel order</button>
    </p>
</asp:Content>

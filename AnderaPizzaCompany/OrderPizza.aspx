<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderPizza.aspx.cs" Inherits="AnderaPizzaCompany.OrderPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Pizza Ordering Page
    </h2>
    <p>
        You currently have these pizzas:
        <br />
        <asp:Label ID="label_pizza0" Text="" runat="server" />
    </p>
    <p>
        Would you like to add a pizza to your order?
    </p>
    <p>
        <button id="cheese" onserverclick="Click" runat="server">
            Cheese Button</button>
    </p>
    <p>
        <button id="checkout" onserverclick="OnCheckoutButton" runat="server">
            Go to Checkout</button>
    </p>
</asp:Content>

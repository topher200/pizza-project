<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderPizza.aspx.cs" Inherits="AnderaPizzaCompany.OrderPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Pizza Ordering Page
    </h2>
    <p>
        You currently have this many pizzas:
        <asp:Label ID="num_pizzas_label" Text="11" runat="server" />
    </p>
    <p>
        Which pizza would you like?
        <br />
        <button id="cheese" onserverclick="Click" runat="server">
            Cheese Button</button>
    </p>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AnderaPizzaCompany.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Checkout
    </h2>
    <p>
        <button id="submit" onserverclick="OnSubmitButton" runat="server">
            Submit order!</button>
    </p>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPizza.aspx.cs" Inherits="AnderaPizzaCompany.AddPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Add a Pizza to your order
    </h2>
    <p>
        <asp:CheckBox Text="Broccoli" runat="server" id="broccoli"/>
    </p>
    <p>
        <asp:Button Text="Add Pizza to Order" runat="server" OnClick="Submit"/>
    </p>
</asp:Content>

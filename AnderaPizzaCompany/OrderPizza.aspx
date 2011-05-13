<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderPizza.aspx.cs" Inherits="AnderaPizzaCompany.OrderPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Pizza Ordering Page
    </h2>
    <p>
        Current order:
        <br />
        <asp:GridView ID="PizzaGridView" runat="server" DataSourceID="OrderObject">
        </asp:GridView>
        <asp:ObjectDataSource ID="OrderObject" runat="server" 
            SelectMethod="GetPizzaDataTable" TypeName="AnderaPizzaCompany.Order"
            OnObjectCreating="OrderObject_ObjectCreating">
        </asp:ObjectDataSource>
    </p>
    <p>
        Would you like to add a pizza to your order?
        <asp:GridView ID="PizzasGridView" runat="server" 
            AutoGenerateColumns="False" DataSourceID="DatabasePizzas"
            OnRowCommand="PizzasGridView_RowCommand" 
            DataKeyNames="name, description, cost">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="Pizza" SortExpression="name" />
                <asp:BoundField DataField="description" HeaderText="Toppings" 
                    SortExpression="description" />
                <asp:BoundField DataField="cost" HeaderText="Price" 
                    SortExpression="cost" DataFormatString="{0:c}"/>
                <asp:ButtonField ButtonType="Button" CommandName="AddPizza" 
                    Text="Add to order!" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="DatabasePizzas" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [pizzas]"></asp:SqlDataSource>
    </p>
    <p>
        <button id="checkout" onserverclick="OnCheckoutButton" runat="server">
            Go to Checkout</button>
    </p>
</asp:Content>

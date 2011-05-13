<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderPizza.aspx.cs" Inherits="AnderaPizzaCompany.OrderPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Order Pizza
    </h2>
    <p>
        Current order:
        <br />
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
    </p>
    <p>
        Choose which pizza to add to your order:
        <asp:GridView ID="PizzasGridView" runat="server" 
            AutoGenerateColumns="False" DataSourceID="DatabasePizzas"
            OnRowCommand="PizzasGridView_RowCommand" 
            DataKeyNames="name,description,cost" BackColor="White" 
            BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="Pizza" SortExpression="name" />
                <asp:BoundField DataField="description" HeaderText="Toppings" 
                    SortExpression="description" />
                <asp:BoundField DataField="cost" HeaderText="Price" 
                    SortExpression="cost" DataFormatString="{0:c}"/>
                <asp:ButtonField ButtonType="Button" CommandName="AddPizza" 
                    Text="Add to order!" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <asp:SqlDataSource ID="DatabasePizzas" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [pizzas]"></asp:SqlDataSource>
    </p>
    <p>
        <button id="checkout" onserverclick="OnCheckoutButton" runat="server">
            Go to Checkout</button>
        <button id="cancel" onserverclick="Cancel" runat="server">
            Cancel Order</button>
    </p>
</asp:Content>

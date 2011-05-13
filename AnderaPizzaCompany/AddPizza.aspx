<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPizza.aspx.cs" Inherits="AnderaPizzaCompany.AddPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Add a Pizza to your order
    </h2>
    <p>
        <asp:CheckBox Text="Broccoli" runat="server" id="checkbox_broccoli"/>
        <asp:GridView ID="ToppingsGridView" runat="server" AutoGenerateColumns="False" 
            DataSourceID="Database" DataKeyNames="topping, cost">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="ToppingSelector" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="topping" HeaderText="Topping" 
                    SortExpression="topping" />
                <asp:BoundField DataField="cost" HeaderText="Cost" SortExpression="cost" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Database" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [toppings]"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Button Text="Add Pizza to Order" runat="server" onclick="Submit"/>
    </p>
</asp:Content>

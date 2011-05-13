<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPizza.aspx.cs" Inherits="AnderaPizzaCompany.AddPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Choose your extra toppings
    </h2>
    <h3>
        Pizza: <asp:Label ID="PizzaLabel" runat="server" Text="Label"></asp:Label>
    </h3>
    <p>
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
                <asp:BoundField DataField="cost" HeaderText="Cost" 
                SortExpression="cost" DataFormatString="{0:c}"/>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Database" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [toppings]"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Button Text="Add Pizza to Order" runat="server" onclick="Submit"/>
        <asp:Button Text="Cancel" runat="server" onclick="Cancel"/>
    </p>
</asp:Content>

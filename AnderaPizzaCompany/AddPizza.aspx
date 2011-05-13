<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPizza.aspx.cs" Inherits="AnderaPizzaCompany.AddPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Add extra toppings
    </h2>
    <h3>
        Pizza: <asp:Label ID="PizzaLabel" runat="server" Text="Label"></asp:Label>
    </h3>
    <p>
        Want extra toppings? Check below to add a topping to your pizza
        <asp:GridView ID="ToppingsGridView" runat="server" AutoGenerateColumns="False" 
            DataSourceID="Database" DataKeyNames="topping,cost" CellPadding="4" 
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
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
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="Restaurant.Inventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Value="Food" Selected="True">Food</asp:ListItem>
            <asp:ListItem Value="Beverage">Beverage</asp:ListItem>
            <asp:ListItem Value="Ingredient">Ingredient</asp:ListItem>
        </asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id" HeaderText ="Stock ID" />
                <asp:BoundField DataField="Name" HeaderText ="NAME" />
                <asp:BoundField DataField="Left Stock" HeaderText ="Left Stock" />
                <asp:BoundField DataField="Min Stock" HeaderText ="Min Stock" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

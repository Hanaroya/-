<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="Restaurant.Purchase" %>

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
        <asp:Label ID="Label1" runat="server" Text="Item Purchase"></asp:Label>
        &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="Food" Selected="True">Food</asp:ListItem>
            <asp:ListItem Value="Beverage">Beverage</asp:ListItem>
            <asp:ListItem Value="Ingredient">Ingredient</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Item Name:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="item_name" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="item_warning" Visible="false" runat="server" ForeColor="Red" Text="*Input the item name"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Quantity:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="quantity_text" runat="server" Style="text-align: right" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
        lbs<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="quantity_warning" Visible="false" runat="server" ForeColor="Red" Text="*Input the quantity of item"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Price:" ></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;$
        <asp:TextBox ID="price_text" runat="server" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="price_warning" Visible="false" runat="server" ForeColor="Red" Text="*Input the price of item"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Seller's Email:"></asp:Label>
        &nbsp; &nbsp;
        <asp:TextBox ID="email_text" runat="server" TextMode="Email"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="email_warning" Visible="false" runat="server" ForeColor="Red" Text="*Input the Seller's email address"></asp:Label>
        <br />
        <p>
        <asp:Button ID="Button1" runat="server" Text="Purchase" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>

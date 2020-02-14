<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="CalendarTest.CalendarSample1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:85%; margin: 0 auto;">
            <h3 style="margin-left: 160px; width: 507px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reservation</h3>
            <br />
            First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            Last Name<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Email Address<br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" Font-Italic="True" 
                TitleStyle-BackColor="PeachPuff" Height="250px" Width="330px" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" NextPrevFormat="ShortMonth">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <DayStyle BackColor="#CCCCCC" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
<TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt"></TitleStyle>
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
            </asp:Calendar>
           
            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox>
            <br />
            <br />
            
            Select Lunch or Dinner <asp:DropDownList ID="DropDownList2" AutoPostBack="true" runat="server" 
            OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="None" Selected="True">None</asp:ListItem>
                <asp:ListItem Value="Lunch">Lunch</asp:ListItem>
                <asp:ListItem Value="Dinner">Dinner</asp:ListItem>
            </asp:DropDownList>
            
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" AutoPostBack="false" Visible="false" runat="server">
                <asp:ListItem Text="11:00AM" Value="Lunch1"></asp:ListItem>
                <asp:ListItem Text="11:30AM" Value="Lunch2"></asp:ListItem>
                <asp:ListItem Text="12:00PM" Value="Lunch3"></asp:ListItem>
                <asp:ListItem Text="12:30PM" Value="Lunch4"></asp:ListItem>
                <asp:ListItem Text="01:00PM" Value="Lunch5"></asp:ListItem>
                <asp:ListItem Text="01:30PM" Value="Lunch6"></asp:ListItem>
                <asp:ListItem Text="02:00PM" Value="Lunch7"></asp:ListItem>
                <asp:ListItem Text="02:30PM" Value="Lunch8"></asp:ListItem>
                <asp:ListItem Text="03:00PM" Value="Lunch9"></asp:ListItem>
                <asp:ListItem Text="03:30PM" Value="Lunch10"></asp:ListItem>
                <asp:ListItem Text="04:00PM" Value="Lunch11"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:RadioButtonList ID="RadioButtonList2" AutoPostBack="false" Visible="false" runat="server">
                <asp:ListItem Text="05:00PM" Value="Dinner1"></asp:ListItem>
                <asp:ListItem Text="05:30PM" Value="Dinner2"></asp:ListItem>
                <asp:ListItem Text="06:00PM" Value="Dinner3"></asp:ListItem>
                <asp:ListItem Text="06:30PM" Value="Dinner4"></asp:ListItem>
                <asp:ListItem Text="07:00PM" Value="Dinner5"></asp:ListItem>
                <asp:ListItem Text="07:30PM" Value="Dinner6"></asp:ListItem>
                <asp:ListItem Text="08:00PM" Value="Dinner7"></asp:ListItem>
                <asp:ListItem Text="08:30PM" Value="Dinner8"></asp:ListItem>
            </asp:RadioButtonList>
            &nbsp;<br />

            How many people with you?<br />

            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox1_TextChanged" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
            <br />
            <asp:Label ID ="Label1" Visible ="false" ForeColor="Red" runat="server"></asp:Label>
            <br />
            <br />
            Table Recommendation for you
            
            <br />
            <br />

            <asp:ImageButton ID="T1"  AlternateText="1 1 4" ImageUrl="~/image/table.png" OnClick="T1_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T2"  AlternateText="2 1 4" ImageUrl="~/image/table.png" OnClick="T2_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T3"  AlternateText="3 1 4" ImageUrl="~/image/table.png" OnClick="T3_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T4"  AlternateText="4 1 4" ImageUrl="~/image/table.png" OnClick="T4_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T5"  AlternateText="5 1 4" ImageUrl="~/image/table.png" OnClick="T5_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T6"  AlternateText="6 1 4" ImageUrl="~/image/table.png" OnClick="T6_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T7"  AlternateText="7 1 4" ImageUrl="~/image/table.png" OnClick="T7_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T8"  AlternateText="8 1 4" ImageUrl="~/image/table.png" OnClick="T8_Click" runat="server" Height="76px" Width="77px" />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="T9"  AlternateText="1 2 4" ImageUrl="~/image/table.png" OnClick="T9_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T10"  AlternateText="2 2 4" ImageUrl="~/image/table.png" OnClick="T10_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T11"  AlternateText="3 2 4" ImageUrl="~/image/table.png" OnClick="T11_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T12"  AlternateText="4 2 4" ImageUrl="~/image/table.png" OnClick="T12_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T13"  AlternateText="5 2 4" ImageUrl="~/image/table.png" OnClick="T13_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T14"  AlternateText="6 2 4" ImageUrl="~/image/table.png" OnClick="T14_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T15"  AlternateText="7 2 4" ImageUrl="~/image/table.png" OnClick="T15_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T16"  AlternateText="8 2 4" ImageUrl="~/image/table.png" OnClick="T16_Click" runat="server" Height="76px" Width="77px" />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="T17"  AlternateText="1 3 4" ImageUrl="~/image/table.png" OnClick="T17_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T18"  AlternateText="2 3 4" ImageUrl="~/image/table.png" OnClick="T18_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T19"  AlternateText="3 3 4" ImageUrl="~/image/table.png" OnClick="T19_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T20"  AlternateText="4 3 4" ImageUrl="~/image/table.png" OnClick="T20_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T21"  AlternateText="5 3 4" ImageUrl="~/image/table.png" OnClick="T21_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T22"  AlternateText="6 3 4" ImageUrl="~/image/table.png" OnClick="T22_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T23"  AlternateText="7 3 4" ImageUrl="~/image/table.png" OnClick="T23_Click" runat="server" Height="76px" Width="77px" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="T24"  AlternateText="8 3 4" ImageUrl="~/image/table.png" OnClick="T24_Click" runat="server" Height="76px" Width="77px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" style="margin-left: 121px" Text="Submit Reservation" OnClick="Button1_Click" />
            <br />
        </div>
            
        <br />
    </form>
</body>
</html>

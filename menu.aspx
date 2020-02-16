<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Restaurant.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>International Restaurant</title>

    <!--Linking the css and bootstrap stylesheet-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link href="css/menu.css" rel="stylesheet" />

</head>
<body>
    <!--Left Layout-->
    <div class="left-layout">
        <!--Menu Background Layout-->
        <div class="menu-layout">
            <!--Menu Name Layout-->
            <div class="title-layout">
                <h6><b>International</b></h6>
                <h6><b>Restaurant</b></h6>
            </div>
            <!--End of Menu Name Layout-->

            <!--Main Topics Layout-->
            <div class="topics-layout">
                <ul>
                    <li style="background-color: white"><a href="menu.aspx" style="color:black">MENU</a></li>
                    <li><a href="reservation.aspx">RESERVATION</a></li>
                    <li><a href="info.aspx">INFO</a></li>
                    <li><a href="login.aspx">LOGIN</a></li>
                    <li><a href="">FEEDBACK</a></li>
                </ul>
            </div>
            <!--End of Main Topics Layout-->
        </div>
        <!--End of Menu Background Layout-->
    </div>
    <!--End of Left Layout-->

    <!--Right Layout-->
    <div class="right-layout">
        <!--Menu Background Layout-->
        <div class="menu-display">
            <!--Menu Layout-->
            <div class="menu-title">
                <h3><b>menus</b></h3>
                <h4></h4>
                <h6><i>Choose from one of our menus</i></h6>
            </div>
            <!--End of Menu Layout-->

            <!-- Layout-->
            <div class="menu-list">
                <ul>
                    <li><a href="appetizers.aspx">Appetizers</a></li>
                    <li><a href="lunch.aspx">Lunch</a></li>
                    <li><a href="dinner.aspx">Dinner</a></li>
                    <li><a href="special.aspx">Specials</a></li>                    
                </ul>
            </div>
        </div>
        <!--End of Main Background Layout-->
    </div>    
    <!--End of Right Layout-->
</body>
</html>


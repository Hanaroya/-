<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Restaurant.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>International Restaurant</title>

    <!--Linking the css and bootstrap stylesheet-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link href="css/home.css" rel="stylesheet" />

</head>
<body>
    <!--Main Box Layout-->
    <div class="boxes">
        <!--Upper Box Layout-->
        <div class="card-layout-top">
            <div class="upper-layout">
                <h6>INTERNATIONAL RESTAURANT</h6>
                <h6>-BANQUET-</h6>
            </div>
            <div class="lower-layout">
                <h6><i>Banquet</i></h6>
                <h6><i>8000 Brookings</i></h6>
                <h6><i>South Dakota</i></h6>
            </div>        
        </div>
        <!--End of Upper Box Layout-->

        <!--Bottom Left Box Layout-->
        <div class="card-layout-bottom-left">
            <div class="upper-layout">
                <h6><b><a href="menu.aspx">Menu</a></b></h6>
                <h6><b>~~</b></h6>
            </div>
            <div class="lower-layout">
                <h6><i><b>Choose from a</b></i></h6>
                <h6><i><b>variety of cuisine.</b></i></h6>
            </div>        
        </div>
        <!--End of Bottom Left Box Layout-->

        <!--Bottom Middle Box Layout-->
        <div class="card-layout-bottom-middle">
            <div class="upper-layout">
                <h6><b><a href="Reservation.aspx">Reservation</a></b></h6>
                <h6><b>~~</b></h6>
            </div>
            <div class="lower-layout">
                <h6><i><b>Reserve a seat</b></i></h6>
                <h6><i><b>at ur convenience.</b></i></h6>
            </div>     
        </div>
        <!--End of Bottom Middle Box Layout-->

        <!--Bottom Right Box Layout-->
        <div class="card-layout-bottom-right">
            <div class="upper-layout">
                <h6><b>Feedback</b></h6>
                <h6><b>~~</b></h6>
            </div>
            <div class="lower-layout">
                <h6><i><b>Banquet</b></i></h6>
                <h6><i><b>8000 Brookings</b></i></h6>
            </div>     
        </div>
        <!--End of Bottom Left Box Layout-->
    </div>
    <!--End of Main Box Layout-->
</body>
</html>


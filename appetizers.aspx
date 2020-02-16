<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="appetizers.aspx.cs" Inherits="Restaurant.appetizers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>International Restaurant</title>

    <!--Linking the css and bootstrap stylesheet-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link href="css/appetizers.css" rel="stylesheet" />
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
                    <li style="background-color: white"><a href="appetizers.aspx" style="color:black">APPETIZERS</a></li>
                    <li><a href="lunch.aspx">LUNCH</a></li>
                    <li><a href="dinner.aspx">DINNER</a></li>
                    <li><a href="special.aspx">SPECIALS</a></li>
                    <li><a href="reservation.aspx">RESERVATION</a></li>
                </ul>
            </div>
            <!--End of Main Topics Layout-->
        </div>
        <!--End of Menu Background Layout-->
    </div>
    <!--End of Left Layout-->

    <!--Right Layout-->
    <div class="right-layout">
        <!--Info Layout-->
        <div class="info">
            <!--Info Name Layout-->
            <div class="info-name">
                <h3><b>Appetizers</b></h3>
                <h4></h4>
            </div>
            <!--End of Info Name Layout-->

            <!--Info details Layout-->
            <div class="info-details">
                <!--Display Menu Items-->
                <div class="card">
                    <img class="card-img-top" src="Images/mozz_sticks.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Mozzarella Sticks {$8}</b></p>
                    </div>
                </div>

                 <div class="card">
                    <img class="card-img-top" src="Images/chips_salsa.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Chips and Salsa {$8}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/chk_wings.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Chicken Wings {$9}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/chk_strips.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Chicken Strips {$10}</b></p>
                    </div>
                </div>        

                <div class="card">
                    <img class="card-img-top" src="Images/leche_tigre.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Leche de Tigre {$11}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/chk_tikka.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Chicken Tikka {$12}</b></p>
                    </div>
                </div>
                <!--End of Display Menu Items-->
            </div>
            <!--End of Info details Layout-->
        </div>
        <!--End of Info Layout-->
    </div>    
    <!--End of Right Layout-->
</body>
</html>

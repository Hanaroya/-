<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dinner.aspx.cs" Inherits="Restaurant.dinner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>International Restaurant</title>

    <!--Linking the css and bootstrap stylesheet-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link href="css/dinner.css" rel="stylesheet" />
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
                    <li><a href="appetizers.aspx">APPETIZERS</a></li>
                    <li><a href="lunch.aspx">LUNCH</a></li>
                    <li style="background-color: white"><a href="dinner.aspx" style="color:black">DINNER</a></li>
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
                <h3><b>Dinner Menu</b></h3>
                <h4></h4>
            </div>
            <!--End of Info Name Layout-->

            <!--Info details Layout-->
            <div class="info-details">
                <!--Display Menu Items-->
                <div class="card">
                    <img class="card-img-top" src="Images/s_avocado.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Southwest Avocado {$9}</b></p>
                    </div>
                </div>

                 <div class="card">
                    <img class="card-img-top" src="Images/chk_alfredo.jpg" alt="Card image cap">                                             
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Chicken Alfredo {$8}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/chk_biryani.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Chicken Biryani {$11}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/steak_pepper.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Steak and Pepper {$11}</b></p>
                    </div>
                </div>        

                <div class="card">
                    <img class="card-img-top" src="Images/bistecca.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Bistecca alla Fiorentina {$11}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/herb_pork.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Herbed Loin Pork {$12}</b></p>
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

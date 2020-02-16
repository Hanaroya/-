<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lunch.aspx.cs" Inherits="Restaurant.lunch" %>

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
                    <li><a href="appetizers.aspx">APPETIZERS</a></li>
                    <li style="background-color: white"><a href="lunch.aspx" style="color:black">LUNCH</a></li>
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
                <h3><b>Lunch Menu</b></h3>
                <h4></h4>
            </div>
            <!--End of Info Name Layout-->

            <!--Info details Layout-->
            <div class="info-details">
                <!--Display Menu Items-->
                <div class="card">
                    <img class="card-img-top" src="Images/mush_pasta.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Mushroom Pasta {$8}</b></p>
                    </div>
                </div>

                 <div class="card">
                    <img class="card-img-top" src="Images/burger.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>The Ultimate Burger {$8.70}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/chk_ceasar.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Chicken Caesar Salad {$9}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/arroz_con.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Arroz Con Pollo {$10}</b></p>
                    </div>
                </div>        

                <div class="card">
                    <img class="card-img-top" src="Images/butter_chk.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>Butter Chicken {$12}</b></p>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top" src="Images/herbed_fish.jpg" alt="Card image cap">
                    <div class="card-body">
                        <p class="card-text" style="color: black;"><b>The Herbed Fish {$13}</b></p>
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Restaurant.form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>International Restaurant</title>

    <!--Linking the css and bootstrap stylesheet-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link href="css/login.css" rel="stylesheet" />

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
                    <li><a href="menu.aspx">MENU</a></li>
                    <li><a href="">RESERVATION</a></li>
                    <li style="background-color: white"><a href="login.aspx" style="color:black">LOGIN</a></li>
                    <li><a href="">FEEDBACK</a></li>
                    <li><a href="info.aspx">INFO</a></li>
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
                <h3><b>Login</b></h3>
                <h4></h4>
            </div>
            <!--End of Info Name Layout-->

            <!--Info details Layout-->
            <div class="info-details">
                <!--Form details Layout-->
                <form id="form2" runat="server">
                    <h6>Enter Username</h6><asp:TextBox ID="TextBox1" runat="server" CssClass="textbox1"></asp:TextBox><br />
                    <h6>Enter Password</h6><asp:TextBox ID="TextBox2" runat="server" CssClass="textbox2"></asp:TextBox><br />
                    <div class="button">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" cssClass="btn btn-amber btn-lg"/>
                    </div>                    
                </form>
                <!--End of Form Layout-->

                <!--Sign-up Layout-->
                <div class="signup">
                    <h6>Need an account <a href="signup.aspx" style="color: springgreen;">SignUp</a> here.</h6>
                </div>
                <!--End of Sign-up Layout-->
            </div>
            <!--End of Info details Layout-->
        </div>
        <!--End of Info Layout-->
    </div>    
    <!--End of Right Layout-->
    
</body>
</html>

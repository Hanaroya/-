<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Restaurant.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>International Restaurant</title>

    <!--Linking the css and bootstrap stylesheet-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link href="css/signup.css" rel="stylesheet" />
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
                <h3><b>Sign Up</b></h3>
                <h4></h4>
            </div>
            <!--End of Info Name Layout-->

            <!--Info details Layout-->
            <div class="info-details">
                <!--Form details Layout-->
                    <form  id="form1" runat="server">
                        <div class="validate">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Please Enter the Username" CssClass="field-validation-error" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Please Enter the Name" CssClass="field-validation-error" Display="Dynamic" ></asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Please Enter the Email"  Display="Dynamic" CssClass="field-validation-error"></asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Please Select the Date"  Display="Dynamic" CssClass="field-validation-error"></asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Please Enter the Password"  Display="Dynamic" CssClass="field-validation-error"></asp:RequiredFieldValidator>
                            <asp:Label ID="Label1" runat="server" Display="Dynamic" style="color: indianred"></asp:Label><br />
                            <asp:Label ID="Label2" runat="server" ></asp:Label><br />
                        </div>
                        
                        <div class="form-data">
                            <h6>Enter Username: </h6><asp:TextBox ID="TextBox5" runat="server" CssClass="textbox1" ></asp:TextBox><br />
                            <h6>Enter Name: </h6><asp:TextBox ID="TextBox1" runat="server"  CssClass="textbox1" ></asp:TextBox><br />
                            <h6>Enter Email: </h6><asp:TextBox ID="TextBox2" runat="server" TextMode="Email" CssClass="textbox1" ></asp:TextBox><br />
                            <h6>Date of Birth: </h6><asp:TextBox ID="TextBox3" type="date" runat="server" CssClass="textbox1" ></asp:TextBox><br />
                            <h6>Enter Password: </h6><asp:TextBox ID="TextBox4" runat="server" TextMode="Password" CssClass="textbox1" ></asp:TextBox><br />
                            <div class="button">
                                <asp:Button ID="Button1"  runat="server" OnClick="Button1_Click" Text="SignUp"  CssClass="btn btn-mdb-color btn-lg"/>
                            </div>  
                        </div>
                        
                    </form>
                    
                    
                <!--End of Form Layout-->  

                <!--Sign-up Layout-->
                <div class="signup">
                    
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sales.aspx.cs" Inherits="Restaurant.sales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>International Restaurant</title>

    <!--Linking the css and bootstrap stylesheet-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <link href="css/sales.css" rel="stylesheet" />
</head>
<body>
    <!--Main Wrapper-->
    <div class="main-wrapper">
        <table class="table">
          <thead class="thead-dark">
            <tr>
              <th scope="col">Income</th>
              <th scope="col">Expense</th>
              <th scope="col">Sales</th>
              <th scope="col">Monthly</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope="row">$50000</th>
              <td>$30000</td>
              <td>$20000</td>
              <td>08/01/2018-09/01/2018</td>
            </tr>
            <tr>
              <th scope="row">$45000</th>
              <td>$25000</td>
              <td>$20000</td>
              <td>09/01/2018-10/01/2018</td>
            </tr>
            <tr>
              <th scope="row">$63400</th>
              <td>$30200</td>
              <td>$332000</td>
              <td>10/01/2018-11/01/2018</td>
            </tr>
            <tr>
              <th scope="row">$32000</th>
              <td>$12000</td>
              <td>$20000</td>
              <td>11/01/2018-12/01/2018</td>
            </tr>
          </tbody>
        </table>

    <!--End of Main Wrapper-->
</body>
</html>

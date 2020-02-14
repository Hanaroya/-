﻿@{

    Validation.RequireField("title", "You must enter a title");
    Validation.RequireField("genre", "Genre is required");
    Validation.RequireField("year", "You haven't entered a year");

    var title = "";
    var genre = "";
    var year = "";

    if(IsPost && Validation.IsValid()){
       title = Request.Form["title"];
       genre = Request.Form["genre"];
       year = Request.Form["year"];

       var db = Database.Open("WebPagesMovies");
       var insertCommand = "INSERT INTO Movies (Title, Genre, Year) Values(@0, @1, @2)";
       db.Execute(insertCommand, title, genre, year);
       Response.Redirect("~/Movies");
    }
}

<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8" />
<title>Add a Movie</title>
      <style type="text/css">
    .field-validation-error {
      font-weight:bold;
      color:red;
      background-color:yellow;
     }
    .validation-summary-errors{
      border:2px dashed red;
      color:red;
      background-color:yellow;
      font-weight:bold;
      margin:12px;
    }
  </style>
</head>
<body>
  <h1>Add a Movie</h1>
  @Html.ValidationSummary()
  <form method="post">
    <fieldset>
      <legend>Movie Information</legend>
      <p><label for="title">Title:</label>
         <input type="text" name="title" value="@Request.Form["title"]" />
          @Html.ValidationMessage("title")
      </p>

      <p><label for="genre">Genre:</label>
         <input type="text" name="genre" value="@Request.Form["genre"]" />
         @Html.ValidationMessage("genre")
      </p>

      <p><label for="year">Year:</label>
         <input type="text" name="year" value="@Request.Form["year"]" />
          @Html.ValidationMessage("year")
      </p>

      <p><input type="submit" name="buttonSubmit" value="Add Movie" /></p>
    </fieldset>
  </form>
</body>
</html>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant
{
    public partial class test : System.Web.UI.Page
    {
        string dbconnection = "Server=localhost;Database=restaurant;user=root;password=";

        protected void Submitbtn(object sender, EventArgs e)
        {
            var uname = Request.Form["name"];
            var uemail =Request.Form["email"];
            var ufeed = Request.Form["desc"];

            //var db = Database.Open("restaurant");
            var insertCommand = "Insert into feedback(name,email,des) values(@0,@1,@2)";
            //db.Execute(insertCommand, uname, uemail, ufeed);

            MySqlConnection connection = new MySqlConnection(dbconnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Insert into feedback(name,email,desc) values(@uname,@uemail,@ufeed)";
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }

        }
    }
}
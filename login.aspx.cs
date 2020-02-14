using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Restaurant
{
    public partial class form : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=SANIL\\MSSQLSERVER01;Initial Catalog=restaurant;Integrated Security=True";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert into log (name,pass) values('"+TextBox1.Text+"','"+TextBox2.Text+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();      
        }
    }
}
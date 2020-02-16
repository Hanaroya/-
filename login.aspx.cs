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
    public partial class login : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlCommand ad = new SqlCommand();
        SqlCommand emp = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-9K2E0REO;Initial Catalog=Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            bool exists = false;
            bool admin = false;
            bool employee = false;

            cmd.CommandText = "Select count(*) from signup where username=@username and password=@password";
            ad.CommandText = "Select count(*) from adminlogin where username=@username and password=@password";
            emp.CommandText = "Select count(*) from emplogin where username=@username and password=@password";

            cmd.Connection = con;
            ad.Connection = con;
            emp.Connection = con;
            cmd.Parameters.AddWithValue("username", TextBox1.Text);
            cmd.Parameters.AddWithValue("password", TextBox2.Text);
            ad.Parameters.AddWithValue("username", TextBox1.Text);
            ad.Parameters.AddWithValue("password", TextBox2.Text);
            emp.Parameters.AddWithValue("username", TextBox1.Text);
            emp.Parameters.AddWithValue("password", TextBox2.Text);
            exists = (int)cmd.ExecuteScalar() > 0;
            admin = (int)ad.ExecuteScalar() > 0;
            employee = (int)emp.ExecuteScalar() > 0;

            if (exists)
            {
                Session["uname"] = TextBox1.Text;
                Response.Redirect("loginsuccess.aspx");

            }

            else
            {
                Label1.Visible = true;
                Label1.Text = "*Entered Username or Password is incorrect! ";
                Label1.ForeColor = System.Drawing.Color.Aqua;
            }

            if(admin)
            {
                Session["adname"] = TextBox1.Text;
                Response.Redirect("admincontrol.aspx");
            }

            else
            {
                Label1.Visible = true;
                Label1.Text = "*Entered Username or Password is incorrect! ";
                Label1.ForeColor = System.Drawing.Color.Aqua;
            }

            if (employee)
            {
                Session["empname"] = TextBox1.Text;
                Response.Redirect("loginsuccess");
            }

            else
            {
                Label1.Visible = true;
                Label1.Text = "*Entered Username or Password is incorrect! ";
                Label1.ForeColor = System.Drawing.Color.Aqua;
            }
        }
    }
}
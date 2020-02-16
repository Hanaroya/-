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
    public partial class signup : System.Web.UI.Page
    {
        SqlCommand chk = new SqlCommand();
        SqlCommand ins = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=SANIL\\MSSQLSERVER01;Initial Catalog=restaurant;Integrated Security=True;MultipleActiveResultSets=true";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            bool exists = false;

            //Inserting into Database SignUp details.    
            
            //Retrieving from SignUp Table to check username exists or not. 
            chk.CommandText = "Select count(*) from signup where username=@username";            
            chk.Connection = con;
            chk.Parameters.AddWithValue("username",TextBox5.Text);
            exists = (int)chk.ExecuteScalar() > 0;
            
            if(exists)
            {
                Label1.Visible = true;
                Label1.Text = "*Invalid Password Format";
                Label1.ForeColor = System.Drawing.Color.Aqua;                                        
            }

            else
            {
                ins.CommandText = "Insert into signup (username,name,email,dob,password) values(@username,@name,@email,@dob,@password)";
                ins.Connection = con;
                ins.Parameters.AddWithValue("username", TextBox5.Text);
                ins.Parameters.AddWithValue("name", TextBox1.Text);
                ins.Parameters.AddWithValue("email", TextBox2.Text);
                ins.Parameters.AddWithValue("dob", TextBox3.Text);
                ins.Parameters.AddWithValue("password", TextBox4.Text);
                ins.ExecuteNonQuery();

                Response.Redirect("");

            }

            con.Close();
            

        }
    }
}
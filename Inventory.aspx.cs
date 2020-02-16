using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Xml.Linq;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;

namespace Restaurant
{
    public partial class Inventory : System.Web.UI.Page
    {
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            string database_location = "Data Source=LAPTOP-9K2E0REO;Initial Catalog=Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection
            {
                ConnectionString = database_location
            };
            con.Open();
            SqlDataAdapter ad;
            DataTable dt = new DataTable();
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    ad = new SqlDataAdapter("SELECT * FROM InvFood", con);
                    ad.Fill(dt);
                    break;
                case 1:
                    ad = new SqlDataAdapter("SELECT * FROM InvBeverage", con);
                    ad.Fill(dt);
                    break;
                case 2:
                    ad = new SqlDataAdapter("SELECT * FROM InvIngredient", con);
                    ad.Fill(dt);
                    break;
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter ad;
            DataTable dt = new DataTable();
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    ad = new SqlDataAdapter("SELECT * FROM InvFood", con);
                    ad.Fill(dt);
                    break;
                case 1:
                    ad = new SqlDataAdapter("SELECT * FROM InvBeverage", con);
                    ad.Fill(dt);
                    break;
                case 2:
                    ad = new SqlDataAdapter("SELECT * FROM InvIngredient", con);
                    ad.Fill(dt);
                    break;
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
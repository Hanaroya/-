using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalendarTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string reserved_name = (String)Session["Reservation_confirm"];
            string reserved_detail = (String)Session["Reservation_detail"];

            string special_discount = (String)Session["Special_discount"];

            if (string.IsNullOrEmpty(special_discount) == false)
            {
                confirm_3.Text = special_discount + " Special discount applied";
                confirm_3.Visible = true;
            }

            confirm_1.Text = reserved_name;
            confirm_2.Text = reserved_detail;
        }
    }
}
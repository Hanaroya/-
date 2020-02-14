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


namespace CalendarTest
{
    public partial class CalendarSample1 : System.Web.UI.Page
    {
        private TextBox table_selected = new TextBox();
        private TextBox time = new TextBox();
        static int people_number;
        static Queue<string> table_id = new Queue<string>();
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            string database_location = "data source = LAPTOP-9K2E0REO; database = Restaurant; integrated security=SSPI";
            con = new SqlConnection
            {
                ConnectionString = database_location
            };
            con.Open();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Calendar1.SelectionMode = (CalendarSelectionMode)1;
            switch (Calendar1.SelectedDates.Count)
            {
                case (1):
                    TextBox1.Text = Calendar1.SelectedDate.DayOfWeek.ToString() +", " 
                        + Calendar1.SelectedDate.Month + "/" + Calendar1.SelectedDate.Day.ToString();
                    break;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            people_number = Convert.ToInt32(TextBox6.Text);
            int rem;
            if(people_number > 20)
            {
                TextBox6.Text = "";
                Label1.Text = "You need to contact with Administrator for larger than 20 people";
                Label1.Visible = true;
            }
            else
            {
                if(Label1.Visible == true)
                {
                    Label1.Visible = false;
                    Label1.Text = "";
                }
                rem = people_number % 4;
                if(rem == 0)
                {
                    people_number = people_number / 4;
                }
                else
                {
                    people_number = (people_number / 4) + 1;
                }
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList2.SelectedIndex)
            {
                case 1:
                    RadioButtonList1.Visible = true;
                    RadioButtonList2.Visible = false;
                    break;
                case 2:
                    RadioButtonList2.Visible = true;
                    RadioButtonList1.Visible = false;
                    break;
                default:
                    RadioButtonList1.Visible = false;
                    RadioButtonList2.Visible = false;
                    break;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.Visible == true)
            {
                time.Text = RadioButtonList1.SelectedItem.Text;
            }
            else if(RadioButtonList2.Visible == true)
            {
                time.Text = RadioButtonList2.SelectedItem.Text;
            }

            if(T1.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T1.ID;
            }
            else if (T2.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T2.ID;
            }
            else if (T3.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T3.ID;
            }
            else if (T4.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T4.ID;
            }
            else if (T5.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T5.ID;
            }
            else if (T6.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T6.ID;
            }
            else if (T7.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T7.ID;
            }
            else if (T8.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T8.ID;
            }
            else if (T9.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T9.ID;
            }
            else if (T10.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T10.ID;
            }
            else if (T11.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T11.ID;
            }
            else if (T12.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T12.ID;
            }
            else if (T13.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T13.ID;
            }
            else if (T14.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T14.ID;
            }
            else if (T15.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T15.ID;
            }
            else if (T16.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T16.ID;
            }
            else if (T17.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T17.ID;
            }
            else if (T18.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T18.ID;
            }
            else if (T19.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T19.ID;
            }
            else if (T20.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T20.ID;
            }
            else if (T21.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T21.ID;
            }
            else if (T22.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T22.ID;
            }
            else if (T23.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T23.ID;
            }
            else if (T24.ImageUrl.CompareTo("/image/table_selected.png") == 0)
            {
                table_selected.Text = T24.ID;
            }
            SqlCommand cmd = new SqlCommand("RESERVATION_ADD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", TextBox2.Text);
            cmd.Parameters.AddWithValue("@LastName", TextBox3.Text);
            cmd.Parameters.AddWithValue("@phone_number", TextBox4.Text);
            cmd.Parameters.AddWithValue("@email_address", TextBox5.Text);
            cmd.Parameters.AddWithValue("@people_num", Convert.ToInt32(TextBox6.Text));
            cmd.Parameters.AddWithValue("@selected_table", table_selected.Text);
            cmd.Parameters.AddWithValue("@reservation_date", TextBox1.Text);
            cmd.Parameters.AddWithValue("@reservation_time", time.Text);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Your Reservation is successful');</script>");
            Response.Redirect("Reservation_confirm.aspx");
            Clear_data();
        }

        protected void Clear_data()
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = table_selected.Text = time.Text = "";
            Deselect_table(25);
        }

        protected void Deselect_table(int s)
        {
            switch (s)
            {
                case 1:
                    T1.ImageUrl = "/image/table.png";
                    break;
                case 2:
                    T2.ImageUrl = "/image/table.png";
                    break;
                case 3:
                    T3.ImageUrl = "/image/table.png";
                    break;
                case 4:
                    T4.ImageUrl = "/image/table.png";
                    break;
                case 5:
                    T5.ImageUrl = "/image/table.png";
                    break;
                case 6:
                    T6.ImageUrl = "/image/table.png";
                    break;
                case 7:
                    T7.ImageUrl = "/image/table.png";
                    break;
                case 8:
                    T8.ImageUrl = "/image/table.png";
                    break;
                case 9:
                    T9.ImageUrl = "/image/table.png";
                    break;
                case 10:
                    T10.ImageUrl = "/image/table.png";
                    break;
                case 11:
                    T11.ImageUrl = "/image/table.png";
                    break;
                case 12:
                    T12.ImageUrl = "/image/table.png";
                    break;
                case 13:
                    T13.ImageUrl = "/image/table.png";
                    break;
                case 14:
                    T14.ImageUrl = "/image/table.png";
                    break;
                case 15:
                    T15.ImageUrl = "/image/table.png";
                    break;
                case 16:
                    T16.ImageUrl = "/image/table.png";
                    break;
                case 17:
                    T17.ImageUrl = "/image/table.png";
                    break;
                case 18:
                    T18.ImageUrl = "/image/table.png";
                    break;
                case 19:
                    T19.ImageUrl = "/image/table.png";
                    break;
                case 20:
                    T20.ImageUrl = "/image/table.png";
                    break;
                case 21:
                    T21.ImageUrl = "/image/table.png";
                    break;
                case 22:
                    T22.ImageUrl = "/image/table.png";
                    break;
                case 23:
                    T23.ImageUrl = "/image/table.png";
                    break;
                case 24:
                    T24.ImageUrl = "/image/table.png";
                    break;
                case 25:
                    T2.ImageUrl = "/image/table.png";
                    T3.ImageUrl = "/image/table.png";
                    T4.ImageUrl = "/image/table.png";
                    T5.ImageUrl = "/image/table.png";
                    T6.ImageUrl = "/image/table.png";
                    T7.ImageUrl = "/image/table.png";
                    T8.ImageUrl = "/image/table.png";
                    T9.ImageUrl = "/image/table.png";
                    T10.ImageUrl = "/image/table.png";
                    T11.ImageUrl = "/image/table.png";
                    T12.ImageUrl = "/image/table.png";
                    T13.ImageUrl = "/image/table.png";
                    T14.ImageUrl = "/image/table.png";
                    T15.ImageUrl = "/image/table.png";
                    T16.ImageUrl = "/image/table.png";
                    T17.ImageUrl = "/image/table.png";
                    T18.ImageUrl = "/image/table.png";
                    T19.ImageUrl = "/image/table.png";
                    T20.ImageUrl = "/image/table.png";
                    T21.ImageUrl = "/image/table.png";
                    T22.ImageUrl = "/image/table.png";
                    T23.ImageUrl = "/image/table.png";
                    T24.ImageUrl = "/image/table,png";
                    T1.ImageUrl = "/image/table.png";
                    break;
            }
        }

        protected void T1_Click(object sender, EventArgs e)
        {
            if(people_number > 0)
            {
                table_id.Enqueue(T1.ID);
                T1.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if(people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T1.ID);
                T1.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T2_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T2.ID);
                T2.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T2.ID);
                T2.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T3_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T3.ID);
                T3.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T3.ID);
                T3.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T4_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T4.ID);
                T4.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T4.ID);
                T4.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T5_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T5.ID);
                T5.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T5.ID);
                T5.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T6_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T6.ID);
                T6.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T6.ID);
                T6.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T7_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T7.ID);
                T7.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T7.ID);
                T7.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T8_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T8.ID);
                T8.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T8.ID);
                T8.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T9_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T9.ID);
                T9.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T9.ID);
                T9.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T10_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T10.ID);
                T10.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T10.ID);
                T10.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T11_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T11.ID);
                T11.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T11.ID);
                T11.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T12_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T12.ID);
                T12.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T12.ID);
                T12.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T13_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T13.ID);
                T13.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T13.ID);
                T13.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T14_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T14.ID);
                T14.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T14.ID);
                T14.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T15_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T15.ID);
                T15.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T15.ID);
                T15.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T16_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T16.ID);
                T16.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T16.ID);
                T16.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T17_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T17.ID);
                T17.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T17.ID);
                T17.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T18_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T18.ID);
                T18.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T18.ID);
                T18.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T19_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T19.ID);
                T19.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T19.ID);
                T19.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T20_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T20.ID);
                T20.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T20.ID);
                T20.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T21_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T21.ID);
                T21.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T21.ID);
                T21.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T22_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T22.ID);
                T22.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T22.ID);
                T22.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T23_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T23.ID);
                T23.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T23.ID);
                T23.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void T24_Click(object sender, EventArgs e)
        {
            if (people_number > 0)
            {
                table_id.Enqueue(T24.ID);
                T24.ImageUrl = "/image/table_selected.png";
                people_number -= 1;
            }
            else if (people_number == 0)
            {
                Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                table_id.Enqueue(T24.ID);
                T24.ImageUrl = "/image/table_selected.png";
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime pastday = e.Day.Date;
            DateTime date = DateTime.Now;

            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            DateTime today = new DateTime(year, month, day);

            if(pastday.CompareTo(today) < 0)
            {
                e.Cell.BackColor = System.Drawing.Color.Gray;
                e.Day.IsSelectable = false;
            }

        }
    }
}
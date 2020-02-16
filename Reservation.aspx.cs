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


namespace CalendarTest
{
    public partial class CalendarSample1 : System.Web.UI.Page
    {
        private TextBox table_selected = new TextBox();
        private TextBox time = new TextBox();
        static int people_number;
        static string user_name;
        static Queue<string> table_id = new Queue<string>();
        static bool first_up = false;
        static bool login_check = false;
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            int table_count = 0;
            string database_location = "Data Source=LAPTOP-9K2E0REO;Initial Catalog=Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection
            {
                ConnectionString = database_location
            };
            con.Open();
            
            if (check_table_exist("T1") == true)
            {
                T1.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T2") == true)
            {
                T2.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T3") == true)
            {
                T3.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T4") == true)
            {
                T4.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T5") == true)
            {
                T5.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T6") == true)
            {
                T6.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T7") == true)
            {
                T7.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T8") == true)
            {
                T8.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T9") == true)
            {
                T9.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T10") == true)
            {
                T10.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T11") == true)
            {
                T11.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T12") == true)
            {
                T12.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T13") == true)
            {
                T13.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T14") == true)
            {
                T14.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T15") == true)
            {
                T15.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T16") == true)
            {
                T16.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T17") == true)
            {
                T17.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T18") == true)
            {
                T18.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T19") == true)
            {
                T19.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T20") == true)
            {
                T20.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T21") == true)
            {
                T21.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T22") == true)
            {
                T22.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T23") == true)
            {
                T23.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }
            if (check_table_exist("T24") == true)
            {
                T24.ImageUrl = "~/Images/table_unavailable.png";
                table_count++;
            }

            if(table_count > 11)
            {
                Session["Reservation_confirm"] = "Sorry no longer reservation available";
                Session["Reservation_detail"] = "";
                Response.Redirect("Reservation_confirm.aspx");
            }

            user_name = (string)Session["uname"];
  
            if(string.IsNullOrEmpty(user_name) != true && first_up == false)
            {
                first_up = true;
                login_check = true;
                if (check_table_exist("T1") == false)
                {
                    T1.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T2") == false)
                {
                    T2.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T3") == false)
                {
                    T3.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T4") == false)
                {
                    T4.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T5") == false)
                {
                    T5.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T6") == false)
                {
                    T6.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T7") == false)
                {
                    T7.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T12") == false)
                {
                    T12.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T13") == false)
                {
                    T13.ImageUrl = "~/Images/table_suggestion.png";
                }
                if (check_table_exist("T18") == false)
                {
                    T18.ImageUrl = "~/Images/table_suggestion.png";
                }
            }
        }

        protected bool check_table_exist(string t)
        {
            string str = "select count(*) from reservation where selected_table=@search";
            SqlCommand tb = new SqlCommand(str, con);
            tb.Parameters.Add("@search", SqlDbType.VarChar).Value = t;

            bool exists = (int)tb.ExecuteScalar() > 0;

            return exists;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Calendar1.SelectionMode = (CalendarSelectionMode)1;
            switch (Calendar1.SelectedDates.Count)
            {
                case (1):
                    Date_text.Text = Calendar1.SelectedDate.DayOfWeek.ToString() +", " 
                        + Calendar1.SelectedDate.Month + "/" + Calendar1.SelectedDate.Day.ToString();
                    break;
            }
        }

        protected void First_text_TextChanged(object sender, EventArgs e)
        {
            if (First_warning.Visible == true)
            {
                First_warning.Visible = false;
                First_warning.Text = "";
            }    
        }

        protected void Last_text_TextChanged(object sender, EventArgs e)
        {
            if (Last_warning.Visible == true)
            {
                Last_warning.Visible = false;
                Last_warning.Text = "";
            }
        }

        protected void Phone_text_TextChanged(object sender, EventArgs e)
        {
            if (Phone_warning.Visible == true)
            {
                Phone_warning.Visible = false;
                Phone_warning.Text = "";
            }
        }

        protected void Email_text_TextChanged(object sender, EventArgs e)
        {
            if (Email_warning.Visible == true)
            {
                Email_warning.Visible = false;
                Email_warning.Text = "";
            }
        }

        protected void Cardnum_text_TextChanged(object sender, EventArgs e)
        {
            if (Card_warning.Visible == true)
            {
                Card_warning.Visible = false;
                Card_warning.Text = "";
            }
        }

        protected void Date_text_TextChanged(object sender, EventArgs e)
        {
            if (Date_warning.Visible == true)
            {
                Date_warning.Visible = false;
                Date_warning.Text = "";
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Time_warning.Visible == true)
            {
                Time_warning.Visible = false;
                Time_warning.Text = "";
            }
        }

        protected void Peoplenum_text_TextChanged(object sender, EventArgs e)
        {
            people_number = 0;
            people_number = Convert.ToInt32(Peoplenum_text.Text);
            int rem;
            if(people_number > 20)
            {
                Peoplenum_text.Text = "";
                people_number = 0;
            }
            else
            {
                if(Peoplenum_warning.Visible == true)
                {
                    Peoplenum_warning.Visible = false;
                    Peoplenum_warning.Text = "";
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
                if(table_id.Count > 0)
                {
                    while (table_id.Count > 0)
                    {
                        Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    }
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
            bool first = true, last = true, phone = true, card_num = false, email = true, p_num = true, s_table = true, date = true, time_b = true, mail_check = false;
     
            if (RadioButtonList1.Visible == true)
            {
                time.Text = RadioButtonList1.SelectedItem.Text;
            }
            else if (RadioButtonList2.Visible == true)
            {
                time.Text = RadioButtonList2.SelectedItem.Text;
            }

            if (string.IsNullOrEmpty(First_text.Text) == true)
            {
                First_warning.Text = "*Please enter your first name";
                First_warning.Visible = true;
                first = false;
            }
            if (string.IsNullOrEmpty(Last_text.Text) == true)
            {
                Last_warning.Text = "*Please enter your last name";
                Last_warning.Visible = true;
                last = false;
            }
            if (string.IsNullOrEmpty(Phone_text.Text) == true)
            {
                Phone_warning.Text = "*Please enter your Phone number";
                Phone_warning.Visible = true;
                phone = false;
            }
            if (string.IsNullOrEmpty(Email_text.Text) == true)
            {
                Email_warning.Text = "*Please enter your Email";
                Email_warning.Visible = true;
                email = false;
            }
            if (string.IsNullOrEmpty(Peoplenum_text.Text) == true)
            {
                Peoplenum_warning.Text = "*Please enter a number";
                Peoplenum_warning.Visible = true;
                p_num = false;
            }
            else if (people_number > 20)
            {
                Peoplenum_warning.Text = "*Contact manager if more than 20 people";
                Peoplenum_warning.Visible = true;
                p_num = false;
            }
            if (table_id.Count == 0 && people_number > 0)
            {
                Tb_warning.Text = "*Please select table";
                Tb_warning.Visible = true;
                s_table = false;
            }
            if (string.IsNullOrEmpty(Date_text.Text) == true)
            {
                Date_warning.Text = "*Please select reservation date";
                Date_warning.Visible = true;
                date = false;
            }
            if (string.IsNullOrWhiteSpace(time.Text) == true)
            {
                Time_warning.Text = "*Please select reservation time";
                Time_warning.Visible = true;
                time_b = false;
            }
            if (string.IsNullOrEmpty(Cardnum_text.Text) != true)
            {
                if(string.IsNullOrEmpty(user_name) != true)
                {
                    string str = "select count(*) from signup where cardnumber=@search";
                    SqlCommand tb = new SqlCommand(str, con);
                    tb.Parameters.Add("@search", SqlDbType.VarChar).Value = Cardnum_text.Text;

                    bool exists = (int)tb.ExecuteScalar() > 0;
                    if (exists == true)
                    {
                        card_num = true;
                    }
                    else
                    {
                        Card_warning.Text = "*Wrong Special card number";
                        Card_warning.Visible = true;
                    }
                }
            }

            bool reser_success = false;

            if (first == true && last == true && phone == true && email == true && p_num == true && s_table == true && date == true && time_b == true)
            {
                if(card_num == true)
                {
                    while(table_id.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand("RESERVATION_ADD", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", First_text.Text);
                        cmd.Parameters.AddWithValue("@LastName", Last_text.Text);
                        cmd.Parameters.AddWithValue("@phone_number", Phone_text.Text);
                        cmd.Parameters.AddWithValue("@email_address", Email_text.Text);
                        cmd.Parameters.AddWithValue("@people_num", Convert.ToInt32(Peoplenum_text.Text));
                        cmd.Parameters.AddWithValue("@selected_table", table_id.Dequeue());
                        cmd.Parameters.AddWithValue("@reservation_date", Date_text.Text);
                        cmd.Parameters.AddWithValue("@reservation_time", time.Text);
                        cmd.Parameters.AddWithValue("@card_num", Cardnum_text.Text);
                        cmd.ExecuteNonQuery();
                    }
                    Session["Reservation_confirm"] = First_text.Text + " " + Last_text.Text;
                    Session["Reservation_detail"] = "You successfully reserved at " + Date_text.Text + " at " + time.Text;
                    Session["Special_discount"] = "5% discount";
                    reser_success = true;
                    mail_check = true;
                }
                else
                {
                    if(string.IsNullOrEmpty(Cardnum_text.Text) == true && string.IsNullOrEmpty(user_name) == true)
                    {
                        while (table_id.Count > 0)
                        {
                            SqlCommand cmd = new SqlCommand("RESERVATION_ADD", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@FirstName", First_text.Text);
                            cmd.Parameters.AddWithValue("@LastName", Last_text.Text);
                            cmd.Parameters.AddWithValue("@phone_number", Phone_text.Text);
                            cmd.Parameters.AddWithValue("@email_address", Email_text.Text);
                            cmd.Parameters.AddWithValue("@people_num", Convert.ToInt32(Peoplenum_text.Text));
                            cmd.Parameters.AddWithValue("@selected_table", table_id.Dequeue());
                            cmd.Parameters.AddWithValue("@reservation_date", Date_text.Text);
                            cmd.Parameters.AddWithValue("@reservation_time", time.Text);
                            cmd.Parameters.AddWithValue("@card_num", Cardnum_text.Text);
                            cmd.ExecuteNonQuery();
                        }
                        Session["Reservation_confirm"] = First_text.Text + " " + Last_text.Text;
                        Session["Reservation_detail"] = "You successfully reserved at " + Date_text.Text + " at " + time.Text;

                        reser_success = true;
                        mail_check = true;
                    }
                    else
                    {
                        if(string.IsNullOrEmpty(Card_warning.Text) == true)
                        {
                            Card_warning.Text = "*Please login first";
                            Card_warning.Visible = true;
                        }
                        return;
                    }
                }
            }
            if(mail_check == true)
            {
                try
                {
                    string from = "kimmo6072@gmail.com";
                    string subject = "Thank you for your Reservation";
                    string body = "Thank you " + First_text.Text + " " + Last_text.Text + "\n\nYou successfully reserved at " + Date_text.Text + " at " + time.Text
                                    + " with " + Peoplenum_text.Text + " people\n\nIt is our pleasure to serve you\n\nThank you\n\n" + "International Restaurant\nBrookings SD, 57006";
                    MailMessage message = new MailMessage(from, Email_text.Text);
                    message.Subject = subject;
                    message.Body = body;

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential()
                    {
                        UserName = "kimmo6072",
                        Password = "JunmoKim+457"
                    };
                    client.EnableSsl = true;
                    client.Send(message);
                }
                catch(Exception ex)
                {
                    Session["Not working"] = "Not working ";
                }
            }
            if(reser_success == true)
            {
                Response.Write("<script>alert('Your Reservation is successful with Special Discount!!');</script>");
                Response.Redirect("Reservation_confirm.aspx");
                Clear_data(sender, e);
            }
        }

        protected void Clear_data(object sender, EventArgs e)
        {
            Date_text.Text = Cardnum_text.Text = First_text.Text = Last_text.Text = Phone_text.Text = Email_text.Text = Peoplenum_text.Text = table_selected.Text = time.Text = "";
            Page_Load(sender, e);
        }

        protected void Deselect_table(int s)
        {
            bool sug = login_check;
            switch (s)
            {
                case 1:
                    if(sug == false)
                    {
                        T1.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T1.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 2:
                    if (sug == false)
                    {
                        T2.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T2.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 3:
                    if (sug == false)
                    {
                        T3.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T3.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 4:
                    if (sug == false)
                    {
                        T4.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T4.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 5:
                    if (sug == false)
                    {
                        T5.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T5.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 6:
                    if (sug == false)
                    {
                        T6.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T6.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 7:
                    if (sug == false)
                    {
                        T7.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T7.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 8:
                    T8.ImageUrl = "~/Images/table.png";
                    break;
                case 9:
                    T9.ImageUrl = "~/Images/table.png";
                    break;
                case 10:
                    T10.ImageUrl = "~/Images/table.png";
                    break;
                case 11:
                    T11.ImageUrl = "~/Images/table.png";
                    break;
                case 12:
                    if (sug == false)
                    {
                        T12.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T12.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 13:
                    if (sug == false)
                    {
                        T13.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T13.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 14:
                    T14.ImageUrl = "~/Images/table.png";
                    break;
                case 15:
                    T15.ImageUrl = "~/Images/table.png";
                    break;
                case 16:
                    T16.ImageUrl = "~/Images/table.png";
                    break;
                case 17:
                    T17.ImageUrl = "~/Images/table.png";
                    break;
                case 18:
                    if (sug == false)
                    {
                        T18.ImageUrl = "~/Images/table.png";
                    }
                    else
                    {
                        T18.ImageUrl = "~/Images/table_suggestion.png";
                    }
                    break;
                case 19:
                    T19.ImageUrl = "~/Images/table.png";
                    break;
                case 20:
                    T20.ImageUrl = "~/Images/table.png";
                    break;
                case 21:
                    T21.ImageUrl = "~/Images/table.png";
                    break;
                case 22:
                    T22.ImageUrl = "~/Images/table.png";
                    break;
                case 23:
                    T23.ImageUrl = "~/Images/table.png";
                    break;
                case 24:
                    T24.ImageUrl = "~/Images/table.png";
                    break;
            }
        }

        protected void T1_Click(object sender, EventArgs e)
        {
            if (T1.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T1.ID);
                    T1.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T1.ID);
                    T1.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if(T1.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T1.ID);
                    T1.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T1.ID);
                    T1.ImageUrl = "~/Images/table_selected.png";
                }
            }
            
        }

        protected void T2_Click(object sender, EventArgs e)
        {
            if (T2.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T2.ID);
                    T2.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T2.ID);
                    T2.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T2.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T2.ID);
                    T2.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T2.ID);
                    T2.ImageUrl = "~/Images/table_selected.png";
                }
            }
            
        }

        protected void T3_Click(object sender, EventArgs e)
        {
            if (T3.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T3.ID);
                    T3.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T3.ID);
                    T3.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T3.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T3.ID);
                    T3.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T3.ID);
                    T3.ImageUrl = "~/Images/table_selected.png";
                }
            }
            
        }

        protected void T4_Click(object sender, EventArgs e)
        {
            if (T4.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T4.ID);
                    T4.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T4.ID);
                    T4.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T4.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T4.ID);
                    T4.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T4.ID);
                    T4.ImageUrl = "~/Images/table_selected.png";
                }
            }
            
        }

        protected void T5_Click(object sender, EventArgs e)
        {
            if (T5.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T5.ID);
                    T5.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T5.ID);
                    T5.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T5.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T5.ID);
                    T5.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T5.ID);
                    T5.ImageUrl = "~/Images/table_selected.png";
                }
            }
            
        }

        protected void T6_Click(object sender, EventArgs e)
        {
            if (T6.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T6.ID);
                    T6.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T6.ID);
                    T6.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T6.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T6.ID);
                    T6.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T6.ID);
                    T6.ImageUrl = "~/Images/table_selected.png";
                }
            }
            
        }

        protected void T7_Click(object sender, EventArgs e)
        {
            if (T7.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T7.ID);
                    T7.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T7.ID);
                    T7.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T7.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T7.ID);
                    T7.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T7.ID);
                    T7.ImageUrl = "~/Images/table_selected.png";
                }
            }
            
        }

        protected void T8_Click(object sender, EventArgs e)
        {
            if (T8.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T8.ID);
                    T8.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T8.ID);
                    T8.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T9_Click(object sender, EventArgs e)
        {
            if (T9.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T9.ID);
                    T9.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T9.ID);
                    T9.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T10_Click(object sender, EventArgs e)
        {
            if (T10.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T10.ID);
                    T10.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T10.ID);
                    T10.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T11_Click(object sender, EventArgs e)
        {
            if (T11.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T11.ID);
                    T11.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T11.ID);
                    T11.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T12_Click(object sender, EventArgs e)
        {
            if (T12.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T12.ID);
                    T12.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T12.ID);
                    T12.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T12.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T12.ID);
                    T12.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T12.ID);
                    T12.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T13_Click(object sender, EventArgs e)
        {
            if (T13.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T13.ID);
                    T13.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T13.ID);
                    T13.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T13.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T13.ID);
                    T13.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T13.ID);
                    T13.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T14_Click(object sender, EventArgs e)
        {
            if (T14.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T14.ID);
                    T14.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T14.ID);
                    T14.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T15_Click(object sender, EventArgs e)
        {
            if (T15.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T15.ID);
                    T15.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T15.ID);
                    T15.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T16_Click(object sender, EventArgs e)
        {
            if (T16.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T16.ID);
                    T16.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T16.ID);
                    T16.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T17_Click(object sender, EventArgs e)
        {
            if (T17.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T17.ID);
                    T17.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T17.ID);
                    T17.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T18_Click(object sender, EventArgs e)
        {
            if (T18.ImageUrl.CompareTo("~/Images/table_suggestion.png") == 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T18.ID);
                    T18.ImageUrl = "~/Images/table_suggestion_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T18.ID);
                    T18.ImageUrl = "~/Images/table_suggestion_selected.png";
                }
            }
            else if (T18.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T18.ID);
                    T18.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T18.ID);
                    T18.ImageUrl = "~/Images/table_selected.png";
                }
            }
            
        }

        protected void T19_Click(object sender, EventArgs e)
        {
            if (T19.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T19.ID);
                    T19.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T19.ID);
                    T19.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T20_Click(object sender, EventArgs e)
        {
            if (T20.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T20.ID);
                    T20.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T20.ID);
                    T20.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T21_Click(object sender, EventArgs e)
        {
            if (T21.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T21.ID);
                    T21.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T21.ID);
                    T21.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T22_Click(object sender, EventArgs e)
        {
            if (T22.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T22.ID);
                    T22.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T22.ID);
                    T22.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T23_Click(object sender, EventArgs e)
        {
            if (T23.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T23.ID);
                    T23.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T23.ID);
                    T23.ImageUrl = "~/Images/table_selected.png";
                }
            }
        }

        protected void T24_Click(object sender, EventArgs e)
        {
            if (T24.ImageUrl.CompareTo("~/Images/table_unavailable.png") != 0)
            {
                if (people_number > 0)
                {
                    table_id.Enqueue(T24.ID);
                    T24.ImageUrl = "~/Images/table_selected.png";
                    people_number -= 1;
                }
                else if (people_number == 0 && table_id.Count != 0)
                {
                    Deselect_table(Convert.ToInt32(table_id.Dequeue().Substring(1)));
                    table_id.Enqueue(T24.ID);
                    T24.ImageUrl = "~/Images/table_selected.png";
                }
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
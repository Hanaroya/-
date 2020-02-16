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
    public partial class Purchase : System.Web.UI.Page
    {
        static string selected = "Food";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((String)Session["adname"]) == true)
            {
                Response.Write("<script>alert('Administrator only Accessible');</script>");
                Response.Redirect("menu.aspx");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    selected = "Food";
                    break;
                case 1:
                    selected = "Beverage";
                    break;
                case 2:
                    selected = "Ingredient";
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool item = false, qua = false, pri = false, em = false;

            if(string.IsNullOrEmpty(item_name.Text) == false)
            {
                item = true;
            }
            else
            {
                item_warning.Visible = true;
            }
            if (string.IsNullOrEmpty(quantity_text.Text) == false)
            {
                qua = true;
            }
            else
            {
                quantity_warning.Visible = true;
            }
            if (string.IsNullOrEmpty(price_text.Text) == false)
            {
                pri = true;
            }
            else
            {
                price_warning.Visible = true;
            }
            if (string.IsNullOrEmpty(email_text.Text) == false)
            {
                em = true;
            }
            else
            {
                email_warning.Visible = true;
            }

            if (em == true && pri == true && qua == true && item == true)
            {
                 try
                {
                    string from = "kimmo6072@gmail.com";
                    string subject = "Purchase " + selected +" request";
                    string line1 = "Purchase Item Details\n\n";
                    string line2 = selected + ": " +item_name.Text + "\n\n";
                    string line3 = "Quantity: " + quantity_text.Text + "lbs\n\n";
                    string line4 = "Price: $" + price_text.Text + "\n\n";
                    string line5 = "International Restaurant\nBrookings, SD 57006";
                    string body = line1 + line2 + line3 + line4 + line5;
                    MailMessage message = new MailMessage(from, email_text.Text);
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
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Purchase failed');</script>");
                }
                Response.Write("<script>alert('Purchase all set');</script>");

                item_name.Text = "";
                item_warning.Visible = false;

                quantity_text.Text = "";
                quantity_warning.Visible = false;

                price_text.Text = "";
                price_warning.Visible = false;

                email_text.Text = "";
                email_warning.Visible = false;
                Response.Redirect("Purchase.aspx");
            }
        }
    }
}
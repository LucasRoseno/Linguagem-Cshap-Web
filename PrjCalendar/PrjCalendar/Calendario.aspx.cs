using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalendar
{
    public partial class Calendario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string data1 = Calendar1.SelectedDate.ToShortDateString();
            TextBox1.Text = data1;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar2.SelectedDate.ToShortDateString();
        }

        protected void btnConvCompa_Click(object sender, EventArgs e)
        {
            var dateTime1 = DateTime.Parse(TextBox1.Text);
            var dateTime2 = DateTime.Parse(TextBox2.Text);
            

            if(dateTime1 >= dateTime2)
            {
                var x = dateTime1.Day - dateTime2.Day;
                

                lblMostrar.Text = x.ToString();
            }
            else
            {
                var y = dateTime2.Day - dateTime1.Day;
                lblMostrar.Text = y.ToString();


                
            }
        }
    }
}
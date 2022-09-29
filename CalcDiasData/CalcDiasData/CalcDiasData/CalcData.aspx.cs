using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcDiasData
{
    public partial class CalcData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var w = DateTime.Now.ToShortDateString();
            Label2.Text = "A data de hoje é:" + w;
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           
            txtCalen1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            var a = DateTime.Parse( txtCalen1.Text);
            var x =  DateTime.Parse(DateTime.Now.ToShortDateString());
            lblMostrar.Text = (x.Date - a.Date).ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var a = DateTime.Parse(txtCalen1.Text);
            var x = DateTime.Parse(DateTime.Now.ToShortDateString());
            lblAnos.Text = (x.Year - a.Year).ToString();
        }
    }
}
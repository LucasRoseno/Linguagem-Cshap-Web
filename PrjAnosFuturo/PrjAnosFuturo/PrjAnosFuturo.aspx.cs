using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjAnosFuturo
{
    public partial class PrjAnosFuturo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtCalen1.Text = Calendar1.SelectedDate.ToShortDateString();
            
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtCalen2.Text = Calendar2.SelectedDate.ToShortDateString();
            
        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            var a = DateTime.Parse(txtCalen1.Text);
            var b = DateTime.Parse(txtCalen2.Text);
            var c = DateTime.Parse(DateTime.Now.ToShortDateString());
            var anos = (b.Year - a.Year).ToString();
            var dias = (b.DayOfYear - a.DayOfYear);
            //var dias = ()

            if(dias < 0)
            {
                lblMostrar.Text = "De " + a + " até" + b + " o individuo terá " + anos + " e faltam " + (-1*dias) + " dias para seu aniversario ";
            }
            else
            {
                lblMostrar.Text = "De " + a + " até" + b + " o individuo terá " + anos + " anos e faltam " + (365-dias) + " dias para seu aniversario ";
            }

           
        }
    }
}
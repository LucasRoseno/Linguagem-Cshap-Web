using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalculadora
{
    public partial class Pagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txtVal2.Text;
            Double val2 = Double.Parse(v2); //converte para double


            //Console.WriteLine(val1 + val2);
            Double t = val1 + val2;
           // lblTotal 
            lblTotal.Text = t + "";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txtVal2.Text;
            Double val2 = Double.Parse(v2); //converte para double


            //Console.WriteLine(val1 + val2);
            Double t = val1 - val2;
            // lblTotal 
            lblTotal.Text = t + "";
        }

        protected void btnMult_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txtVal2.Text;
            Double val2 = Double.Parse(v2); //converte para double


            //Console.WriteLine(val1 + val2);
            Double t = val1 * val2;
            // lblTotal 
            lblTotal.Text = t + "";
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text;
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txtVal2.Text;
            Double val2 = Double.Parse(v2); //converte para double


            //Console.WriteLine(val1 + val2);
            Double t = val1 / val2;
            // lblTotal 
            lblTotal.Text = t + "";
        }

        protected void btnSeno_Click(object sender, EventArgs e)
        {
            String v1 = txtSeno.Text;
            Double val1 = Double.Parse(v1); //converte para double

            //Console.WriteLine(val1 + val2);
            Double t = Math.Sin(val1 * (Math.PI / 180));
            // lblTotal 
            totSeno.Text = t + "";
        }

        
    }
}
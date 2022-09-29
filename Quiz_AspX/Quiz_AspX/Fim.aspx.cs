using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_AspX
{
    public partial class Fim : System.Web.UI.Page
    {
        static int contPont = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            String perg1 = (String)Session["pergunta1"]; //type cast esse String dentro dos parenteses
            String perg2 = (String)Session["pergunta2"];
            String perg3 = (String)Session["pergunta3"];
            String perg4 = (String)Session["pergunta4"];
            String perg5 = (String)Session["pergunta5"];
            String perg6 = (String)Session["pergunta6"];
            String perg7 = (String)Session["pergunta7"];
            String perg8 = (String)Session["pergunta8"];
            String perg9 = (String)Session["pergunta9"];
            String perg10 = (String)Session["pergunta10"];

            if (perg1.Equals("s"))
                contPont++;
            if (perg2.Equals("s"))
                contPont++;
            if (perg3.Equals("s"))
                contPont++;
            if (perg4.Equals("s"))
                contPont++;
            if (perg5.Equals("s"))
                contPont++;
            if (perg6.Equals("s"))
                contPont++;
            if (perg7.Equals("s"))
                contPont++;
            if (perg8.Equals("s"))
                contPont++;
            if (perg9.Equals("s"))
                contPont++;
            if (perg10.Equals("s"))
                contPont++;



            if (contPont == 0)
            {
                lblResposta.Text = "0%";
            }
            else
            {
                double por = contPont * 10;
                lblResposta.Text = " "+ por.ToString()+ "%";
            }
            
        }
    }
}
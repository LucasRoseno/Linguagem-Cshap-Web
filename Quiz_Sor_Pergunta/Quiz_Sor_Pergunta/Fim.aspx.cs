using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Sor_Pergunta
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


            int numero = contPont;
            double por = numero * 10;
            if (numero == 0)
            {
                lblResposta.Text = "0%";
            }
            else
            {
                
                lblResposta.Text = " " + por.ToString() + "%";
            }


            if (por < 50) {
                Image1.ImageUrl = "~/Imagens/motivacional.jpg";
                Image2.ImageUrl = "~/Imagens/motivac.jpg";
            }
            else
            {
                Image1.ImageUrl = "~/Imagens/rockLee.jpg";
                Image2.ImageUrl = "~/Imagens/parabens.jpg";
            }
        }

    }
}
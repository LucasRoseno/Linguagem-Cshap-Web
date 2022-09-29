using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace PrjASPXJogoDados
{
    public partial class JogoDados : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        int dado;
        protected void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            dado = random.Next(1, 7);

            // QUAL A DIFERENÇA DE IF PRA CASE????
            switch (dado)
            {
                case 1:
                    Image1.ImageUrl = "~/Imagens/dado1.png";
                    break;
                case 2:
                    Image1.ImageUrl = "~/Imagens/dado2.png";
                    break;
               case 3:
                    Image1.ImageUrl = "~/Imagens/dado3.png";
                    break;
               case 4:
                    Image1.ImageUrl = "~/Imagens/dado4.png";
                    break;
              case 5:
                    Image1.ImageUrl = "~/Imagens/dado5.png";
                    break;
              case 6:
                    Image1.ImageUrl = "~/Imagens/dado6.png";
                    break;

            }
            
        }
    }
}
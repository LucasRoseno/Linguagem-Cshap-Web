using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjForcaAspx_Lucas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAvaliar_Click(object sender, EventArgs e)
        {
            string palavraChave = "ana";
            int erros = 0;
            string letraChave1 = palavraChave.ElementAt(0).ToString();
            string letraChave2 = palavraChave.ElementAt(1).ToString();
            string letraChave3 = palavraChave.ElementAt(2).ToString();


            /*         if (letraChave1 == txtBox1.Text)
                         lbl1.Text = "A";

                     else if (letraChave1 != txtBox1.Text)
                         Img1.ImageUrl = "~/Imagens/head.png";


                     if (letraChave2 == txtBox2.Text)
                         lbl1.Text = "N";

                     else if (letraChave2 != txtBox2.Text)

                       //  Img2.ImageUrl = "~/Imagens/body.png";


                     if (letraChave3 == txtBox3.Text)

                     //    lbl1.Text = "A";

                     else if (letraChave3 != txtBox3.Text)

                         Img3.ImageUrl = "~/Imagens/legs.png";
                     */

            if (letraChave1 != txtBox1.Text)
                erros = 1;
            else if (letraChave2 != txtBox2.Text)
                erros = 1;
            else if ( letraChave3 != txtBox3.Text)
                erros = 1;


            if (letraChave2 != txtBox2.Text && letraChave1 != txtBox1.Text)
                erros = 2;
            else if (letraChave2 != txtBox2.Text && letraChave3 != txtBox3.Text)
                erros = 2;
            else if(letraChave1 != txtBox1.Text && letraChave3 != txtBox3.Text)
                erros  = 2;

            if (letraChave3 != txtBox3.Text && letraChave2 != txtBox2.Text && letraChave1 != txtBox1.Text)
                erros = 3;


             if (erros == 1){
                Img1.ImageUrl = "~/Imagens/head.png";
             }           
             else if (erros == 2){
                Img1.ImageUrl = "~/Imagens/head.png";
                Img2.ImageUrl = "~/Imagens/body.png";
             }
             else if(erros == 3){
                Img1.ImageUrl = "~/Imagens/head.png";
                Img2.ImageUrl = "~/Imagens/body.png";
                Img3.ImageUrl = "~/Imagens/legs.png";
             }


        }

    }
}
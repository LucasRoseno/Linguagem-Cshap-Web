using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bingo_AspX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string[] x = new string[30] ;
        string[] y = new string[30] ;
        String Resultado = "";
        Random numCliente = new Random();

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                Resultado = Resultado + " " + numCliente.Next(1, 7);
                if (x[i] != y[i])
                {
                    lblExibir.Text = Resultado;
                    
                    
                }
                break;

            }





            /*  for (int i = 0; i < 7; i++)
              {
                  Inicio:
                  sorteado = numCliente.Next(first, last);
                  for (int k = 0; k < 7; k++)
                  {
                      if (Verificador[k] == sorteado)
                      {
                          goto Inicio;
                      }
                      break;
                  }

                  Resultado = Resultado + " " + numCliente.Next(first, last);
                  Verificador[i] = sorteado;
                  lblExibir.Text = Resultado; 

*/

        }
        }
    }

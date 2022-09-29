using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BingoCorreção_Aspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        const int MAX = 7;
        static int []sorteados = new int[MAX];
        static int uni = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int cont = 0;

            while (cont < MAX)
            {
                int n = rd.Next(1, MAX + 1);
                
                bool achou = false;
                for(int i=0; i<sorteados.Length; i++)
                {
                    if(n == sorteados[i])
                    {
                        achou = true;
                    }

                }
                if (!achou)
                {
                    sorteados[cont] = n;
                    cont++;
                }
                
            }
            for (int i = 0; i < sorteados.Length; i++)
            {
                ListMostrar.Items.Add(sorteados[i] + "");
                
            }

            
        }


        protected void btnUni_Click(object sender, EventArgs e)
        {


            if (uni != MAX)
            {
                lblUni.Text = sorteados[uni] + "";
                lblSeq.Text = lblSeq.Text + sorteados[uni] + ",";
                uni++;
            }
            else
                lblUni.Text = "bla bla bla";
            
        }
                
            
                

               }
            
                
        }
    

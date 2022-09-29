using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjListaAniversarios
{
    public partial class listaAniversario : System.Web.UI.Page

    {
     static List<string> lstNomes = new List<string>();
     static List<DateTime> datas = new List<DateTime>();
        static List<DateTime> idade = new List<DateTime>();
        
        
        
        //string[] lstnomes = new string[8];
        // DateTime[] datas = new DateTime[8];

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        

        

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            string n = txtInsNome.Text;
            lstNomes.Add(n);
            txtInsNome.Text = "";

            var dt = DateTime.Parse(txtInsData.Text);
            datas.Add(dt);
            txtInsData.Text = "";

            
        }

        protected void btnNomeIdade_Click(object sender, EventArgs e)
        {


            string s = "";
            for (int x = 0; x < lstNomes.Count(); x++)
            {
                 
              string nom = lstNomes.ElementAt(x);
                var cont = datas.ElementAt(x).Year;
               string idd = datas.ElementAt(x).ToShortDateString();
                var idadeAtu = DateTime.Now.Year - cont;
                s += ("Nome: " + nom + " Nasceu em: " + idd) +" Tem: "+idadeAtu+" anos" +"<br>" ;
                

            }
            lblMostrar.Text = s;
            

        }
    }
}
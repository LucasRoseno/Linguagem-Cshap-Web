using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tradutor_AspX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string[] port= new string[3] { "casa", "mesa", "porta"};
        string[] ing = new string[3] { "house", "table", "door" };
        int[] num = new int[3];
        protected void btnTraduzir_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                if (txtBox.Text == port[i])
                {
                    lblMostrar.Text = ing[i];

                    break;
                }
                else
                {
                    lblMostrar.Text = "Essa palavra não está no banco de dados ou não pode ser traduzida";
                }
                
            }



         /*   while(txtBox.Text == port[1])
            {
                lblMostrar.Text =  ing[1];
                break;
            }
            while (txtBox.Text == port[2])
            {
                lblMostrar.Text = ing[2];
                break;
            } */
        }
    }
}
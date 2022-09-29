using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Sor_Pergunta
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        const int MAX = 2;
        const int BASE = MAX - 1;
        string[] sort = new string[] { "macaco velho....", "jacaré no seco....", "a Deus" };
        string[] resp1 = new string[] { "come formiga", "bebe pedra", "bebe agua de canudo" };
        string[] resp2 = new string[] { "flutua", "anda", "nada" };
        string[] resp3 = new string[] { "dirí", "deré", "dará" };

        string ww = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Random rd = new Random();
                int ss = rd.Next(0, MAX + 1);
                int cont = 0;

                ww = sort[ss].ToString();
                lblMostrar.Text = ww.ToString();

                if (ww == sort[0])
                {
                    rdoOpc1.Text = resp1[0];
                    rdoOpc2.Text = resp1[1];
                    rdoOpc3.Text = resp1[2];
                }
                if (ww == sort[1])
                {
                    rdoOpc1.Text = resp2[0];
                    rdoOpc2.Text = resp2[1];
                    rdoOpc3.Text = resp2[2];
                }
                if (ww == sort[2])
                {
                    rdoOpc1.Text = resp3[0];
                    rdoOpc2.Text = resp3[1];
                    rdoOpc3.Text = resp3[2];
                }
            }
        }

        protected void btnProx_Click(object sender, EventArgs e)
        {
            String resultado = "";
            if (rdoOpc1.Checked)
                resultado = "n";
            if (rdoOpc2.Checked)
                resultado = "n";
            if (rdoOpc3.Checked)
                resultado = "s";

            Session["pergunta8"] = resultado;
            Response.Redirect("WebForm9.aspx");
        }
    }
}
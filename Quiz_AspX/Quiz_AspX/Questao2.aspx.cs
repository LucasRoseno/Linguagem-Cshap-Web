using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_AspX
{
    public partial class Questao2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProximi_Click(object sender, EventArgs e)
        {
            String resultado = "";//letra maiuscula => Classe ;;;; letra minuscula =>
            if (rdoOpc1.Checked)
                resultado = "s";
            if (rdoOpc2.Checked)
                resultado = "n";
            if (rdoOpc3.Checked)
                resultado = "n";
            if (rdoOpc4.Checked)
                resultado = "n";

            Session["pergunta2"] = resultado;
            Response.Redirect("Questao3.aspx");
        }
    }
}
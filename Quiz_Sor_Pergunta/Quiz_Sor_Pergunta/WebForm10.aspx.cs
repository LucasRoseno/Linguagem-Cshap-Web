﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz_Sor_Pergunta
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        const int MAX = 2;
        const int BASE = MAX - 1;
        string[] sort = new string[] { "casa suja", "o rato roeu a ", "aranha arranha a" };
        string[] resp1 = new string[] { "xao xuxu", "chão sujo", "chão xuxu" };
        string[] resp2 = new string[] { "casa do rei da frança", "roupa do rei de Roma", "o queijo" };
        string[] resp3 = new string[] { "aranha", "rã", "aranha-rã" };

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
                resultado = "s";
            if (rdoOpc3.Checked)
                resultado = "n";

            Session["pergunta10"] = resultado;
            Response.Redirect("Fim.aspx");
        }
    }
}
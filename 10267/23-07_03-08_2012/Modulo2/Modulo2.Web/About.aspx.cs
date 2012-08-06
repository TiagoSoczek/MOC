using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo2.Web
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Warn("Carregando...");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Trace.Warn("Init...");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ValidacaoNome validacao = new ValidacaoNome();
            
            if (validacao.Validar(TextBox1.Text))
            {
                Label1.Text = "Nome Correto";
            }
            else
            {
                Label1.Text = "Nome Incorreto";
            }

            Trace.Warn(Label1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.BackColor = System.Drawing.Color.RoyalBlue;
        }
    }
}

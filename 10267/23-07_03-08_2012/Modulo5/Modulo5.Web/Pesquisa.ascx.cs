using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo5.Web
{
    public partial class Pesquisa : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int tempo = rnd.Next(0, 100);

            lblResultado.Text = string.Format(@"Pesquisa por: {0} 
                retornou em {1}ms", txtPesquisa.Text, tempo);
        }
    }
}
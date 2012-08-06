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

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtTermo.Text;

            lblResultado.Text = string.Format("Resultados para o termo '{0}'", termo);
        }
    }
}
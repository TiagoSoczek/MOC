using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo5.Web
{
    public partial class NovoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Write("Novo CLiente");
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length >= 3 && 
                args.Value.Length <= 10;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            Trace.Write("Salvar");
        }
    }
}
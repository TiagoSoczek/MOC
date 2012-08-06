using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo7.Web
{
    using System.Diagnostics;

    public partial class ListagemClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.Write("Teste de debug");
            Trace.Write("Listagem de clientes");

            string nome = Request.QueryString["Nome"];

            Debug.Assert(!string.IsNullOrWhiteSpace(nome), "Um nome deve ser informado");
        }
    }
}
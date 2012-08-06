using System;

namespace Modulo12.Web
{
    using Servicos;

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object autenticado = Session["Autenticado"];

            bool usuarioValido = false;

            if (autenticado != null)
            {
                usuarioValido = (bool) autenticado;
            }

            pnlLogin.Visible = !usuarioValido;
            pnlLogado.Visible = usuarioValido;
        }

        protected void btnAutenticar_Click(object sender, EventArgs e)
        {
            ControleAcessoServiceClient controleAcesso = new ControleAcessoServiceClient();

            var usuarioValido = controleAcesso.Validar(txtNome.Text, txtSenha.Text);

            lblResultado.Text = usuarioValido.ToString();
            
            Session["Autenticado"] = usuarioValido;

            if (usuarioValido)
            {
                Response.Redirect("~/");
            }
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Abandon();

            Response.Redirect("~/");
        }
    }
}